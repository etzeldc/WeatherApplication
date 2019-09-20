using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.Models
{
    public class WeatherViewModel
    {
        public Dark.Daily daily = new Dark.Daily();
        public Dark.Currently currently = new Dark.Currently();
        public Dark.Hourly hourly = new Dark.Hourly();
    }
}