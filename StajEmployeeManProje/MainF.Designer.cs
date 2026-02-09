namespace StajEmployeeManProje
{
    partial class MainF
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.dashButton = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.controlDash1 = new StajEmployeeManProje.ControlDash();
            this.controllAdd1 = new StajEmployeeManProje.ControllAdd();
            this.controlSalary1 = new StajEmployeeManProje.ControlSalary();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader - Top header bar
            //
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblMinimize);
            this.panelHeader.Controls.Add(this.lblClose);
            this.panelHeader.Controls.Add(this.welcomeLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(230, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(970, 50);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            //
            // lblMinimize
            //
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblMinimize.Location = new System.Drawing.Point(905, 10);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 25);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            //
            // lblClose
            //
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblClose.Location = new System.Drawing.Point(935, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            //
            // welcomeLabel
            //
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.welcomeLabel.Location = new System.Drawing.Point(20, 14);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(120, 21);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Merhaba, Admin";
            //
            // panelSidebar - Left navigation
            //
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(27, 40, 56);
            this.panelSidebar.Controls.Add(this.logoutButton);
            this.panelSidebar.Controls.Add(this.salaryButton);
            this.panelSidebar.Controls.Add(this.addEmpButton);
            this.panelSidebar.Controls.Add(this.dashButton);
            this.panelSidebar.Controls.Add(this.lblAppName);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 700);
            this.panelSidebar.TabIndex = 1;
            //
            // lblAppName
            //
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(15, 20);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(200, 50);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "EMS Panel";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dashButton
            //
            this.dashButton.BackColor = System.Drawing.Color.FromArgb(27, 40, 56);
            this.dashButton.FlatAppearance.BorderSize = 0;
            this.dashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dashButton.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.dashButton.Location = new System.Drawing.Point(0, 100);
            this.dashButton.Name = "dashButton";
            this.dashButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashButton.Size = new System.Drawing.Size(230, 50);
            this.dashButton.TabIndex = 1;
            this.dashButton.Text = "  Kontrol Paneli";
            this.dashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashButton.UseVisualStyleBackColor = false;
            this.dashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashButton.Click += new System.EventHandler(this.dashButton_Click);
            //
            // addEmpButton
            //
            this.addEmpButton.BackColor = System.Drawing.Color.FromArgb(27, 40, 56);
            this.addEmpButton.FlatAppearance.BorderSize = 0;
            this.addEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addEmpButton.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.addEmpButton.Location = new System.Drawing.Point(0, 155);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addEmpButton.Size = new System.Drawing.Size(230, 50);
            this.addEmpButton.TabIndex = 2;
            this.addEmpButton.Text = "  Çalışan Yönetimi";
            this.addEmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmpButton.UseVisualStyleBackColor = false;
            this.addEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
            //
            // salaryButton
            //
            this.salaryButton.BackColor = System.Drawing.Color.FromArgb(27, 40, 56);
            this.salaryButton.FlatAppearance.BorderSize = 0;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salaryButton.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.salaryButton.Location = new System.Drawing.Point(0, 210);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.salaryButton.Size = new System.Drawing.Size(230, 50);
            this.salaryButton.TabIndex = 3;
            this.salaryButton.Text = "  Maaş Yönetimi";
            this.salaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            //
            // logoutButton
            //
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(15, 640);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 40);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Çıkış Yap";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            //
            // panelContent - Main content area
            //
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.panelContent.Controls.Add(this.controlDash1);
            this.panelContent.Controls.Add(this.controllAdd1);
            this.panelContent.Controls.Add(this.controlSalary1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(230, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(970, 650);
            this.panelContent.TabIndex = 2;
            //
            // controlDash1
            //
            this.controlDash1.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.controlDash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlDash1.Location = new System.Drawing.Point(0, 0);
            this.controlDash1.Name = "controlDash1";
            this.controlDash1.Size = new System.Drawing.Size(970, 650);
            this.controlDash1.TabIndex = 0;
            //
            // controllAdd1
            //
            this.controllAdd1.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.controllAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllAdd1.Location = new System.Drawing.Point(0, 0);
            this.controllAdd1.Name = "controllAdd1";
            this.controllAdd1.Size = new System.Drawing.Size(970, 650);
            this.controllAdd1.TabIndex = 1;
            //
            // controlSalary1
            //
            this.controlSalary1.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.controlSalary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSalary1.Location = new System.Drawing.Point(0, 0);
            this.controlSalary1.Name = "controlSalary1";
            this.controlSalary1.Size = new System.Drawing.Size(970, 650);
            this.controlSalary1.TabIndex = 2;
            //
            // MainF
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button addEmpButton;
        private System.Windows.Forms.Button dashButton;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelContent;
        private ControlDash controlDash1;
        private ControllAdd controllAdd1;
        private ControlSalary controlSalary1;
    }
}
