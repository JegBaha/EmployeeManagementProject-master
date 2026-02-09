using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public partial class ControlSalary : UserControl
    {
        private EmployeeDAL dal = new EmployeeDAL();

        public ControlSalary()
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

            // Grid panel
            panelGrid.BackColor = ThemeColors.CardBackground;
            ThemeColors.StyleDataGridView(salaryGrid);

            // Form panel
            panelForm.BackColor = ThemeColors.CardBackground;

            lblFormTitle.Font = ThemeColors.SubHeaderFont;
            lblFormTitle.ForeColor = ThemeColors.TextDark;

            // Labels and TextBoxes
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
            }

            // Buttons
            ThemeColors.StyleButton(updateSalaryButton, ThemeColors.PrimaryBlue);
            ThemeColors.StyleButton(clearSalaryButton, ThemeColors.TextLight);
        }

        public void RefreshData()
        {
            try
            {
                List<Employee> employees = dal.GetAllEmployees();
                salaryGrid.DataSource = employees;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (salaryGrid.Columns.Count > 0)
            {
                if (salaryGrid.Columns["ID"] != null) salaryGrid.Columns["ID"].Visible = false;
                if (salaryGrid.Columns["Gender"] != null) salaryGrid.Columns["Gender"].Visible = false;
                if (salaryGrid.Columns["Email"] != null) salaryGrid.Columns["Email"].Visible = false;
                if (salaryGrid.Columns["InsertDate"] != null) salaryGrid.Columns["InsertDate"].Visible = false;
                if (salaryGrid.Columns["UpdateDate"] != null) salaryGrid.Columns["UpdateDate"].Visible = false;
                if (salaryGrid.Columns["DeleteDate"] != null) salaryGrid.Columns["DeleteDate"].Visible = false;

                if (salaryGrid.Columns["EmployeeID"] != null) salaryGrid.Columns["EmployeeID"].HeaderText = "Personel No";
                if (salaryGrid.Columns["FullName"] != null) salaryGrid.Columns["FullName"].HeaderText = "Ad Soyad";
                if (salaryGrid.Columns["Department"] != null) salaryGrid.Columns["Department"].HeaderText = "Departman";
                if (salaryGrid.Columns["Salary"] != null) salaryGrid.Columns["Salary"].HeaderText = "Maaş (TL)";
                if (salaryGrid.Columns["Status"] != null) salaryGrid.Columns["Status"].HeaderText = "Durum";
            }
        }

        private void salaryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = salaryGrid.Rows[e.RowIndex];
                txtEmpId.Text = row.Cells["EmployeeID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtDepartment.Text = row.Cells["Department"].Value?.ToString() ?? "";
                txtSalary.Text = row.Cells["Salary"].Value?.ToString() ?? "";
            }
        }

        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpId.Text))
            {
                MessageBox.Show("Lütfen tablodan bir çalışan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSalary.Text.Trim(), out int newSalary) || newSalary < 0)
            {
                MessageBox.Show("Lütfen geçerli bir maaş tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show(
                    txtFullName.Text + " adlı çalışanın maaşını " + newSalary.ToString("N0") + " TL olarak güncellemek istiyor musunuz?",
                    "Maaş Güncelleme",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dal.UpdateSalary(txtEmpId.Text.Trim(), newSalary))
                    {
                        MessageBox.Show("Maaş başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Maaş güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearSalaryButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmpId.Clear();
            txtFullName.Clear();
            txtDepartment.Clear();
            txtSalary.Clear();
        }
    }
}
