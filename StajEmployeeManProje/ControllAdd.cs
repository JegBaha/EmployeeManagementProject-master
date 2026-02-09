using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public partial class ControllAdd : UserControl
    {
        private EmployeeDAL dal = new EmployeeDAL();

        public ControllAdd()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeColors.Background;

            // Page title
            lblPageTitle.Font = ThemeColors.SubHeaderFont;
            lblPageTitle.ForeColor = ThemeColors.TextDark;

            // Grid
            panelGrid.BackColor = ThemeColors.CardBackground;
            ThemeColors.StyleDataGridView(addDataGrid);

            // Form panel
            panelForm.BackColor = ThemeColors.CardBackground;

            // Labels
            foreach (Control ctrl in panelForm.Controls)
            {
                if (ctrl is Label lbl && lbl != lblFormTitle)
                {
                    lbl.Font = ThemeColors.LabelFontBold;
                    lbl.ForeColor = ThemeColors.TextDark;
                }
                if (ctrl is TextBox txt)
                {
                    ThemeColors.StyleTextBox(txt);
                }
                if (ctrl is ComboBox cmb)
                {
                    ThemeColors.StyleComboBox(cmb);
                }
            }

            lblFormTitle.Font = ThemeColors.SubHeaderFont;
            lblFormTitle.ForeColor = ThemeColors.TextDark;

            // Search
            ThemeColors.StyleTextBox(searchTextBox);
            lblSearch.Font = ThemeColors.LabelFontBold;
            lblSearch.ForeColor = ThemeColors.TextDark;

            // Buttons
            ThemeColors.StyleButton(addButton, ThemeColors.Success);
            ThemeColors.StyleButton(updateButton, ThemeColors.PrimaryBlue);
            ThemeColors.StyleButton(deleteButton, ThemeColors.Danger);
            ThemeColors.StyleButton(clearButton, ThemeColors.TextLight);

            // ComboBox items
            genderCombo.Items.AddRange(new object[] { "Erkek", "Kadın" });
            statusCombo.Items.AddRange(new object[] { "Aktif", "Pasif", "İzinli" });
        }

        public void RefreshData()
        {
            try
            {
                List<Employee> employees = dal.GetAllEmployees();
                addDataGrid.DataSource = employees;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (addDataGrid.Columns.Count > 0)
            {
                if (addDataGrid.Columns["ID"] != null) addDataGrid.Columns["ID"].Visible = false;
                if (addDataGrid.Columns["InsertDate"] != null) addDataGrid.Columns["InsertDate"].Visible = false;
                if (addDataGrid.Columns["UpdateDate"] != null) addDataGrid.Columns["UpdateDate"].Visible = false;
                if (addDataGrid.Columns["DeleteDate"] != null) addDataGrid.Columns["DeleteDate"].Visible = false;

                if (addDataGrid.Columns["EmployeeID"] != null) addDataGrid.Columns["EmployeeID"].HeaderText = "Personel No";
                if (addDataGrid.Columns["FullName"] != null) addDataGrid.Columns["FullName"].HeaderText = "Ad Soyad";
                if (addDataGrid.Columns["Gender"] != null) addDataGrid.Columns["Gender"].HeaderText = "Cinsiyet";
                if (addDataGrid.Columns["Email"] != null) addDataGrid.Columns["Email"].HeaderText = "E-posta";
                if (addDataGrid.Columns["Department"] != null) addDataGrid.Columns["Department"].HeaderText = "Departman";
                if (addDataGrid.Columns["Salary"] != null) addDataGrid.Columns["Salary"].HeaderText = "Maaş";
                if (addDataGrid.Columns["Status"] != null) addDataGrid.Columns["Status"].HeaderText = "Durum";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                Employee emp = new Employee
                {
                    EmployeeID = idText.Text.Trim(),
                    FullName = nameText.Text.Trim(),
                    Gender = genderCombo.Text,
                    Email = emailText.Text.Trim(),
                    Department = departmanText.Text.Trim(),
                    Status = statusCombo.Text
                };

                if (dal.AddEmployee(emp))
                {
                    MessageBox.Show("Çalışan başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Bu personel numarası zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (string.IsNullOrWhiteSpace(idText.Text))
            {
                MessageBox.Show("Güncellenecek çalışanı tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Employee emp = new Employee
                {
                    EmployeeID = idText.Text.Trim(),
                    FullName = nameText.Text.Trim(),
                    Gender = genderCombo.Text,
                    Email = emailText.Text.Trim(),
                    Department = departmanText.Text.Trim(),
                    Salary = int.TryParse(salaryText.Text, out int sal) ? sal : 0,
                    Status = statusCombo.Text
                };

                if (dal.UpdateEmployee(emp))
                {
                    MessageBox.Show("Çalışan bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idText.Text))
            {
                MessageBox.Show("Silinecek çalışanı tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                nameText.Text + " adlı çalışanı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dal.DeleteEmployee(idText.Text.Trim()))
                    {
                        MessageBox.Show("Çalışan başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = addDataGrid.Rows[e.RowIndex];
                idText.Text = row.Cells["EmployeeID"].Value?.ToString() ?? "";
                nameText.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                emailText.Text = row.Cells["Email"].Value?.ToString() ?? "";
                departmanText.Text = row.Cells["Department"].Value?.ToString() ?? "";
                salaryText.Text = row.Cells["Salary"].Value?.ToString() ?? "";

                string gender = row.Cells["Gender"].Value?.ToString() ?? "";
                genderCombo.SelectedIndex = genderCombo.FindStringExact(gender);

                string status = row.Cells["Status"].Value?.ToString() ?? "";
                statusCombo.SelectedIndex = statusCombo.FindStringExact(status);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = searchTextBox.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    RefreshData();
                }
                else
                {
                    addDataGrid.DataSource = dal.SearchEmployees(search);
                    FormatGrid();
                }
            }
            catch { }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(idText.Text) ||
                string.IsNullOrWhiteSpace(nameText.Text) ||
                string.IsNullOrWhiteSpace(emailText.Text) ||
                string.IsNullOrWhiteSpace(genderCombo.Text) ||
                string.IsNullOrWhiteSpace(departmanText.Text) ||
                string.IsNullOrWhiteSpace(statusCombo.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            idText.Clear();
            nameText.Clear();
            emailText.Clear();
            departmanText.Clear();
            salaryText.Clear();
            genderCombo.SelectedIndex = -1;
            statusCombo.SelectedIndex = -1;
            searchTextBox.Clear();
        }
    }
}
