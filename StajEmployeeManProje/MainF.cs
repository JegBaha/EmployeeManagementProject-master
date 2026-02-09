using System;
using System.Drawing;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public partial class MainF : Form
    {
        private Button activeButton;

        public MainF()
        {
            InitializeComponent();
            ApplyTheme();
            ShowDashboard();
        }

        private void ApplyTheme()
        {
            // Header
            panelHeader.BackColor = Color.White;

            // Sidebar
            panelSidebar.BackColor = ThemeColors.PrimaryDark;

            // Content area
            panelContent.BackColor = ThemeColors.Background;

            // Welcome label
            welcomeLabel.Font = ThemeColors.NavFont;
            welcomeLabel.ForeColor = ThemeColors.TextDark;
            welcomeLabel.Text = "Merhaba, " + Form1.Instance.loginUserName;

            // Brand label
            lblAppName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAppName.ForeColor = ThemeColors.TextWhite;

            // Close/Minimize
            lblClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClose.ForeColor = ThemeColors.TextLight;

            lblMinimize.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMinimize.ForeColor = ThemeColors.TextLight;

            // Nav buttons
            StyleNavButton(dashButton, "  Kontrol Paneli");
            StyleNavButton(addEmpButton, "  Çalışan Yönetimi");
            StyleNavButton(salaryButton, "  Maaş Yönetimi");

            // Logout
            ThemeColors.StyleButton(logoutButton, ThemeColors.Danger);
            logoutButton.Text = "Çıkış Yap";
        }

        private void StyleNavButton(Button btn, string text)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ThemeColors.PrimaryDark;
            btn.ForeColor = Color.FromArgb(180, 180, 180);
            btn.Font = ThemeColors.NavFont;
            btn.Text = text;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = ThemeColors.SidebarActive;
        }

        private void SetActiveButton(Button btn)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = ThemeColors.PrimaryDark;
                activeButton.ForeColor = Color.FromArgb(180, 180, 180);
                activeButton.Font = ThemeColors.NavFont;
            }
            activeButton = btn;
            btn.BackColor = ThemeColors.SidebarActive;
            btn.ForeColor = ThemeColors.TextWhite;
            btn.Font = ThemeColors.NavFontBold;
        }

        private void ShowDashboard()
        {
            controlDash1.Visible = true;
            controllAdd1.Visible = false;
            controlSalary1.Visible = false;
            SetActiveButton(dashButton);
            controlDash1.RefreshData();
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            controlDash1.Visible = false;
            controllAdd1.Visible = true;
            controlSalary1.Visible = false;
            SetActiveButton(addEmpButton);
            controllAdd1.RefreshData();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            controlDash1.Visible = false;
            controllAdd1.Visible = false;
            controlSalary1.Visible = true;
            SetActiveButton(salaryButton);
            controlSalary1.RefreshData();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1.Instance.Show();
                this.Close();
            }
        }

        // Form dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
