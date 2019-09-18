using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class WeatherViewModel
    {
        public Daily daily = new Daily();
        public Currently currently = new Currently();
        public Hourly hourly = new Hourly();
    }
}