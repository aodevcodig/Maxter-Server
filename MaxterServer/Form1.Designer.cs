namespace MaxterServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            spaceSeparatorVertical1 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            badge1 = new ReaLTaiizor.Controls.Badge();
            sbStatusBar = new ReaLTaiizor.Controls.ForeverStatusBar();
            tbAppLogs1 = new ReaLTaiizor.Controls.DungeonRichTextBox();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            tbAppLogs = new RichTextBox();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            metroPanel2 = new ReaLTaiizor.Controls.MetroPanel();
            foxCheckBoxEdit3 = new ReaLTaiizor.Controls.FoxCheckBoxEdit();
            foxCheckBoxEdit2 = new ReaLTaiizor.Controls.FoxCheckBoxEdit();
            cbApache = new ReaLTaiizor.Controls.FoxCheckBoxEdit();
            metroPanel1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            metroPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // spaceSeparatorVertical1
            // 
            spaceSeparatorVertical1.BackColor = SystemColors.ButtonHighlight;
            spaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            spaceSeparatorVertical1.Image = null;
            spaceSeparatorVertical1.Location = new Point(577, 71);
            spaceSeparatorVertical1.Name = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.NoRounding = false;
            spaceSeparatorVertical1.Size = new Size(4, 280);
            spaceSeparatorVertical1.TabIndex = 0;
            spaceSeparatorVertical1.Text = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.Transparent = false;
            // 
            // metroPanel1
            // 
            metroPanel1.BackgroundColor = Color.White;
            metroPanel1.BorderColor = Color.FromArgb(150, 150, 150);
            metroPanel1.BorderThickness = 0;
            metroPanel1.Controls.Add(foxLabel1);
            metroPanel1.Controls.Add(badge1);
            metroPanel1.Controls.Add(sbStatusBar);
            metroPanel1.Controls.Add(tbAppLogs1);
            metroPanel1.Controls.Add(foreverGroupBox1);
            metroPanel1.Controls.Add(dungeonHeaderLabel1);
            metroPanel1.Controls.Add(metroPanel2);
            metroPanel1.Controls.Add(spaceSeparatorVertical1);
            metroPanel1.Dock = DockStyle.Fill;
            metroPanel1.IsDerivedStyle = true;
            metroPanel1.Location = new Point(0, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(754, 411);
            metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 1;
            metroPanel1.ThemeAuthor = "Taiizor";
            metroPanel1.ThemeName = "MetroLight";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(50, 85);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(65, 19);
            foxLabel1.TabIndex = 8;
            foxLabel1.Text = "Apache";
            // 
            // badge1
            // 
            badge1.BGColorA = Color.FromArgb(197, 69, 68);
            badge1.BGColorB = Color.FromArgb(176, 52, 52);
            badge1.BorderColor = Color.FromArgb(205, 70, 66);
            badge1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            badge1.ForeColor = Color.FromArgb(255, 255, 253);
            badge1.Location = new Point(414, 96);
            badge1.Maximum = 9;
            badge1.Name = "badge1";
            badge1.Size = new Size(20, 20);
            badge1.TabIndex = 7;
            badge1.Text = "badge1";
            badge1.Value = 0;
            // 
            // sbStatusBar
            // 
            sbStatusBar.BaseColor = Color.FromArgb(45, 47, 49);
            sbStatusBar.Dock = DockStyle.Bottom;
            sbStatusBar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            sbStatusBar.ForeColor = Color.White;
            sbStatusBar.Location = new Point(0, 388);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.RectColor = Color.FromArgb(128, 255, 255);
            sbStatusBar.ShowTimeDate = false;
            sbStatusBar.Size = new Size(754, 23);
            sbStatusBar.TabIndex = 6;
            sbStatusBar.Text = "Status: Offline";
            sbStatusBar.TextColor = Color.White;
            sbStatusBar.TimeColor = Color.White;
            sbStatusBar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // tbAppLogs1
            // 
            tbAppLogs1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAppLogs1.AutoWordSelection = false;
            tbAppLogs1.BackColor = Color.Transparent;
            tbAppLogs1.BorderColor = Color.FromArgb(180, 180, 180);
            tbAppLogs1.EdgeColor = Color.White;
            tbAppLogs1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbAppLogs1.ForeColor = Color.FromArgb(76, 76, 76);
            tbAppLogs1.Location = new Point(27, 71);
            tbAppLogs1.Name = "tbAppLogs1";
            tbAppLogs1.ReadOnly = false;
            tbAppLogs1.Size = new Size(525, 62);
            tbAppLogs1.TabIndex = 4;
            tbAppLogs1.TextBackColor = Color.White;
            tbAppLogs1.WordWrap = true;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.Controls.Add(tbAppLogs);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            foreverGroupBox1.Location = new Point(12, 265);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(559, 123);
            foreverGroupBox1.TabIndex = 5;
            foreverGroupBox1.Text = "Registros da Aplicação";
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // tbAppLogs
            // 
            tbAppLogs.BorderStyle = BorderStyle.None;
            tbAppLogs.Location = new Point(18, 41);
            tbAppLogs.Name = "tbAppLogs";
            tbAppLogs.ReadOnly = true;
            tbAppLogs.Size = new Size(522, 58);
            tbAppLogs.TabIndex = 6;
            tbAppLogs.Text = "";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(587, 45);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(155, 23);
            dungeonHeaderLabel1.TabIndex = 3;
            dungeonHeaderLabel1.Text = "Serviços";
            dungeonHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // metroPanel2
            // 
            metroPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            metroPanel2.BackgroundColor = Color.White;
            metroPanel2.BorderColor = Color.Transparent;
            metroPanel2.BorderThickness = 0;
            metroPanel2.Controls.Add(foxCheckBoxEdit3);
            metroPanel2.Controls.Add(foxCheckBoxEdit2);
            metroPanel2.Controls.Add(cbApache);
            metroPanel2.IsDerivedStyle = false;
            metroPanel2.Location = new Point(587, 71);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(155, 317);
            metroPanel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 2;
            metroPanel2.ThemeAuthor = "Taiizor";
            metroPanel2.ThemeName = "MetroLight";
            // 
            // foxCheckBoxEdit3
            // 
            foxCheckBoxEdit3.BackColor = Color.Transparent;
            foxCheckBoxEdit3.BorderColor = Color.FromArgb(200, 200, 200);
            foxCheckBoxEdit3.Checked = false;
            foxCheckBoxEdit3.DisabledBorderColor = Color.FromArgb(230, 230, 230);
            foxCheckBoxEdit3.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxCheckBoxEdit3.EnabledCalc = true;
            foxCheckBoxEdit3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            foxCheckBoxEdit3.ForeColor = Color.FromArgb(66, 78, 90);
            foxCheckBoxEdit3.HoverBorderColor = Color.FromArgb(44, 156, 218);
            foxCheckBoxEdit3.Location = new Point(3, 91);
            foxCheckBoxEdit3.Name = "foxCheckBoxEdit3";
            foxCheckBoxEdit3.Size = new Size(138, 21);
            foxCheckBoxEdit3.TabIndex = 7;
            foxCheckBoxEdit3.Text = "MySQL";
            // 
            // foxCheckBoxEdit2
            // 
            foxCheckBoxEdit2.BackColor = Color.Transparent;
            foxCheckBoxEdit2.BorderColor = Color.FromArgb(200, 200, 200);
            foxCheckBoxEdit2.Checked = false;
            foxCheckBoxEdit2.DisabledBorderColor = Color.FromArgb(230, 230, 230);
            foxCheckBoxEdit2.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxCheckBoxEdit2.EnabledCalc = true;
            foxCheckBoxEdit2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            foxCheckBoxEdit2.ForeColor = Color.FromArgb(66, 78, 90);
            foxCheckBoxEdit2.HoverBorderColor = Color.FromArgb(44, 156, 218);
            foxCheckBoxEdit2.Location = new Point(3, 58);
            foxCheckBoxEdit2.Name = "foxCheckBoxEdit2";
            foxCheckBoxEdit2.Size = new Size(138, 21);
            foxCheckBoxEdit2.TabIndex = 6;
            foxCheckBoxEdit2.Text = "PHP";
            // 
            // cbApache
            // 
            cbApache.BackColor = Color.Transparent;
            cbApache.BorderColor = Color.FromArgb(200, 200, 200);
            cbApache.Checked = false;
            cbApache.DisabledBorderColor = Color.FromArgb(230, 230, 230);
            cbApache.DisabledTextColor = Color.FromArgb(166, 178, 190);
            cbApache.EnabledCalc = true;
            cbApache.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbApache.ForeColor = Color.FromArgb(66, 78, 90);
            cbApache.HoverBorderColor = Color.FromArgb(44, 156, 218);
            cbApache.Location = new Point(3, 25);
            cbApache.Name = "cbApache";
            cbApache.Size = new Size(138, 21);
            cbApache.TabIndex = 5;
            cbApache.Text = "Apache";
            cbApache.CheckedChanged += cbApache_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 411);
            Controls.Add(metroPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(770, 450);
            MinimumSize = new Size(770, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maxter Server";
            metroPanel1.ResumeLayout(false);
            foreverGroupBox1.ResumeLayout(false);
            metroPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.FoxCheckBoxEdit foxCheckBoxEdit3;
        private ReaLTaiizor.Controls.FoxCheckBoxEdit foxCheckBoxEdit2;
        private ReaLTaiizor.Controls.FoxCheckBoxEdit cbApache;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.DungeonRichTextBox tbAppLogs1;
        private RichTextBox tbAppLogs;
        private ReaLTaiizor.Controls.ForeverStatusBar sbStatusBar;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.Badge badge1;
    }
}
