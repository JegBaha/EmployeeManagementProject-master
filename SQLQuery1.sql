-- =============================================
-- Employee Management System - Database Schema
-- =============================================

-- Users table (Authentication)
CREATE TABLE employees(
    id INT PRIMARY KEY IDENTITY(1,1),
    eName VARCHAR(100) NOT NULL,
    ePass VARCHAR(100) NOT NULL,
    registerDate DATE NULL
)

-- Employees data table
CREATE TABLE employeesThing(
    id INT PRIMARY KEY IDENTITY(1,1),
    employeeID VARCHAR(20) NOT NULL,
    fullName VARCHAR(100) NOT NULL,
    gender VARCHAR(10) NULL,
    email VARCHAR(100) NULL,
    departman VARCHAR(50) NULL,
    salary INT DEFAULT 0,
    insertDate DATE NULL,
    updateDate DATE NULL,
    deleteDate DATE NULL,
    status VARCHAR(20) DEFAULT 'Aktif'
)

-- =============================================
-- Sample Data
-- =============================================

-- Admin user
INSERT INTO employees (eName, ePass, registerDate)
VALUES ('admin', 'admin123', GETDATE())

-- Sample employees
INSERT INTO employeesThing (employeeID, fullName, gender, email, departman, salary, insertDate, status)
VALUES
('EMP001', 'Ahmet Yilmaz', 'Erkek', 'ahmet.yilmaz@hospital.com', 'Bilgi Teknolojileri', 35000, GETDATE(), 'Aktif'),
('EMP002', 'Elif Demir', 'Kadin', 'elif.demir@hospital.com', 'Insan Kaynaklari', 32000, GETDATE(), 'Aktif'),
('EMP003', 'Mehmet Kaya', 'Erkek', 'mehmet.kaya@hospital.com', 'Muhasebe', 30000, GETDATE(), 'Aktif'),
('EMP004', 'Fatma Celik', 'Kadin', 'fatma.celik@hospital.com', 'Bilgi Teknolojileri', 38000, GETDATE(), 'Aktif'),
('EMP005', 'Ali Ozturk', 'Erkek', 'ali.ozturk@hospital.com', 'Teknik Destek', 28000, GETDATE(), 'Aktif'),
('EMP006', 'Ayse Arslan', 'Kadin', 'ayse.arslan@hospital.com', 'Insan Kaynaklari', 33000, GETDATE(), 'Aktif'),
('EMP007', 'Hasan Koc', 'Erkek', 'hasan.koc@hospital.com', 'Muhasebe', 31000, GETDATE(), 'Aktif'),
('EMP008', 'Zeynep Sahin', 'Kadin', 'zeynep.sahin@hospital.com', 'Bilgi Teknolojileri', 36000, GETDATE(), 'Aktif')

-- =============================================
-- Useful Queries
-- =============================================

-- List all active employees
SELECT * FROM employeesThing WHERE deleteDate IS NULL ORDER BY id DESC

-- Get employee statistics
SELECT
    COUNT(*) AS TotalActive,
    SUM(CASE WHEN status = 'Aktif' OR status IS NULL THEN 1 ELSE 0 END) AS Active,
    (SELECT COUNT(*) FROM employeesThing WHERE deleteDate IS NOT NULL) AS Inactive
FROM employeesThing
WHERE deleteDate IS NULL
