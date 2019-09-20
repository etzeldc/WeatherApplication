using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.Models
{
    namespace ProMap
    {
        public class Rootobject
        {
            public int status { get; set; }
            public Output[] output { get; set; }
        }

        public class Output
        {
            public string postcode { get; set; }
            public float distance { get; set; }
        }
    }
}