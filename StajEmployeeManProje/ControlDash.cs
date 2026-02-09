using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public partial class ControlDash : UserControl
    {
        private EmployeeDAL dal = new EmployeeDAL();

        public ControlDash()
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

            // Cards
            StyleCard(panelTotalCard, ThemeColors.PrimaryBlue);
            StyleCard(panelActiveCard, ThemeColors.Success);
            StyleCard(panelInactiveCard, ThemeColors.Danger);

            // Card labels
            lblTotalCount.Font = ThemeColors.CardNumberFont;
            lblTotalCount.ForeColor = ThemeColors.TextWhite;
            lblTotalTitle.Font = ThemeColors.CardTitleFont;
            lblTotalTitle.ForeColor = Color.FromArgb(220, 220, 220);

            lblActiveCount.Font = ThemeColors.CardNumberFont;
            lblActiveCount.ForeColor = ThemeColors.TextWhite;
            lblActiveTitle.Font = ThemeColors.CardTitleFont;
            lblActiveTitle.ForeColor = Color.FromArgb(220, 220, 220);

            lblInactiveCount.Font = ThemeColors.CardNumberFont;
            lblInactiveCount.ForeColor = ThemeColors.TextWhite;
            lblInactiveTitle.Font = ThemeColors.CardTitleFont;
            lblInactiveTitle.ForeColor = Color.FromArgb(220, 220, 220);

            // Recent employees section
            lblRecentTitle.Font = ThemeColors.SubHeaderFont;
            lblRecentTitle.ForeColor = ThemeColors.TextDark;

            panelRecentGrid.BackColor = ThemeColors.CardBackground;
            ThemeColors.StyleDataGridView(recentGrid);
        }

        private void StyleCard(Panel card, Color bgColor)
        {
            card.BackColor = bgColor;
        }

        public void RefreshData()
        {
            try
            {
                lblTotalCount.Text = dal.GetTotalCount().ToString();
                lblActiveCount.Text = dal.GetActiveCount().ToString();
                lblInactiveCount.Text = dal.GetInactiveCount().ToString();

                List<Employee> recent = dal.GetRecentEmployees(10);
                recentGrid.DataSource = recent;

                if (recentGrid.Columns.Count > 0)
                {
                    if (recentGrid.Columns["ID"] != null) recentGrid.Columns["ID"].Visible = false;
                    if (recentGrid.Columns["InsertDate"] != null) recentGrid.Columns["InsertDate"].Visible = false;
                    if (recentGrid.Columns["UpdateDate"] != null) recentGrid.Columns["UpdateDate"].Visible = false;
                    if (recentGrid.Columns["DeleteDate"] != null) recentGrid.Columns["DeleteDate"].Visible = false;

                    if (recentGrid.Columns["EmployeeID"] != null) recentGrid.Columns["EmployeeID"].HeaderText = "Personel No";
                    if (recentGrid.Columns["FullName"] != null) recentGrid.Columns["FullName"].HeaderText = "Ad Soyad";
                    if (recentGrid.Columns["Gender"] != null) recentGrid.Columns["Gender"].HeaderText = "Cinsiyet";
                    if (recentGrid.Columns["Email"] != null) recentGrid.Columns["Email"].HeaderText = "E-posta";
                    if (recentGrid.Columns["Department"] != null) recentGrid.Columns["Department"].HeaderText = "Departman";
                    if (recentGrid.Columns["Salary"] != null) recentGrid.Columns["Salary"].HeaderText = "Maaş";
                    if (recentGrid.Columns["Status"] != null) recentGrid.Columns["Status"].HeaderText = "Durum";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
