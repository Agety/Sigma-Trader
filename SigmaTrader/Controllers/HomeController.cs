using Microsoft.AspNetCore.Mvc;
using SigmaTrader.Models;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;


/*namespace TwelveData
{
    public class TimeSeries
    {
        public Dictionary<string, string> meta { get; set; }
        public IList<Dictionary<string, string>> values { get; set; }
        public string status { get; set; }
    }

    class Prices
    {
        public static double GetPrices() { 
            using WebClient wc = new WebClient();
            var response = wc.DownloadString("https://api.twelvedata.com/time_series?symbol=AAPL&interval=1day&outputsize=12&apikey=25e58a5c71304cddaa4c337dd546103a");
            var timeSeries = JsonSerializer.Deserialize<TimeSeries>(response);
            if (timeSeries.status == "ok")
            {
                int[timeSeries.values.Get] prices;
                for (int i =0; )
                {

                }
                return "Received symbol: " + timeSeries.meta["symbol"] + ", close: " + timeSeries.values[2]["close"];
            }
            else
            {
                return 0;
            }
        }
    }
}*/

namespace SigmaTrader.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Why()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
