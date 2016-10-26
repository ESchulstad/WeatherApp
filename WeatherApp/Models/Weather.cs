using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=9bb3acfd1cccbc248cb6dea6c080e050&units=imperial";
            //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}