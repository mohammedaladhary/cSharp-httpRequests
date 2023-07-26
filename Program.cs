using System.Text.Json;
using static httpRequest.GeoCoding;

namespace httpRequest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //List<CountryInfo> response = await callAPI();
            //Console.WriteLine(response);

            WeatherData weatherData = new WeatherData(
                new Coord(-74.006, 40.7143),
                new List<WeatherInfo> { new WeatherInfo(800, "Clear", "clear sky", "01n") },
                new BaseInfo(2),
                new MainWeatherData(292.96, 293.19, 290.29, 294.38, 1019, 84),
                10000,
                new WindInfo(1.54, 250),
                new CloudsInfo(0),
                1690354406,
                new SysInfo(2, 2008101, "US", 1690364802, 1690417086),
                -14400,
                5128581,
                "New York",
                200
                );
            
        }

        //public async static Task<List<CountryInfo>> callAPI()
        //{
        //    string api = "https://restcountries.com/v3.1/all?fields=name,capital,area";
        //    HttpClient client = new HttpClient();
        //    HttpResponseMessage responseMessage = await client.GetAsync(api);
        //    List<CountryInfo> countries = new List<CountryInfo>();

        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        string stringResponse = await responseMessage.Content.ReadAsStringAsync();
        //        JsonDocument document = JsonDocument.Parse(stringResponse);
        //        JsonElement element = document.RootElement;
        //        if(element.ValueKind == JsonValueKind.Array)
        //        {
        //            var enumerator = element.EnumerateArray;
        //            foreach ( JsonElement country in element.EnumerateArray()) 
        //            {
        //                string capital = "";
        //                if (country.GetProperty("capital").GetArrayLength() > 0)
        //                {
        //                    capital = country.GetProperty("capital")[0].ToString();
        //                }
        //                Double area = country.GetProperty("area").GetDouble();
        //                String officialName = country.GetProperty("name").GetProperty("official").GetString();
        //                countries.Add(new CountryInfo(officialName, capital, area));
        //            }
        //        }
        //    }
        //    return countries;
        //}

        //public async void callWeatherAPI()
        //{
        //    try
        //    {
        //        String baseUrl = 
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}