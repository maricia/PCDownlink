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
            splitContainer1 = new SplitContainer();
            groupBoxInfo = new GroupBox();
            lblCountDown = new Label();
            lblCurrentTimeText = new Label();
            lblLastrefresh = new Label();
            resultLabel = new Label();
            progressBar1 = new ProgressBar();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInfo);
            splitContainer1.Panel1.Controls.Add(btnRefresh);
            splitContainer1.Panel1.Controls.Add(btnDownload);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1138, 1345);
            splitContainer1.SplitterDistance = 497;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblCountDown);
            groupBoxInfo.Controls.Add(lblCurrentTimeText);
            groupBoxInfo.Controls.Add(lblLastrefresh);
            groupBoxInfo.Controls.Add(resultLabel);
            groupBoxInfo.Controls.Add(progressBar1);
            groupBoxInfo.Controls.Add(lblcurrenttime);
            groupBoxInfo.Controls.Add(lbllastwritetime);
            groupBoxInfo.Location = new Point(26, 192);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(457, 398);
            groupBoxInfo.TabIndex = 11;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Info";
            // 
            // lblCountDown
            // 
            lblCountDown.AutoSize = true;
            lblCountDown.Location = new Point(15, 167);
            lblCountDown.Name = "lblCountDown";
            lblCountDown.Size = new Size(104, 25);
            lblCountDown.TabIndex = 11;
            lblCountDown.Text = "00:00:00.00";
            // 
            // lblCurrentTimeText
            // 
            lblCurrentTimeText.AutoSize = true;
            lblCurrentTimeText.Location = new Point(15, 32);
            lblCurrentTimeText.Name = "lblCurrentTimeText";
            lblCurrentTimeText.Size = new Size(50, 25);
            lblCurrentTimeText.TabIndex = 9;
            lblCurrentTimeText.Text = "Time";
            // 
            // lblLastrefresh
            // 
            lblLastrefresh.AutoSize = true;
            lblLastrefresh.Location = new Point(256, 27);
            lblLastrefresh.Name = "lblLastrefresh";
            lblLastrefresh.Size = new Size(102, 25);
            lblLastrefresh.TabIndex = 10;
            lblLastrefresh.Text = "Last refresh";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(15, 123);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(59, 25);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 333);
            progressBar1.Maximum = 300000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(411, 34);
            progressBar1.Step = 100;
            progressBar1.TabIndex = 7;
            // 
            // lblcurrenttime
            // 
            lblcurrenttime.AutoSize = true;
            lblcurrenttime.Location = new Point(15, 68);
            lblcurrenttime.Name = "lblcurrenttime";
            lblcurrenttime.Size = new Size(59, 25);
            lblcurrenttime.TabIndex = 3;
            lblcurrenttime.Text = "label1";
            // 
            // lbllastwritetime
            // 
            lbllastwritetime.AutoSize = true;
            lbllastwritetime.Location = new Point(256, 68);
            lbllastwritetime.Name = "lbllastwritetime";
            lbllastwritetime.Size = new Size(59, 25);
            lbllastwritetime.TabIndex = 2;
            lbllastwritetime.Text = "label1";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(72, 106);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(72, 50);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(112, 34);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Location = new Point(29, 3);
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
            tableLayoutPanel1.Size = new Size(959, 1683);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ContinentalUS
            // 
            ContinentalUS.AutoSize = true;
            ContinentalUS.Checked = true;
            ContinentalUS.Dock = DockStyle.Fill;
            ContinentalUS.Location = new Point(3, 3);
            ContinentalUS.Name = "ContinentalUS";
            ContinentalUS.Size = new Size(230, 168);
            ContinentalUS.TabIndex = 0;
            ContinentalUS.TabStop = true;
            ContinentalUS.Text = "Continental US";
            ContinentalUS.UseVisualStyleBackColor = true;
            ContinentalUS.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // TropicalAtlantic
            // 
            TropicalAtlantic.AutoSize = true;
            TropicalAtlantic.Dock = DockStyle.Fill;
            TropicalAtlantic.Location = new Point(3, 177);
            TropicalAtlantic.Name = "TropicalAtlantic";
            TropicalAtlantic.Size = new Size(230, 151);
            TropicalAtlantic.TabIndex = 1;
            TropicalAtlantic.TabStop = true;
            TropicalAtlantic.Text = "Tropical Atlantic";
            TropicalAtlantic.UseVisualStyleBackColor = true;
            TropicalAtlantic.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // TropicalPacific
            // 
            TropicalPacific.AutoSize = true;
            TropicalPacific.Dock = DockStyle.Fill;
            TropicalPacific.Location = new Point(3, 334);
            TropicalPacific.Name = "TropicalPacific";
            TropicalPacific.Size = new Size(230, 147);
            TropicalPacific.TabIndex = 2;
            TropicalPacific.TabStop = true;
            TropicalPacific.Text = "Tropical Pacific";
            TropicalPacific.UseVisualStyleBackColor = true;
            TropicalPacific.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // USWestCoast
            // 
            USWestCoast.AutoSize = true;
            USWestCoast.Dock = DockStyle.Fill;
            USWestCoast.Location = new Point(3, 487);
            USWestCoast.Name = "USWestCoast";
            USWestCoast.Size = new Size(230, 156);
            USWestCoast.TabIndex = 3;
            USWestCoast.TabStop = true;
            USWestCoast.Text = "US West Coast";
            USWestCoast.UseVisualStyleBackColor = true;
            USWestCoast.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // NorthernSouthAmerica
            // 
            NorthernSouthAmerica.AutoSize = true;
            NorthernSouthAmerica.Dock = DockStyle.Fill;
            NorthernSouthAmerica.Location = new Point(3, 649);
            NorthernSouthAmerica.Name = "NorthernSouthAmerica";
            NorthernSouthAmerica.Size = new Size(230, 135);
            NorthernSouthAmerica.TabIndex = 4;
            NorthernSouthAmerica.TabStop = true;
            NorthernSouthAmerica.Text = "Northern South America";
            NorthernSouthAmerica.UseVisualStyleBackColor = true;
            NorthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // SouthernSouthAmerica
            // 
            SouthernSouthAmerica.AutoSize = true;
            SouthernSouthAmerica.Dock = DockStyle.Fill;
            SouthernSouthAmerica.Location = new Point(3, 790);
            SouthernSouthAmerica.Name = "SouthernSouthAmerica";
            SouthernSouthAmerica.Size = new Size(230, 138);
            SouthernSouthAmerica.TabIndex = 5;
            SouthernSouthAmerica.TabStop = true;
            SouthernSouthAmerica.Text = "Southern South America";
            SouthernSouthAmerica.UseVisualStyleBackColor = true;
            SouthernSouthAmerica.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // Himawari8FullDisk
            // 
            Himawari8FullDisk.AutoSize = true;
            Himawari8FullDisk.Dock = DockStyle.Fill;
            Himawari8FullDisk.Location = new Point(3, 934);
            Himawari8FullDisk.Name = "Himawari8FullDisk";
            Himawari8FullDisk.Size = new Size(230, 176);
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
            NorthernPacific.Location = new Point(3, 1116);
            NorthernPacific.Name = "NorthernPacific";
            NorthernPacific.Size = new Size(230, 132);
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
            GOESEastFullDisk.Location = new Point(3, 1254);
            GOESEastFullDisk.Name = "GOESEastFullDisk";
            GOESEastFullDisk.Size = new Size(230, 193);
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
            GOESWestFullDisk.Location = new Point(3, 1453);
            GOESWestFullDisk.Name = "GOESWestFullDisk";
            GOESWestFullDisk.Size = new Size(230, 227);
            GOESWestFullDisk.TabIndex = 9;
            GOESWestFullDisk.TabStop = true;
            GOESWestFullDisk.Text = "GOES-West FullDisk";
            GOESWestFullDisk.UseVisualStyleBackColor = true;
            GOESWestFullDisk.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox1.Location = new Point(239, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/thumbnail.jpg";
            pictureBox2.Location = new Point(239, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/tpw/GEOCOLOR/thumbnail.jpg";
            pictureBox3.Location = new Point(239, 334);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(243, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/CONUS/GEOCOLOR/thumbnail.jpg";
            pictureBox4.Location = new Point(239, 487);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(243, 156);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/nsa/GEOCOLOR/thumbnail.jpg";
            pictureBox5.Location = new Point(239, 649);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(233, 135);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/thumbnail.jpg";
            pictureBox6.Location = new Point(239, 790);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(233, 138);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.ImageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/thumb/himawari-8/full_disk_ahi_true_color.jpg";
            pictureBox7.Location = new Point(239, 934);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(175, 176);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/np/GEOCOLOR/thumbnail.jpg";
            pictureBox8.Location = new Point(239, 1116);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(224, 132);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox9.Location = new Point(239, 1254);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(194, 193);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/thumbnail.jpg";
            pictureBox10.Location = new Point(239, 1453);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(187, 181);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 19;
            pictureBox10.TabStop = false;
            // 
            // myTimer
            // 
            myTimer.Interval = 300000;
            myTimer.Tick += ItemsForm_Load;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 1345);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "ItemsForm";
            Text = "Downlink for the PC";
            Load += ItemsForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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

        private SplitContainer splitContainer1;
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
    }
}