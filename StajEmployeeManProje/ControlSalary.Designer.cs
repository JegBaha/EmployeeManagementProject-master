namespace StajEmployeeManProje
{
    partial class ControlSalary
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.salaryGrid = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.updateSalaryButton = new System.Windows.Forms.Button();
            this.clearSalaryButton = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            //
            // lblPageTitle
            //
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPageTitle.Location = new System.Drawing.Point(30, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(150, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Maaş Yönetimi";
            //
            // panelGrid
            //
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.salaryGrid);
            this.panelGrid.Location = new System.Drawing.Point(30, 50);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(5);
            this.panelGrid.Size = new System.Drawing.Size(900, 330);
            this.panelGrid.TabIndex = 1;
            //
            // salaryGrid
            //
            this.salaryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGrid.Location = new System.Drawing.Point(5, 5);
            this.salaryGrid.Name = "salaryGrid";
            this.salaryGrid.Size = new System.Drawing.Size(890, 320);
            this.salaryGrid.TabIndex = 0;
            this.salaryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryGrid_CellClick);
            //
            // panelForm
            //
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.lblEmpId);
            this.panelForm.Controls.Add(this.txtEmpId);
            this.panelForm.Controls.Add(this.lblFullName);
            this.panelForm.Controls.Add(this.txtFullName);
            this.panelForm.Controls.Add(this.lblDepartment);
            this.panelForm.Controls.Add(this.txtDepartment);
            this.panelForm.Controls.Add(this.lblSalary);
            this.panelForm.Controls.Add(this.txtSalary);
            this.panelForm.Controls.Add(this.updateSalaryButton);
            this.panelForm.Controls.Add(this.clearSalaryButton);
            this.panelForm.Location = new System.Drawing.Point(30, 400);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(900, 220);
            this.panelForm.TabIndex = 2;
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(160, 21);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Maaş Güncelleme";
            //
            // lblEmpId
            //
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmpId.Location = new System.Drawing.Point(20, 55);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(72, 15);
            this.lblEmpId.TabIndex = 1;
            this.lblEmpId.Text = "Personel No";
            //
            // txtEmpId
            //
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmpId.Location = new System.Drawing.Point(20, 75);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(180, 25);
            this.txtEmpId.TabIndex = 2;
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(220, 55);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Ad Soyad";
            //
            // txtFullName
            //
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(220, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(200, 25);
            this.txtFullName.TabIndex = 4;
            //
            // lblDepartment
            //
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.Location = new System.Drawing.Point(440, 55);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(68, 15);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Departman";
            //
            // txtDepartment
            //
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartment.Location = new System.Drawing.Point(440, 75);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(200, 25);
            this.txtDepartment.TabIndex = 6;
            //
            // lblSalary
            //
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalary.Location = new System.Drawing.Point(660, 55);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(64, 15);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Maaş (TL)";
            //
            // txtSalary
            //
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalary.Location = new System.Drawing.Point(660, 75);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 25);
            this.txtSalary.TabIndex = 8;
            //
            // updateSalaryButton
            //
            this.updateSalaryButton.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.updateSalaryButton.FlatAppearance.BorderSize = 0;
            this.updateSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSalaryButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.updateSalaryButton.ForeColor = System.Drawing.Color.White;
            this.updateSalaryButton.Location = new System.Drawing.Point(20, 130);
            this.updateSalaryButton.Name = "updateSalaryButton";
            this.updateSalaryButton.Size = new System.Drawing.Size(180, 40);
            this.updateSalaryButton.TabIndex = 9;
            this.updateSalaryButton.Text = "Maaşı Güncelle";
            this.updateSalaryButton.UseVisualStyleBackColor = false;
            this.updateSalaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSalaryButton.Click += new System.EventHandler(this.updateSalaryButton_Click);
            //
            // clearSalaryButton
            //
            this.clearSalaryButton.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.clearSalaryButton.FlatAppearance.BorderSize = 0;
            this.clearSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSalaryButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearSalaryButton.ForeColor = System.Drawing.Color.White;
            this.clearSalaryButton.Location = new System.Drawing.Point(220, 130);
            this.clearSalaryButton.Name = "clearSalaryButton";
            this.clearSalaryButton.Size = new System.Drawing.Size(130, 40);
            this.clearSalaryButton.TabIndex = 10;
            this.clearSalaryButton.Text = "Temizle";
            this.clearSalaryButton.UseVisualStyleBackColor = false;
            this.clearSalaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSalaryButton.Click += new System.EventHandler(this.clearSalaryButton_Click);
            //
            // ControlSalary
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Name = "ControlSalary";
            this.Size = new System.Drawing.Size(970, 650);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView salaryGrid;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button updateSalaryButton;
        private System.Windows.Forms.Button clearSalaryButton;
    }
}
