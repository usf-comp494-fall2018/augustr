using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using FinalProject.Models;
using System.Net.Http;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<DataForDisplay> _results;
        public MainPage()
        {
            this.InitializeComponent();
            _results = new ObservableCollection<DataForDisplay>();
            forecastResults.ItemsSource = _results;
        }

        private async void getForecastButton_Click(object sender, RoutedEventArgs e)
        {

            if (selectingForecast.SelectedIndex > -1)
            {
                _results.Clear();
                using (var client = new HttpClient())
                {
                    switch (selectingForecast.SelectedValue)
                    {
                        case "Three Day":
                            var threeDayResponse =
                                await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                            var threeDayList = JsonConvert.DeserializeObject<List<ThreeDay>>(threeDayResponse);
                            foreach (var threeDay in threeDayList)
                            {
                                _results.Add(new DataForDisplay()
                                {
                                    Id = threeDay.Id,
                                    DisplayName = threeDay.Title,
                                    DisplayDetails = $"{threeDay.Fcttext} Last Checked: {threeDay.Lastcheck}"
                                });
                            }
                            break;
                        case "Current":
                            var currentResponse =
                                await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/5");
                            var current = JsonConvert.DeserializeObject<Current>(currentResponse);
                            _results.Add(new DataForDisplay()
                            {
                                Id = current.id,
                                DisplayName = current.observationTime,
                                DisplayDetails = $"Weather Condition: {current.weather} Temp: {current.tempF}F  Humidity is at {current.relativeHumidity} and the wind is blowing {current.windDir} at {current.windMph}. Last Checked at {current.lastcheck}"
                            });
                            break;

                    }
                }
            }

        }
    }
}