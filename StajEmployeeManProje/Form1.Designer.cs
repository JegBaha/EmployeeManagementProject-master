namespace StajEmployeeManProje
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBrandDesc = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.usernTextBox = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1 - Left brand panel
            //
            this.panel1.BackColor = System.Drawing.Color.FromArgb(27, 40, 56);
            this.panel1.Controls.Add(this.lblBrandDesc);
            this.panel1.Controls.Add(this.lblBrandTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 500);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            //
            // lblBrandTitle
            //
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(30, 160);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(260, 60);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "Employee\r\nManagement System";
            this.lblBrandTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblBrandDesc
            //
            this.lblBrandDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBrandDesc.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblBrandDesc.Location = new System.Drawing.Point(30, 230);
            this.lblBrandDesc.Name = "lblBrandDesc";
            this.lblBrandDesc.Size = new System.Drawing.Size(260, 60);
            this.lblBrandDesc.TabIndex = 1;
            this.lblBrandDesc.Text = "Personel bilgilerini kolayca yönetin,\r\nmaaş takibi yapın ve departman\r\nbazlı raporlar oluşturun.";
            //
            // CloseButton
            //
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.CloseButton.Location = new System.Drawing.Point(860, 15);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location = new System.Drawing.Point(400, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hoş Geldiniz";
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblSubtitle.Location = new System.Drawing.Point(402, 140);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(260, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Devam etmek için giriş yapınız";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblUsername.Location = new System.Drawing.Point(400, 195);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Kullanıcı Adı";
            //
            // usernTextBox
            //
            this.usernTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usernTextBox.Location = new System.Drawing.Point(400, 220);
            this.usernTextBox.Name = "usernTextBox";
            this.usernTextBox.Size = new System.Drawing.Size(430, 27);
            this.usernTextBox.TabIndex = 4;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPassword.Location = new System.Drawing.Point(400, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Şifre";
            //
            // passTextBox
            //
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.passTextBox.Location = new System.Drawing.Point(400, 290);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(430, 27);
            this.passTextBox.TabIndex = 6;
            //
            // loginButton
            //
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(400, 350);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(205, 42);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            //
            // registerButton
            //
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(625, 350);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(205, 42);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Kayıt Ol";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.usernTextBox);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management - Giriş";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox usernTextBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandDesc;
    }
}
