namespace StajEmployeeManProje
{
    partial class ControllAdd
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.addDataGrid = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departmanText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDataGrid)).BeginInit();
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
            this.lblPageTitle.Size = new System.Drawing.Size(170, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Çalışan Yönetimi";
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSearch.Location = new System.Drawing.Point(630, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(40, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara:";
            //
            // searchTextBox
            //
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(680, 15);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 25);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            //
            // panelGrid
            //
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.addDataGrid);
            this.panelGrid.Location = new System.Drawing.Point(30, 50);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(5);
            this.panelGrid.Size = new System.Drawing.Size(900, 260);
            this.panelGrid.TabIndex = 3;
            //
            // addDataGrid
            //
            this.addDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDataGrid.Location = new System.Drawing.Point(5, 5);
            this.addDataGrid.Name = "addDataGrid";
            this.addDataGrid.Size = new System.Drawing.Size(890, 250);
            this.addDataGrid.TabIndex = 0;
            this.addDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addDataGrid_CellClick);
            //
            // panelForm
            //
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.idText);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.nameText);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.genderCombo);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.emailText);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.departmanText);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.salaryText);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.statusCombo);
            this.panelForm.Controls.Add(this.addButton);
            this.panelForm.Controls.Add(this.updateButton);
            this.panelForm.Controls.Add(this.deleteButton);
            this.panelForm.Controls.Add(this.clearButton);
            this.panelForm.Location = new System.Drawing.Point(30, 325);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(900, 300);
            this.panelForm.TabIndex = 4;
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(130, 21);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Çalışan Bilgileri";
            //
            // label1 - Personel No
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No";
            //
            // idText
            //
            this.idText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idText.Location = new System.Drawing.Point(20, 75);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(180, 25);
            this.idText.TabIndex = 2;
            //
            // label2 - Ad Soyad
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(220, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad";
            //
            // nameText
            //
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameText.Location = new System.Drawing.Point(220, 75);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(200, 25);
            this.nameText.TabIndex = 4;
            //
            // label3 - Cinsiyet
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(440, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cinsiyet";
            //
            // genderCombo
            //
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderCombo.Location = new System.Drawing.Point(440, 75);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(150, 25);
            this.genderCombo.TabIndex = 6;
            //
            // label4 - E-posta
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-posta";
            //
            // emailText
            //
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailText.Location = new System.Drawing.Point(20, 140);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(250, 25);
            this.emailText.TabIndex = 8;
            //
            // label5 - Departman
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(290, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departman";
            //
            // departmanText
            //
            this.departmanText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmanText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departmanText.Location = new System.Drawing.Point(290, 140);
            this.departmanText.Name = "departmanText";
            this.departmanText.Size = new System.Drawing.Size(200, 25);
            this.departmanText.TabIndex = 10;
            //
            // label6 - Maaş
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(510, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maaş";
            //
            // salaryText
            //
            this.salaryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.salaryText.Location = new System.Drawing.Point(510, 140);
            this.salaryText.Name = "salaryText";
            this.salaryText.ReadOnly = true;
            this.salaryText.Size = new System.Drawing.Size(150, 25);
            this.salaryText.TabIndex = 12;
            //
            // label7 - Durum
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(610, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Durum";
            //
            // statusCombo
            //
            this.statusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusCombo.Location = new System.Drawing.Point(610, 75);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(150, 25);
            this.statusCombo.TabIndex = 14;
            //
            // addButton
            //
            this.addButton.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(20, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 38);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            //
            // updateButton
            //
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(170, 200);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 38);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            //
            // deleteButton
            //
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(320, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 38);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            //
            // clearButton
            //
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(470, 200);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 38);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            //
            // ControllAdd
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Name = "ControllAdd";
            this.Size = new System.Drawing.Size(970, 650);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addDataGrid)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView addDataGrid;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox departmanText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}
