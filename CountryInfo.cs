using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpRequest
{
    internal class CountryInfo
    {
        public List<string> capital { get; set; }
        public string region { get; set; }
        public double area { get; set; }

        public CountryInfo (List<string> capital, string region, double area)
        {
            this.capital = capital;
            this.region = region;
            this.area = area;
        }
    }
}
