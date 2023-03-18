using NgocTram_2080601170.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NgocTram_2080601170.Viewmodels
{
    public class Courseviewmodels
    {
        public string Place { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}