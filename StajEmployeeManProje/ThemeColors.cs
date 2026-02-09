using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StajEmployeeManProje
{
    public static class ThemeColors
    {
        // Primary Colors
        public static Color PrimaryDark = Color.FromArgb(27, 40, 56);      // #1B2838 - Sidebar
        public static Color PrimaryBlue = Color.FromArgb(33, 150, 243);    // #2196F3 - Accent
        public static Color PrimaryLight = Color.FromArgb(66, 165, 245);   // #42A5F5 - Lighter accent

        // Action Colors
        public static Color Success = Color.FromArgb(76, 175, 80);         // #4CAF50 - Add/Active
        public static Color Warning = Color.FromArgb(255, 152, 0);         // #FF9800 - Update
        public static Color Danger = Color.FromArgb(244, 67, 54);          // #F44336 - Delete/Inactive

        // Background Colors
        public static Color Background = Color.FromArgb(245, 246, 250);    // #F5F6FA - Page bg
        public static Color CardBackground = Color.White;
        public static Color SidebarActive = Color.FromArgb(44, 62, 80);    // #2C3E50 - Active nav item

        // Text Colors
        public static Color TextDark = Color.FromArgb(44, 62, 80);         // #2C3E50
        public static Color TextLight = Color.FromArgb(149, 165, 166);     // #95A5A6
        public static Color TextWhite = Color.White;

        // Grid Colors
        public static Color GridHeader = Color.FromArgb(52, 73, 94);       // #34495E
        public static Color GridAlternateRow = Color.FromArgb(236, 240, 241); // #ECF0F1
        public static Color GridBorder = Color.FromArgb(189, 195, 199);    // #BDC3C7

        // Fonts
        public static Font HeaderFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static Font SubHeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static Font NavFont = new Font("Segoe UI", 12F, FontStyle.Regular);
        public static Font NavFontBold = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static Font LabelFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static Font LabelFontBold = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static Font CardNumberFont = new Font("Segoe UI", 28F, FontStyle.Bold);
        public static Font CardTitleFont = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static Font SmallFont = new Font("Segoe UI", 9F, FontStyle.Regular);

        public static void StyleDataGridView(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = CardBackground;
            grid.GridColor = GridBorder;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.EnableHeadersVisualStyles = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowTemplate.Height = 35;

            // Header style
            grid.ColumnHeadersDefaultCellStyle.BackColor = GridHeader;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextWhite;
            grid.ColumnHeadersDefaultCellStyle.Font = LabelFontBold;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Row style
            grid.DefaultCellStyle.BackColor = CardBackground;
            grid.DefaultCellStyle.ForeColor = TextDark;
            grid.DefaultCellStyle.Font = SmallFont;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            grid.DefaultCellStyle.SelectionForeColor = TextDark;
            grid.DefaultCellStyle.Padding = new Padding(5);

            // Alternating row
            grid.AlternatingRowsDefaultCellStyle.BackColor = GridAlternateRow;
        }

        public static void StyleButton(Button btn, Color bgColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bgColor;
            btn.ForeColor = TextWhite;
            btn.Font = ButtonFont;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(bgColor, 0.2f);
            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(bgColor, 0.1f);
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = LabelFont;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
        }

        public static void StyleComboBox(ComboBox cmb)
        {
            cmb.Font = LabelFont;
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.BackColor = Color.White;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
