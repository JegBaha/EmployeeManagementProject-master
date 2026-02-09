using System;
using System.Drawing;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public string loginUserName;
        private EmployeeDAL dal = new EmployeeDAL();

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            // Left panel styling
            panel1.BackColor = ThemeColors.PrimaryDark;

            // Form background
            this.BackColor = Color.White;

            // Title
            lblTitle.Font = ThemeColors.HeaderFont;
            lblTitle.ForeColor = ThemeColors.TextDark;

            // Subtitle
            lblSubtitle.Font = ThemeColors.LabelFont;
            lblSubtitle.ForeColor = ThemeColors.TextLight;

            // Labels
            lblUsername.Font = ThemeColors.LabelFontBold;
            lblUsername.ForeColor = ThemeColors.TextDark;
            lblPassword.Font = ThemeColors.LabelFontBold;
            lblPassword.ForeColor = ThemeColors.TextDark;

            // Panel brand text
            lblBrandTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandTitle.ForeColor = ThemeColors.TextWhite;
            lblBrandDesc.Font = ThemeColors.LabelFont;
            lblBrandDesc.ForeColor = Color.FromArgb(200, 200, 200);

            // TextBoxes
            ThemeColors.StyleTextBox(usernTextBox);
            ThemeColors.StyleTextBox(passTextBox);

            // Buttons
            ThemeColors.StyleButton(loginButton, ThemeColors.PrimaryBlue);
            ThemeColors.StyleButton(registerButton, ThemeColors.Success);

            // Close button
            CloseButton.ForeColor = ThemeColors.TextLight;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernTextBox.Text) || string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demo mode: DB yoksa admin/admin123 ile giriş
            bool validated = false;
            try
            {
                validated = dal.ValidateUser(usernTextBox.Text.Trim(), passTextBox.Text.Trim());
            }
            catch
            {
                // DB bağlantısı yoksa demo mode
                if (usernTextBox.Text.Trim() == "admin" && passTextBox.Text.Trim() == "admin123")
                    validated = true;
            }

            if (validated)
            {
                loginUserName = usernTextBox.Text.Trim();
                MainF mainF = new MainF();
                mainF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernTextBox.Text) || string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dal.RegisterUser(usernTextBox.Text.Trim(), passTextBox.Text.Trim()))
                {
                    MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Enable form dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
