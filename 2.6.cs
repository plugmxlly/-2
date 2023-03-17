using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Program
{
    static async Task Main(string[] args)
    {
        var api = "66c92e4a68e2ae3f43f1366dda732084";
        double lat = -50.00;
        double lon = -60.00;

        var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={api}";

        using var client = new HttpClient();
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var weather = JsonConvert.DeserializeObject<WeatherResponse>(content);
            Console.WriteLine($"температура по координатам {lat} {lon} : {weather.Main.Temp - 273.15} гр.Цельсия");
        }

        else
        {
            Console.WriteLine($"Ошибка: {response.StatusCode}");
        }
    }
}

public class WeatherResponse
{ 
    public MainInfo Main { get; set; }
}

public class MainInfo
{
    public double Temp { get; set; }
}