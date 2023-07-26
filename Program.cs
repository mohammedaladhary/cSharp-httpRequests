using Newtonsoft.Json;
using System.Security.Principal;
using System.Text.Json;

namespace httpRequest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            await callAPI();
            //List<CountryInfo> response =
            //Console.WriteLine(response);
            
        }

        public async static Task<List<CountryInfo>> callAPI()
        {
            string api = "https://restcountries.com/v3.1/all?fields=region,capital,area";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(api);
                List<CountryInfo> countries = new List<CountryInfo>();

                if (responseMessage.IsSuccessStatusCode)
                {
                    string stringResponse = await responseMessage.Content.ReadAsStringAsync();
                    //JsonDocument document = JsonDocument.Parse(stringResponse);
                    //JsonElement element = document.RootElement;
                    //if(element.ValueKind == JsonValueKind.Array)
                    //{
                    //    var enumerator = element.EnumerateArray;
                    //    foreach ( JsonElement country in element.EnumerateArray()) 
                    //    {
                    //        string capital = "";
                    //        if (country.GetProperty("capital").GetArrayLength() > 0)
                    //        {
                    //            capital = country.GetProperty("capital")[0].ToString();
                    //        }
                    //        Double area = country.GetProperty("area").GetDouble();
                    //        String officialName = country.GetProperty("name").GetProperty("official").GetString();
                    //        countries.Add(new CountryInfo(officialName, capital, area));
                    //    }
                    //}

                    List<CountryInfo> infos = JsonConvert.DeserializeObject<List<CountryInfo>>(stringResponse);

                    Console.WriteLine(infos.Count);
                    //Console.WriteLine(infos.ToString());
                    foreach(CountryInfo info in infos)
                    {
                        Console.WriteLine($"Region: {info.region},  Capital: {info.capital},  Area: {info.area} ");
                    }
                }
                return countries;
            } 
        }

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