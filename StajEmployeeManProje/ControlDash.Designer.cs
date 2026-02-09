namespace StajEmployeeManProje
{
    partial class ControlDash
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
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelTotalCard = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.panelActiveCard = new System.Windows.Forms.Panel();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.panelInactiveCard = new System.Windows.Forms.Panel();
            this.lblInactiveCount = new System.Windows.Forms.Label();
            this.lblInactiveTitle = new System.Windows.Forms.Label();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.panelRecentGrid = new System.Windows.Forms.Panel();
            this.recentGrid = new System.Windows.Forms.DataGridView();
            this.panelCards.SuspendLayout();
            this.panelTotalCard.SuspendLayout();
            this.panelActiveCard.SuspendLayout();
            this.panelInactiveCard.SuspendLayout();
            this.panelRecentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentGrid)).BeginInit();
            this.SuspendLayout();
            //
            // lblPageTitle
            //
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPageTitle.Location = new System.Drawing.Point(30, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(140, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Kontrol Paneli";
            //
            // panelCards
            //
            this.panelCards.Controls.Add(this.panelTotalCard);
            this.panelCards.Controls.Add(this.panelActiveCard);
            this.panelCards.Controls.Add(this.panelInactiveCard);
            this.panelCards.Location = new System.Drawing.Point(30, 60);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(900, 140);
            this.panelCards.TabIndex = 1;
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            //
            // panelTotalCard
            //
            this.panelTotalCard.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.panelTotalCard.Controls.Add(this.lblTotalCount);
            this.panelTotalCard.Controls.Add(this.lblTotalTitle);
            this.panelTotalCard.Location = new System.Drawing.Point(0, 0);
            this.panelTotalCard.Name = "panelTotalCard";
            this.panelTotalCard.Size = new System.Drawing.Size(280, 130);
            this.panelTotalCard.TabIndex = 0;
            //
            // lblTotalCount
            //
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(20, 15);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(42, 51);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "0";
            //
            // lblTotalTitle
            //
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblTotalTitle.Location = new System.Drawing.Point(20, 90);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(120, 20);
            this.lblTotalTitle.TabIndex = 1;
            this.lblTotalTitle.Text = "Toplam Personel";
            //
            // panelActiveCard
            //
            this.panelActiveCard.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.panelActiveCard.Controls.Add(this.lblActiveCount);
            this.panelActiveCard.Controls.Add(this.lblActiveTitle);
            this.panelActiveCard.Location = new System.Drawing.Point(305, 0);
            this.panelActiveCard.Name = "panelActiveCard";
            this.panelActiveCard.Size = new System.Drawing.Size(280, 130);
            this.panelActiveCard.TabIndex = 1;
            //
            // lblActiveCount
            //
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActiveCount.ForeColor = System.Drawing.Color.White;
            this.lblActiveCount.Location = new System.Drawing.Point(20, 15);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(42, 51);
            this.lblActiveCount.TabIndex = 0;
            this.lblActiveCount.Text = "0";
            //
            // lblActiveTitle
            //
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblActiveTitle.Location = new System.Drawing.Point(20, 90);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(106, 20);
            this.lblActiveTitle.TabIndex = 1;
            this.lblActiveTitle.Text = "Aktif Personel";
            //
            // panelInactiveCard
            //
            this.panelInactiveCard.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.panelInactiveCard.Controls.Add(this.lblInactiveCount);
            this.panelInactiveCard.Controls.Add(this.lblInactiveTitle);
            this.panelInactiveCard.Location = new System.Drawing.Point(610, 0);
            this.panelInactiveCard.Name = "panelInactiveCard";
            this.panelInactiveCard.Size = new System.Drawing.Size(280, 130);
            this.panelInactiveCard.TabIndex = 2;
            //
            // lblInactiveCount
            //
            this.lblInactiveCount.AutoSize = true;
            this.lblInactiveCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInactiveCount.ForeColor = System.Drawing.Color.White;
            this.lblInactiveCount.Location = new System.Drawing.Point(20, 15);
            this.lblInactiveCount.Name = "lblInactiveCount";
            this.lblInactiveCount.Size = new System.Drawing.Size(42, 51);
            this.lblInactiveCount.TabIndex = 0;
            this.lblInactiveCount.Text = "0";
            //
            // lblInactiveTitle
            //
            this.lblInactiveTitle.AutoSize = true;
            this.lblInactiveTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInactiveTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblInactiveTitle.Location = new System.Drawing.Point(20, 90);
            this.lblInactiveTitle.Name = "lblInactiveTitle";
            this.lblInactiveTitle.Size = new System.Drawing.Size(115, 20);
            this.lblInactiveTitle.TabIndex = 1;
            this.lblInactiveTitle.Text = "Pasif Personel";
            //
            // lblRecentTitle
            //
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblRecentTitle.Location = new System.Drawing.Point(30, 220);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(225, 25);
            this.lblRecentTitle.TabIndex = 2;
            this.lblRecentTitle.Text = "Son Eklenen Personeller";
            //
            // panelRecentGrid
            //
            this.panelRecentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentGrid.BackColor = System.Drawing.Color.White;
            this.panelRecentGrid.Controls.Add(this.recentGrid);
            this.panelRecentGrid.Location = new System.Drawing.Point(30, 255);
            this.panelRecentGrid.Name = "panelRecentGrid";
            this.panelRecentGrid.Padding = new System.Windows.Forms.Padding(5);
            this.panelRecentGrid.Size = new System.Drawing.Size(900, 370);
            this.panelRecentGrid.TabIndex = 3;
            //
            // recentGrid
            //
            this.recentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentGrid.Location = new System.Drawing.Point(5, 5);
            this.recentGrid.Name = "recentGrid";
            this.recentGrid.Size = new System.Drawing.Size(890, 360);
            this.recentGrid.TabIndex = 0;
            this.recentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //
            // ControlDash
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.lblRecentTitle);
            this.Controls.Add(this.panelRecentGrid);
            this.Name = "ControlDash";
            this.Size = new System.Drawing.Size(970, 650);
            this.panelCards.ResumeLayout(false);
            this.panelTotalCard.ResumeLayout(false);
            this.panelTotalCard.PerformLayout();
            this.panelActiveCard.ResumeLayout(false);
            this.panelActiveCard.PerformLayout();
            this.panelInactiveCard.ResumeLayout(false);
            this.panelInactiveCard.PerformLayout();
            this.panelRecentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelTotalCard;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel panelActiveCard;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Panel panelInactiveCard;
        private System.Windows.Forms.Label lblInactiveCount;
        private System.Windows.Forms.Label lblInactiveTitle;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.Panel panelRecentGrid;
        private System.Windows.Forms.DataGridView recentGrid;
    }
}
