namespace WeatherForecast
{
    partial class weatherForecastMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weatherForecastMainForm));
            this.forecastSettingsPanel = new System.Windows.Forms.Panel();
            this.searchCityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.selectedCityLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.currentDayWeatherPanel = new System.Windows.Forms.Panel();
            this.currentWinddirectionLabel = new System.Windows.Forms.Label();
            this.selectedCityPanelLabel = new System.Windows.Forms.Label();
            this.currentDayMinMaxeTempLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentWindspeedLabel = new System.Windows.Forms.Label();
            this.currentDayOfWeekLabel = new System.Windows.Forms.Label();
            this.currentDayTempLabel = new System.Windows.Forms.Label();
            this.currentDayWeatherPb = new System.Windows.Forms.PictureBox();
            this.currentWeekWeatherPanel = new System.Windows.Forms.Panel();
            this.day6TempLabel = new System.Windows.Forms.Label();
            this.day7TempLabel = new System.Windows.Forms.Label();
            this.day2TempLabel = new System.Windows.Forms.Label();
            this.day3TempLabel = new System.Windows.Forms.Label();
            this.day4TempLabel = new System.Windows.Forms.Label();
            this.day5TempLabel = new System.Windows.Forms.Label();
            this.day1TempLabel = new System.Windows.Forms.Label();
            this.day2Label = new System.Windows.Forms.Label();
            this.day3Label = new System.Windows.Forms.Label();
            this.day7Label = new System.Windows.Forms.Label();
            this.day6Label = new System.Windows.Forms.Label();
            this.day5Label = new System.Windows.Forms.Label();
            this.day4Label = new System.Windows.Forms.Label();
            this.day1Label = new System.Windows.Forms.Label();
            this.day2Pb = new System.Windows.Forms.PictureBox();
            this.day7Pb = new System.Windows.Forms.PictureBox();
            this.day6Pb = new System.Windows.Forms.PictureBox();
            this.day5Pb = new System.Windows.Forms.PictureBox();
            this.day3Pb = new System.Windows.Forms.PictureBox();
            this.day4Pb = new System.Windows.Forms.PictureBox();
            this.day1Pb = new System.Windows.Forms.PictureBox();
            this.forecastSettingsPanel.SuspendLayout();
            this.currentDayWeatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDayWeatherPb)).BeginInit();
            this.currentWeekWeatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day7Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day6Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day5Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastSettingsPanel
            // 
            this.forecastSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forecastSettingsPanel.Controls.Add(this.searchCityLinkLabel);
            this.forecastSettingsPanel.Controls.Add(this.selectedCityLabel);
            this.forecastSettingsPanel.Controls.Add(this.cityLabel);
            this.forecastSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.forecastSettingsPanel.Name = "forecastSettingsPanel";
            this.forecastSettingsPanel.Size = new System.Drawing.Size(808, 60);
            this.forecastSettingsPanel.TabIndex = 0;
            // 
            // searchCityLinkLabel
            // 
            this.searchCityLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchCityLinkLabel.AutoSize = true;
            this.searchCityLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCityLinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCityLinkLabel.LinkColor = System.Drawing.Color.Indigo;
            this.searchCityLinkLabel.Location = new System.Drawing.Point(153, 21);
            this.searchCityLinkLabel.Name = "searchCityLinkLabel";
            this.searchCityLinkLabel.Size = new System.Drawing.Size(64, 22);
            this.searchCityLinkLabel.TabIndex = 2;
            this.searchCityLinkLabel.TabStop = true;
            this.searchCityLinkLabel.Text = "Search";
            this.searchCityLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchCityLinkLabel_LinkClicked);
            // 
            // selectedCityLabel
            // 
            this.selectedCityLabel.AutoSize = true;
            this.selectedCityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedCityLabel.ForeColor = System.Drawing.Color.White;
            this.selectedCityLabel.Location = new System.Drawing.Point(122, 20);
            this.selectedCityLabel.Name = "selectedCityLabel";
            this.selectedCityLabel.Size = new System.Drawing.Size(25, 23);
            this.selectedCityLabel.TabIndex = 1;
            this.selectedCityLabel.Text = "...";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(24, 20);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(92, 23);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Your city:";
            // 
            // currentDayWeatherPanel
            // 
            this.currentDayWeatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.currentDayWeatherPanel.Controls.Add(this.currentWinddirectionLabel);
            this.currentDayWeatherPanel.Controls.Add(this.selectedCityPanelLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentDayMinMaxeTempLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentTimeLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentWindspeedLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentDayOfWeekLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentDayTempLabel);
            this.currentDayWeatherPanel.Controls.Add(this.currentDayWeatherPb);
            this.currentDayWeatherPanel.Location = new System.Drawing.Point(24, 79);
            this.currentDayWeatherPanel.Name = "currentDayWeatherPanel";
            this.currentDayWeatherPanel.Size = new System.Drawing.Size(752, 184);
            this.currentDayWeatherPanel.TabIndex = 1;
            // 
            // currentWinddirectionLabel
            // 
            this.currentWinddirectionLabel.AutoSize = true;
            this.currentWinddirectionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentWinddirectionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentWinddirectionLabel.Location = new System.Drawing.Point(671, 136);
            this.currentWinddirectionLabel.Name = "currentWinddirectionLabel";
            this.currentWinddirectionLabel.Size = new System.Drawing.Size(24, 22);
            this.currentWinddirectionLabel.TabIndex = 8;
            this.currentWinddirectionLabel.Text = "N";
            // 
            // selectedCityPanelLabel
            // 
            this.selectedCityPanelLabel.AutoSize = true;
            this.selectedCityPanelLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedCityPanelLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedCityPanelLabel.Location = new System.Drawing.Point(434, 22);
            this.selectedCityPanelLabel.Name = "selectedCityPanelLabel";
            this.selectedCityPanelLabel.Size = new System.Drawing.Size(65, 32);
            this.selectedCityPanelLabel.TabIndex = 7;
            this.selectedCityPanelLabel.Text = "City";
            // 
            // currentDayMinMaxeTempLabel
            // 
            this.currentDayMinMaxeTempLabel.AutoSize = true;
            this.currentDayMinMaxeTempLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentDayMinMaxeTempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.currentDayMinMaxeTempLabel.Location = new System.Drawing.Point(557, 70);
            this.currentDayMinMaxeTempLabel.Name = "currentDayMinMaxeTempLabel";
            this.currentDayMinMaxeTempLabel.Size = new System.Drawing.Size(117, 49);
            this.currentDayMinMaxeTempLabel.TabIndex = 6;
            this.currentDayMinMaxeTempLabel.Text = "-2/+5";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentTimeLabel.Location = new System.Drawing.Point(261, 136);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(56, 22);
            this.currentTimeLabel.TabIndex = 5;
            this.currentTimeLabel.Text = "15:18";
            // 
            // currentWindspeedLabel
            // 
            this.currentWindspeedLabel.AutoSize = true;
            this.currentWindspeedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentWindspeedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentWindspeedLabel.Location = new System.Drawing.Point(557, 136);
            this.currentWindspeedLabel.Name = "currentWindspeedLabel";
            this.currentWindspeedLabel.Size = new System.Drawing.Size(94, 22);
            this.currentWindspeedLabel.TabIndex = 3;
            this.currentWindspeedLabel.Text = "20km/hour";
            // 
            // currentDayOfWeekLabel
            // 
            this.currentDayOfWeekLabel.AutoSize = true;
            this.currentDayOfWeekLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentDayOfWeekLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentDayOfWeekLabel.Location = new System.Drawing.Point(323, 136);
            this.currentDayOfWeekLabel.Name = "currentDayOfWeekLabel";
            this.currentDayOfWeekLabel.Size = new System.Drawing.Size(83, 22);
            this.currentDayOfWeekLabel.TabIndex = 2;
            this.currentDayOfWeekLabel.Text = "Thursday";
            // 
            // currentDayTempLabel
            // 
            this.currentDayTempLabel.AutoSize = true;
            this.currentDayTempLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentDayTempLabel.ForeColor = System.Drawing.Color.White;
            this.currentDayTempLabel.Location = new System.Drawing.Point(279, 70);
            this.currentDayTempLabel.Name = "currentDayTempLabel";
            this.currentDayTempLabel.Size = new System.Drawing.Size(58, 49);
            this.currentDayTempLabel.TabIndex = 1;
            this.currentDayTempLabel.Text = "-2";
            // 
            // currentDayWeatherPb
            // 
            this.currentDayWeatherPb.Location = new System.Drawing.Point(25, 22);
            this.currentDayWeatherPb.Name = "currentDayWeatherPb";
            this.currentDayWeatherPb.Size = new System.Drawing.Size(224, 136);
            this.currentDayWeatherPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentDayWeatherPb.TabIndex = 0;
            this.currentDayWeatherPb.TabStop = false;
            // 
            // currentWeekWeatherPanel
            // 
            this.currentWeekWeatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.currentWeekWeatherPanel.Controls.Add(this.day6TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day7TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day2TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day3TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day4TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day5TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day1TempLabel);
            this.currentWeekWeatherPanel.Controls.Add(this.day2Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day3Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day7Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day6Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day5Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day4Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day1Label);
            this.currentWeekWeatherPanel.Controls.Add(this.day2Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day7Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day6Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day5Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day3Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day4Pb);
            this.currentWeekWeatherPanel.Controls.Add(this.day1Pb);
            this.currentWeekWeatherPanel.Location = new System.Drawing.Point(24, 269);
            this.currentWeekWeatherPanel.Name = "currentWeekWeatherPanel";
            this.currentWeekWeatherPanel.Size = new System.Drawing.Size(752, 160);
            this.currentWeekWeatherPanel.TabIndex = 2;
            // 
            // day6TempLabel
            // 
            this.day6TempLabel.AutoSize = true;
            this.day6TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day6TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day6TempLabel.Location = new System.Drawing.Point(537, 112);
            this.day6TempLabel.Name = "day6TempLabel";
            this.day6TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day6TempLabel.TabIndex = 21;
            this.day6TempLabel.Text = "Mon";
            // 
            // day7TempLabel
            // 
            this.day7TempLabel.AutoSize = true;
            this.day7TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day7TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day7TempLabel.Location = new System.Drawing.Point(640, 112);
            this.day7TempLabel.Name = "day7TempLabel";
            this.day7TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day7TempLabel.TabIndex = 20;
            this.day7TempLabel.Text = "Mon";
            // 
            // day2TempLabel
            // 
            this.day2TempLabel.AutoSize = true;
            this.day2TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day2TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day2TempLabel.Location = new System.Drawing.Point(127, 112);
            this.day2TempLabel.Name = "day2TempLabel";
            this.day2TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day2TempLabel.TabIndex = 19;
            this.day2TempLabel.Text = "Mon";
            // 
            // day3TempLabel
            // 
            this.day3TempLabel.AutoSize = true;
            this.day3TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day3TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day3TempLabel.Location = new System.Drawing.Point(230, 112);
            this.day3TempLabel.Name = "day3TempLabel";
            this.day3TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day3TempLabel.TabIndex = 18;
            this.day3TempLabel.Text = "Mon";
            // 
            // day4TempLabel
            // 
            this.day4TempLabel.AutoSize = true;
            this.day4TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day4TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day4TempLabel.Location = new System.Drawing.Point(332, 112);
            this.day4TempLabel.Name = "day4TempLabel";
            this.day4TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day4TempLabel.TabIndex = 17;
            this.day4TempLabel.Text = "Mon";
            // 
            // day5TempLabel
            // 
            this.day5TempLabel.AutoSize = true;
            this.day5TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day5TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day5TempLabel.Location = new System.Drawing.Point(434, 112);
            this.day5TempLabel.Name = "day5TempLabel";
            this.day5TempLabel.Size = new System.Drawing.Size(60, 25);
            this.day5TempLabel.TabIndex = 16;
            this.day5TempLabel.Text = "Mon";
            // 
            // day1TempLabel
            // 
            this.day1TempLabel.AutoSize = true;
            this.day1TempLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day1TempLabel.ForeColor = System.Drawing.Color.Lavender;
            this.day1TempLabel.Location = new System.Drawing.Point(25, 112);
            this.day1TempLabel.Name = "day1TempLabel";
            this.day1TempLabel.Size = new System.Drawing.Size(58, 25);
            this.day1TempLabel.TabIndex = 15;
            this.day1TempLabel.Text = "-2/-5";
            // 
            // day2Label
            // 
            this.day2Label.AutoSize = true;
            this.day2Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day2Label.Location = new System.Drawing.Point(168, 79);
            this.day2Label.Name = "day2Label";
            this.day2Label.Size = new System.Drawing.Size(46, 22);
            this.day2Label.TabIndex = 14;
            this.day2Label.Text = "Mon";
            // 
            // day3Label
            // 
            this.day3Label.AutoSize = true;
            this.day3Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day3Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day3Label.Location = new System.Drawing.Point(271, 79);
            this.day3Label.Name = "day3Label";
            this.day3Label.Size = new System.Drawing.Size(46, 22);
            this.day3Label.TabIndex = 13;
            this.day3Label.Text = "Mon";
            // 
            // day7Label
            // 
            this.day7Label.AutoSize = true;
            this.day7Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day7Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day7Label.Location = new System.Drawing.Point(681, 79);
            this.day7Label.Name = "day7Label";
            this.day7Label.Size = new System.Drawing.Size(46, 22);
            this.day7Label.TabIndex = 12;
            this.day7Label.Text = "Mon";
            // 
            // day6Label
            // 
            this.day6Label.AutoSize = true;
            this.day6Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day6Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day6Label.Location = new System.Drawing.Point(578, 79);
            this.day6Label.Name = "day6Label";
            this.day6Label.Size = new System.Drawing.Size(46, 22);
            this.day6Label.TabIndex = 11;
            this.day6Label.Text = "Mon";
            // 
            // day5Label
            // 
            this.day5Label.AutoSize = true;
            this.day5Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day5Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day5Label.Location = new System.Drawing.Point(475, 79);
            this.day5Label.Name = "day5Label";
            this.day5Label.Size = new System.Drawing.Size(46, 22);
            this.day5Label.TabIndex = 10;
            this.day5Label.Text = "Mon";
            // 
            // day4Label
            // 
            this.day4Label.AutoSize = true;
            this.day4Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day4Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day4Label.Location = new System.Drawing.Point(373, 79);
            this.day4Label.Name = "day4Label";
            this.day4Label.Size = new System.Drawing.Size(46, 22);
            this.day4Label.TabIndex = 8;
            this.day4Label.Text = "Mon";
            // 
            // day1Label
            // 
            this.day1Label.AutoSize = true;
            this.day1Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day1Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.day1Label.Location = new System.Drawing.Point(66, 79);
            this.day1Label.Name = "day1Label";
            this.day1Label.Size = new System.Drawing.Size(46, 22);
            this.day1Label.TabIndex = 7;
            this.day1Label.Text = "Mon";
            // 
            // day2Pb
            // 
            this.day2Pb.Location = new System.Drawing.Point(127, 15);
            this.day2Pb.Name = "day2Pb";
            this.day2Pb.Size = new System.Drawing.Size(87, 61);
            this.day2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day2Pb.TabIndex = 6;
            this.day2Pb.TabStop = false;
            // 
            // day7Pb
            // 
            this.day7Pb.Location = new System.Drawing.Point(640, 15);
            this.day7Pb.Name = "day7Pb";
            this.day7Pb.Size = new System.Drawing.Size(87, 61);
            this.day7Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day7Pb.TabIndex = 5;
            this.day7Pb.TabStop = false;
            // 
            // day6Pb
            // 
            this.day6Pb.Location = new System.Drawing.Point(537, 15);
            this.day6Pb.Name = "day6Pb";
            this.day6Pb.Size = new System.Drawing.Size(87, 61);
            this.day6Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day6Pb.TabIndex = 4;
            this.day6Pb.TabStop = false;
            // 
            // day5Pb
            // 
            this.day5Pb.Location = new System.Drawing.Point(434, 15);
            this.day5Pb.Name = "day5Pb";
            this.day5Pb.Size = new System.Drawing.Size(87, 61);
            this.day5Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day5Pb.TabIndex = 3;
            this.day5Pb.TabStop = false;
            // 
            // day3Pb
            // 
            this.day3Pb.Location = new System.Drawing.Point(230, 15);
            this.day3Pb.Name = "day3Pb";
            this.day3Pb.Size = new System.Drawing.Size(87, 61);
            this.day3Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day3Pb.TabIndex = 2;
            this.day3Pb.TabStop = false;
            // 
            // day4Pb
            // 
            this.day4Pb.Location = new System.Drawing.Point(332, 15);
            this.day4Pb.Name = "day4Pb";
            this.day4Pb.Size = new System.Drawing.Size(87, 61);
            this.day4Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day4Pb.TabIndex = 1;
            this.day4Pb.TabStop = false;
            // 
            // day1Pb
            // 
            this.day1Pb.Location = new System.Drawing.Point(25, 15);
            this.day1Pb.Name = "day1Pb";
            this.day1Pb.Size = new System.Drawing.Size(87, 61);
            this.day1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day1Pb.TabIndex = 0;
            this.day1Pb.TabStop = false;
            // 
            // weatherForecastMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentWeekWeatherPanel);
            this.Controls.Add(this.currentDayWeatherPanel);
            this.Controls.Add(this.forecastSettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "weatherForecastMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast";
            this.Load += new System.EventHandler(this.weatherForecastMainForm_Load);
            this.forecastSettingsPanel.ResumeLayout(false);
            this.forecastSettingsPanel.PerformLayout();
            this.currentDayWeatherPanel.ResumeLayout(false);
            this.currentDayWeatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDayWeatherPb)).EndInit();
            this.currentWeekWeatherPanel.ResumeLayout(false);
            this.currentWeekWeatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day7Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day6Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day5Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel forecastSettingsPanel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Panel currentDayWeatherPanel;
        private System.Windows.Forms.Panel currentWeekWeatherPanel;
        private System.Windows.Forms.LinkLabel searchCityLinkLabel;
        private System.Windows.Forms.Label selectedCityLabel;
        private System.Windows.Forms.PictureBox currentDayWeatherPb;
        private System.Windows.Forms.PictureBox day2Pb;
        private System.Windows.Forms.PictureBox day7Pb;
        private System.Windows.Forms.PictureBox day6Pb;
        private System.Windows.Forms.PictureBox day5Pb;
        private System.Windows.Forms.PictureBox day3Pb;
        private System.Windows.Forms.PictureBox day4Pb;
        private System.Windows.Forms.PictureBox day1Pb;
        private System.Windows.Forms.Label currentDayTempLabel;
        private System.Windows.Forms.Label currentWindspeedLabel;
        private System.Windows.Forms.Label currentDayOfWeekLabel;
        private System.Windows.Forms.Label currentDayMinMaxeTempLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label selectedCityPanelLabel;
        private System.Windows.Forms.Label currentWinddirectionLabel;
        private System.Windows.Forms.Label day2Label;
        private System.Windows.Forms.Label day3Label;
        private System.Windows.Forms.Label day7Label;
        private System.Windows.Forms.Label day6Label;
        private System.Windows.Forms.Label day5Label;
        private System.Windows.Forms.Label day4Label;
        private System.Windows.Forms.Label day1Label;
        private System.Windows.Forms.Label day6TempLabel;
        private System.Windows.Forms.Label day7TempLabel;
        private System.Windows.Forms.Label day2TempLabel;
        private System.Windows.Forms.Label day3TempLabel;
        private System.Windows.Forms.Label day4TempLabel;
        private System.Windows.Forms.Label day5TempLabel;
        private System.Windows.Forms.Label day1TempLabel;
    }
}
