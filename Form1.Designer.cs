namespace PCDownlink
{
    partial class ItemsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            pictureBox11 = new PictureBox();
            groupBoxInfo = new GroupBox();
            lblCountDown = new Label();
            lblCurrentTimeText = new Label();
            lblLastrefresh = new Label();
            resultLabel = new Label();
            lblcurrenttime = new Label();
            lbllastwritetime = new Label();
            btnRefresh = new Button();
            btnDownload = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ContinentalUS = new RadioButton();
            TropicalAtlantic = new RadioButton();
            TropicalPacific = new RadioButton();
            USWestCoast = new RadioButton();
            NorthernSouthAmerica = new RadioButton();
            SouthernSouthAmerica = new RadioButton();
            Himawari8FullDisk = new RadioButton();
            NorthernPacific = new RadioButton();
            GOESEastFullDisk = new RadioButton();
            GOESWestFullDisk = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            myTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            groupBoxInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImageLayout = ImageLayout.None;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.InitialImage = (Image)resources.GetObject("pictureBox11.InitialImage");
            pictureBox11.Location = new Point(12, 12);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1613, 329);
            pictureBox11.TabIndex = 12;
            pictureBox11.TabStop = false;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.BackColor = Color.Transparent;
            groupBoxInfo.Controls.Add(lblCountDown);
            groupBoxInfo.Controls.Add(lblCurrentTimeText);
            groupBoxInfo.Controls.Add(lblLastrefresh);
            groupBoxInfo.Controls.Add(resultLabel);
            groupBoxInfo.Controls.Add(lblcurrenttime);
            groupBoxInfo.Controls.Add(lbllastwritetime);
            groupBoxInfo.FlatStyle = FlatStyle.Popup;
            groupBoxInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxInfo.ForeColor = Color.Firebrick;
            groupBoxInfo.Location = new Point(12, 357);
            groupBoxInfo.Margin = new Padding(4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(4);
            groupBoxInfo.Size = new Size(756, 269);
            groupBoxInfo.TabIndex = 11;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "INFO";
            // 
            // lblCountDown
            // 
            lblCountDown.AutoSize = true;
            lblCountDown.Location = new Point(20, 214);
            lblCountDown.Margin = new Padding(4, 0, 4, 0);
            lblCountDown.Name = "lblCountDown";
            lblCountDown.Size = new Size(147, 32);
            lblCountDown.TabIndex = 11;
            lblCountDown.Text = "00:00:00.00";
            // 
            // lblCurrentTimeText
            // 
            lblCurrentTimeText.AutoSize = true;
            lblCurrentTimeText.Location = new Point(20, 41);
            lblCurrentTimeText.Margin = new Padding(4, 0, 4, 0);
            lblCurrentTimeText.Name = "lblCurrentTimeText";
            lblCurrentTimeText.Size = new Size(70, 32);
            lblCurrentTimeText.TabIndex = 9;
            lblCurrentTimeText.Text = "Time";
            // 
            // lblLastrefresh
            // 
            lblLastrefresh.AutoSize = true;
            lblLastrefresh.Location = new Point(320, 35);
            lblLastrefresh.Margin = new Padding(4, 0, 4, 0);
            lblLastrefresh.Name = "lblLastrefresh";
            lblLastrefresh.Size = new Size(146, 32);
            lblLastrefresh.TabIndex = 10;
            lblLastrefresh.Text = "Last refresh";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(20, 157);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(83, 32);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "label1";
            // 
            // lblcurrenttime
            // 
            lblcurrenttime.AutoSize = true;
            lblcurrenttime.Location = new Point(20, 87);
            lblcurrenttime.Margin = new Padding(4, 0, 4, 0);
            lblcurrenttime.Name = "lblcurrenttime";
            lblcurrenttime.Size = new Size(83, 32);
            lblcurrenttime.TabIndex = 3;
            lblcurrenttime.Text = "label1";
            // 
            // lbllastwritetime
            // 
            lbllastwritetime.AutoSize = true;
            lbllastwritetime.Location = new Point(320, 87);
            lbllastwritetime.Margin = new Padding(4, 0, 4, 0);
            lbllastwritetime.Name = "lbllastwritetime";
            lbllastwritetime.Size = new Size(83, 32);
            lbllastwritetime.TabIndex = 2;
            lbllastwritetime.Text = "label1";
            // 
            // btnRefresh
            // 
            btnRefresh.ForeColor = Color.Firebrick;
            btnRefresh.Location = new Point(248, 674);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(157, 44);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDownload
            // 
            btnDownload.ForeColor = Color.Firebrick;
            btnDownload.Location = new Point(32, 674);
            btnDownload.Margin = new Padding(4);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(157, 44);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ContinentalUS, 0, 1);
            tableLayoutPanel1.Controls.Add(TropicalAtlantic, 0, 2);
            tableLayoutPanel1.Controls.Add(TropicalPacific, 0, 3);
            tableLayoutPanel1.Controls.Add(USWestCoast, 0, 4);
            tableLayoutPanel1.Controls.Add(NorthernSouthAmerica, 0, 5);
            tableLayoutPanel1.Controls.Add(SouthernSouthAmerica, 0, 6);
            tableLayoutPanel1.Controls.Add(Himawari8FullDisk, 0, 7);
            tableLayoutPanel1.Controls.Add(NorthernPacific, 0, 8);
            tableLayoutPanel1.Controls.Add(GOESEastFullDisk, 0, 9);
            tableLayoutPanel1.Controls.Add(GOESWestFullDisk, 0, 10);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(pictureBox4, 1, 4);
            tableLayoutPanel1.Controls.Add(pictureBox5, 1, 5);
            tableLayoutPanel1.Controls.Add(pictureBox6, 1, 6);
            tableLayoutPanel1.Controls.Add(pictureBox7, 1, 7);
            tableLayoutPanel1.Controls.Add(pictureBox8, 1, 8);
            tableLayoutPanel1.Controls.Add(pictureBox9, 1, 9);
            tableLayoutPanel1.Controls.Add(pictureBox10, 1, 10);
            tableLayoutPanel1.Location = new Point(869, 357);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(757, 1473);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ContinentalUS
            // 
            ContinentalUS.AutoSize = true;
            ContinentalUS.Checked = true;
            ContinentalUS.Dock = DockStyle.Right;
            ContinentalUS.Location = new Point(114, 4);
            ContinentalUS.Margin = new Padding(4);
            ContinentalUS.Name = "ContinentalUS";
            ContinentalUS.Size = new Size(209, 215);
            ContinentalUS.TabIndex = 0;
            ContinentalUS.TabStop = true;
            ContinentalUS.Text = "Continental US";
            ContinentalUS.UseVisualStyleBackColor = true;
            ContinentalUS.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // TropicalAtlantic
            // 
            TropicalAtlantic.AutoSize = true;
            TropicalAtlantic.Dock = DockStyle.Right;
            TropicalAtlantic.Location = new Point(97, 227);
            TropicalAtlantic.Margin = new Padding(4);
            TropicalAtlantic.Name = "TropicalAtlantic";
            TropicalAtlantic.Size = new Size(226, 193);
            TropicalAtlantic.TabIndex = 1;
            TropicalAtlantic.TabStop = true;
            TropicalAtlantic.Text = "Tropical Atlantic";
            TropicalAtlantic.UseVisualStyleBackColor = true;
            TropicalAtlantic.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // TropicalPacific
            // 
            TropicalPacific.AutoSize = true;
            TropicalPacific.Dock = DockStyle.Right;
            TropicalPacific.Location = new Point(112, 428);
            TropicalPacific.Margin = new Padding(4);
            TropicalPacific.Name = "TropicalPacific";
            TropicalPacific.Size = new Size(211, 188);
            TropicalPacific.TabIndex = 2;
            TropicalPacific.TabStop = true;
            TropicalPacific.Text = "Tropical Pacific";
            TropicalPacific.UseVisualStyleBackColor = true;
            TropicalPacific.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // USWestCoast
            // 
            USWestCoast.AutoSize = true;
            USWestCoast.Dock = DockStyle.Right;
            USWestCoast.Location = new Point(121, 624);
            USWestCoast.Margin = new Padding(4);
            USWestCoast.Name = "USWestCoast";
            USWestCoast.Size = new Size(202, 200);
            USWestCoast.TabIndex = 3;
            USWestCoast.TabStop = true;
            USWestCoast.Text = "US West Coast";
            USWestCoast.UseVisualStyleBackColor = true;
            USWestCoast.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // NorthernSouthAmerica
            // 
            NorthernSouthAmerica.AutoSize = true;
            NorthernSouthAmerica.Dock = DockStyle.Right;
            NorthernSouthAmerica.Location = new Point(4, 832);
            NorthernSouthAmerica.Margin = new Padding(4);
            NorthernSouthAmerica.Name = "NorthernSouthAmerica";
            NorthernSouthAmerica.Size = new Size(319, 173);
            NorthernSouthAmerica.TabIndex = 4;
            NorthernSouthAmerica.TabStop = true;
            NorthernSouthAmerica.Text = "Northern South America";
            NorthernSouthAmerica.UseVisualStyleBackColor = true;
            NorthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // SouthernSouthAmerica
            // 
            SouthernSouthAmerica.AutoSize = true;
            SouthernSouthAmerica.Dock = DockStyle.Right;
            SouthernSouthAmerica.Location = new Point(6, 1013);
            SouthernSouthAmerica.Margin = new Padding(4);
            SouthernSouthAmerica.Name = "SouthernSouthAmerica";
            SouthernSouthAmerica.Size = new Size(317, 177);
            SouthernSouthAmerica.TabIndex = 5;
            SouthernSouthAmerica.TabStop = true;
            SouthernSouthAmerica.Text = "Southern South America";
            SouthernSouthAmerica.UseVisualStyleBackColor = true;
            SouthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // Himawari8FullDisk
            // 
            Himawari8FullDisk.AutoSize = true;
            Himawari8FullDisk.Dock = DockStyle.Right;
            Himawari8FullDisk.Location = new Point(64, 1198);
            Himawari8FullDisk.Margin = new Padding(4);
            Himawari8FullDisk.Name = "Himawari8FullDisk";
            Himawari8FullDisk.Size = new Size(259, 225);
            Himawari8FullDisk.TabIndex = 6;
            Himawari8FullDisk.TabStop = true;
            Himawari8FullDisk.Text = "Himawari8 FullDisk";
            Himawari8FullDisk.UseVisualStyleBackColor = true;
            Himawari8FullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // NorthernPacific
            // 
            NorthernPacific.AutoSize = true;
            NorthernPacific.Dock = DockStyle.Fill;
            NorthernPacific.Location = new Point(4, 1431);
            NorthernPacific.Margin = new Padding(4);
            NorthernPacific.Name = "NorthernPacific";
            NorthernPacific.Size = new Size(319, 169);
            NorthernPacific.TabIndex = 7;
            NorthernPacific.TabStop = true;
            NorthernPacific.Text = "Northern Pacific";
            NorthernPacific.UseVisualStyleBackColor = true;
            NorthernPacific.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // GOESEastFullDisk
            // 
            GOESEastFullDisk.AutoSize = true;
            GOESEastFullDisk.Dock = DockStyle.Fill;
            GOESEastFullDisk.Location = new Point(4, 1608);
            GOESEastFullDisk.Margin = new Padding(4);
            GOESEastFullDisk.Name = "GOESEastFullDisk";
            GOESEastFullDisk.Size = new Size(319, 247);
            GOESEastFullDisk.TabIndex = 8;
            GOESEastFullDisk.TabStop = true;
            GOESEastFullDisk.Text = "GOES-East FullDisk";
            GOESEastFullDisk.UseVisualStyleBackColor = true;
            GOESEastFullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // GOESWestFullDisk
            // 
            GOESWestFullDisk.AutoSize = true;
            GOESWestFullDisk.Dock = DockStyle.Fill;
            GOESWestFullDisk.Location = new Point(4, 1863);
            GOESWestFullDisk.Margin = new Padding(4);
            GOESWestFullDisk.Name = "GOESWestFullDisk";
            GOESWestFullDisk.Size = new Size(319, 232);
            GOESWestFullDisk.TabIndex = 9;
            GOESWestFullDisk.TabStop = true;
            GOESWestFullDisk.Text = "GOES-West FullDisk";
            GOESWestFullDisk.UseVisualStyleBackColor = true;
            GOESWestFullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox1.Location = new Point(331, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/thumbnail.jpg";
            pictureBox2.Location = new Point(331, 227);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 193);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/tpw/GEOCOLOR/thumbnail.jpg";
            pictureBox3.Location = new Point(331, 428);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(340, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox4.Location = new Point(331, 624);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(340, 200);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/nsa/GEOCOLOR/thumbnail.jpg";
            pictureBox5.Location = new Point(331, 832);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(326, 173);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/thumbnail.jpg";
            pictureBox6.Location = new Point(331, 1013);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(326, 177);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.ImageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/thumb/himawari-8/full_disk_ahi_true_color.jpg";
            pictureBox7.Location = new Point(331, 1198);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(244, 225);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/np/GEOCOLOR/thumbnail.jpg";
            pictureBox8.Location = new Point(331, 1431);
            pictureBox8.Margin = new Padding(4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(313, 169);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox9.Location = new Point(331, 1608);
            pictureBox9.Margin = new Padding(4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(271, 247);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox10.Location = new Point(331, 1863);
            pictureBox10.Margin = new Padding(4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(262, 232);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 19;
            pictureBox10.TabStop = false;
            // 
            // myTimer
            // 
            myTimer.Interval = 300000;
            myTimer.Tick += ItemsForm_Load;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "PC Downlink";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.th;
            ClientSize = new Size(1639, 1118);
            Controls.Add(groupBoxInfo);
            Controls.Add(pictureBox11);
            Controls.Add(btnRefresh);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnDownload);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ItemsForm";
            Text = "Downlink for the PC";
            Load += ItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Button btnRefresh;
        private Button btnDownload;
        private Label lbllastwritetime;
        private Label lblcurrenttime;
        private ProgressBar progressBar1;
        private Label resultLabel;
        private System.Windows.Forms.Timer myTimer;
        private GroupBox groupBoxInfo;
        private Label lblCurrentTimeText;
        private Label lblLastrefresh;
        public RadioButton ContinentalUS;
        public RadioButton TropicalAtlantic;
        public RadioButton TropicalPacific;
        public RadioButton USWestCoast;
        public RadioButton NorthernSouthAmerica;
        public RadioButton SouthernSouthAmerica;
        public RadioButton Himawari8FullDisk;
        public RadioButton NorthernPacific;
        public RadioButton GOESEastFullDisk;
        public RadioButton GOESWestFullDisk;
        private Label lblCountDown;
        private PictureBox pictureBox11;
        private NotifyIcon notifyIcon1;
    }
}