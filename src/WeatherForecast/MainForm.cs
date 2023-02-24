using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherForecast.DataObject;
using System.Globalization;
using System.IO;
using System.Reflection;
using WeatherForecast.BL;

namespace WeatherForecast
{
    public partial class weatherForecastMainForm : Form
    {
        List<Label> daysOfWeekLabels;
        List<Label> weeklyTempLabels;
        List<PictureBox> weeklyWeatherIcons;

        public weatherForecastMainForm()
        {
            InitializeComponent();
            currentDayWeatherPanel.Visible = false;
            currentWeekWeatherPanel.Visible = false;
            daysOfWeekLabels = new List<Label>() { day1Label, day2Label, day3Label, day4Label, day5Label, day6Label, day7Label };
            weeklyTempLabels = new List<Label>() { day1TempLabel, day2TempLabel, day3TempLabel, day4TempLabel, day5TempLabel, day6TempLabel, day7TempLabel };
            weeklyWeatherIcons = new List<PictureBox>() { day1Pb, day2Pb, day3Pb, day4Pb, day5Pb, day6Pb, day7Pb };
            AppSettingsUtility.ReadSettings();
        }

        private async Task ShowWeatherForecast()
        {
            if (AppSettingsUtility.selectedLocation == null)
                return;

            selectedCityLabel.Text = AppSettingsUtility.selectedLocation.Name;
            int x = selectedCityLabel.Location.X + selectedCityLabel.Width;
            searchCityLinkLabel.Location = new System.Drawing.Point(x + 10, searchCityLinkLabel.Location.Y);

            currentDayWeatherPanel.Visible = true;
            currentWeekWeatherPanel.Visible = true;

            WeatherAPIClient client = new WeatherAPIClient();
            WeatherForecastResponse response = await client.GetWeatherForecastAsync();
            WeatherForecastResponse response7Days = await client.Get7DaysWeatherForecastAsync();

            WeatherCode code = WeatherResponseConverter.GetWeatherCodeAsEnum(response.CurrentWeather.WeatherCode);

            currentDayTempLabel.Text = $"{(int)response.CurrentWeather.Temperature} °C";
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm");
            currentDayOfWeekLabel.Text = DateTime.Today.ToString("dddd", new CultureInfo("en-US"));
            currentDayMinMaxeTempLabel.Text = $"{(int)response.WeeklyWeather.MaxTemperature.Max()}°/{(int)response.WeeklyWeather.MinTemperature.Min()}°";
            selectedCityPanelLabel.Text = AppSettingsUtility.selectedLocation.Name;
            currentWindspeedLabel.Text = $"{response.CurrentWeather.Windspeed} km/hour";
            currentWinddirectionLabel.Text = WeatherResponseConverter.ReadWindDirectionCode((int)response.CurrentWeather.WindDirection);
            ShowWeatherIcon(code, currentDayWeatherPb);
            ShowDaysOfWeek();
            ShowWeeklyTemp(response7Days);
            ShowWeeklyWeatherIcons(response7Days);
        }
        private async void SearchCityLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchLocationForm form = new searchLocationForm();
            form.ShowDialog();
            await ShowWeatherForecast();
        }

        private void ShowWeatherIcon (WeatherCode code, PictureBox pb)
        {
            switch (code)
            {
                case WeatherCode.Clear:
                    pb.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/SunIcon.png"));
                    break;
                case WeatherCode.Clouds:
                    pb.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/CloudIcon.png"));
                    break;
                case WeatherCode.Fog:
                    pb.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/FogIcon.png"));
                    break;
                case WeatherCode.Rain:
                    pb.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/RainIcon.png"));
                    break;
                case WeatherCode.Snow:
                    pb.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/SnowIcon.png"));
                    break;
            }
        }

        private void ShowDaysOfWeek()
        {
            int i = 1;
            foreach (var label in daysOfWeekLabels)
            {
                label.Text = DateTime.Today.AddDays(i++).ToString("ddd", new CultureInfo("en-US"));
            }
        }

        private void ShowWeeklyTemp (WeatherForecastResponse response7Days)
        {
            int i = 0;
            foreach (var label in weeklyTempLabels)
            {
                label.Text = $"{(int)response7Days.WeeklyWeather.MaxTemperature[i]}°/{(int)response7Days.WeeklyWeather.MinTemperature[i]}°";
                i++;
            }
        }

        private void ShowWeeklyWeatherIcons (WeatherForecastResponse response7Days)
        {
            int i = 0;
            foreach (var picture in weeklyWeatherIcons)
            {
                WeatherCode code = WeatherResponseConverter.GetWeatherCodeAsEnum(response7Days.WeeklyWeather.Weathercode[i]);
                ShowWeatherIcon(code, picture);
                i++;
            }
        }

        private async void weatherForecastMainForm_Load(object sender, EventArgs e)
        {
            await ShowWeatherForecast();
        }
    }
    
    
}

