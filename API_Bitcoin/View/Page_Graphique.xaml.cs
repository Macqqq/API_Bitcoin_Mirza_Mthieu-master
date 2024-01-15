using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace API_Bitcoin.View
{
    public partial class Page_Graphique : UserControl
    {
        public List<List<double>> MyArray { get; set; }

        public Page_Graphique()
        {
            InitializeComponent();
            MakeApiRequest();
        }

        private async void MakeApiRequest()
        {
            var client = new RestClient("https://openapiv1.coinstats.app/coins/bitcoin/charts?period=1m");
            var request = new RestRequest();
            request.AddHeader("X-API-KEY", "0qSRvDzjqVmDWRMnBiHkx/2v/wefOSm6q8WIUguCrEE=");

            try
            {
                var response = await client.GetAsync(request);
                ProcessApiResponse(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la requête : {ex.Message}");
            }
        }

        private void ProcessApiResponse(string responseContent)
        {
            // Directement désérialiser dans la propriété MyArray
            MyArray = JsonConvert.DeserializeObject<List<List<double>>>(responseContent);
            UpdateBitcoinChart();
        }

        private void UpdateBitcoinChart()
        {
            var chartValues = new ChartValues<double>();
            foreach (var point in MyArray)
            {
                // Supposons que le deuxième élément est le prix
                chartValues.Add(point[1]);
            }

            ChartBitcoin.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = chartValues,
                    PointGeometry = null
                }
            };
        }
    }
}