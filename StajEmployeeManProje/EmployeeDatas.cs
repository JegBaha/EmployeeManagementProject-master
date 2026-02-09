using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StajEmployeeManProje
{
    // Employee Model
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }

    // Data Access Layer
    public class EmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM employeesThing WHERE deleteDate IS NULL ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(MapEmployee(reader));
                        }
                    }
                }
            }
            return employees;
        }

        public List<Employee> SearchEmployees(string searchTerm)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM employeesThing WHERE deleteDate IS NULL AND (fullName LIKE @search OR employeeID LIKE @search OR departman LIKE @search) ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(MapEmployee(reader));
                        }
                    }
                }
            }
            return employees;
        }

        public bool AddEmployee(Employee emp)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Check duplicate
                string checkQuery = "SELECT COUNT(*) FROM employeesThing WHERE employeeID = @empID AND deleteDate IS NULL";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@empID", emp.EmployeeID);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0) return false;
                }

                string insertQuery = @"INSERT INTO employeesThing
                    (employeeID, fullName, gender, email, departman, salary, insertDate, status)
                    VALUES (@employeeID, @fullName, @gender, @email, @departman, @salary, @insertDate, @status)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", emp.EmployeeID);
                    cmd.Parameters.AddWithValue("@fullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@departman", emp.Department);
                    cmd.Parameters.AddWithValue("@salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@insertDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@status", emp.Status ?? "Aktif");
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string updateQuery = @"UPDATE employeesThing SET
                    fullName = @fullName,
                    gender = @gender,
                    email = @email,
                    departman = @departman,
                    salary = @salary,
                    status = @status,
                    updateDate = @updateDate
                    WHERE employeeID = @employeeID AND deleteDate IS NULL";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", emp.EmployeeID);
                    cmd.Parameters.AddWithValue("@fullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@departman", emp.Department);
                    cmd.Parameters.AddWithValue("@salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@status", emp.Status ?? "Aktif");
                    cmd.Parameters.AddWithValue("@updateDate", DateTime.Today);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteEmployee(string employeeID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string deleteQuery = "UPDATE employeesThing SET deleteDate = @deleteDate, status = @status WHERE employeeID = @employeeID AND deleteDate IS NULL";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@deleteDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@status", "Pasif");
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateSalary(string employeeID, int newSalary)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE employeesThing SET salary = @salary, updateDate = @updateDate WHERE employeeID = @employeeID AND deleteDate IS NULL";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@salary", newSalary);
                    cmd.Parameters.AddWithValue("@updateDate", DateTime.Today);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Dashboard statistics
        public int GetTotalCount()
        {
            return GetCount("SELECT COUNT(*) FROM employeesThing WHERE deleteDate IS NULL");
        }

        public int GetActiveCount()
        {
            return GetCount("SELECT COUNT(*) FROM employeesThing WHERE deleteDate IS NULL AND (status = 'Aktif' OR status IS NULL)");
        }

        public int GetInactiveCount()
        {
            return GetCount("SELECT COUNT(*) FROM employeesThing WHERE deleteDate IS NOT NULL");
        }

        public List<Employee> GetRecentEmployees(int top = 10)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = $"SELECT TOP {top} * FROM employeesThing WHERE deleteDate IS NULL ORDER BY insertDate DESC, id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(MapEmployee(reader));
                        }
                    }
                }
            }
            return employees;
        }

        // User authentication
        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM employees WHERE eName = @username AND ePass = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public bool RegisterUser(string username, string password)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Check existing
                string checkQuery = "SELECT COUNT(*) FROM employees WHERE eName = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    if ((int)checkCmd.ExecuteScalar() > 0) return false;
                }

                string insertQuery = "INSERT INTO employees (eName, ePass, registerDate) VALUES (@username, @password, @date)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        private int GetCount(string query)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private Employee MapEmployee(SqlDataReader reader)
        {
            return new Employee
            {
                ID = (int)reader["id"],
                EmployeeID = reader["employeeID"]?.ToString() ?? "",
                FullName = reader["fullName"]?.ToString() ?? "",
                Gender = reader["gender"]?.ToString() ?? "",
                Email = reader["email"]?.ToString() ?? "",
                Department = reader["departman"]?.ToString() ?? "",
                Salary = reader["salary"] != DBNull.Value ? (int)reader["salary"] : 0,
                Status = reader["status"]?.ToString() ?? "Aktif"
            };
        }
    }
}
