using System;
using System.Windows.Forms;
using System.Collections.Generic;
using WeatherForecast.DataObject;
using WeatherForecast.BL;

namespace WeatherForecast
{
    public partial class searchLocationForm : Form
    {
        LocationsResponse? response;
        public searchLocationForm()
        {
            InitializeComponent();
            searchLocationBtn.Enabled = false;
            selectCityBtn.Enabled = false;
        }

        private async void searchLocationBtn_Click(object sender, EventArgs e)
        {
            WeatherAPIClient client = new WeatherAPIClient();
            searchLocationBtn.Enabled = false;
            response = await client.SearchLocations(searchLocationTb.Text);
            searchLocationBtn.Enabled = true;

            List <string> resultsList = new List<string> ();    
            foreach (var item in response.Results) 
            {
                string toList = string.Join(" ", item.Name, item.Country, item.AdminRegion);
                resultsList.Add (toList);
            }

            string [] resultsArray = resultsList.ToArray();
            searchResultsLb.Items.Clear();
            selectCityBtn.Enabled = false;
            searchResultsLb.Items.AddRange(resultsArray);
        }
        private void selectCityBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppSettingsUtility.selectedLocation = response.Results[searchResultsLb.SelectedIndex];
            AppSettingsUtility.SaveSettings();
        }

        private void searchLocationTb_TextChanged(object sender, EventArgs e)
        {
            searchLocationBtn.Enabled = !string.IsNullOrWhiteSpace(searchLocationTb.Text);
        }

        private void searchResultsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCityBtn.Enabled = true;
        }
    }
}
