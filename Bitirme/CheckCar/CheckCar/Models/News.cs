using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class News
    {
        public int ID { get; set; }
        public string NewsImage { get; set; }
        public string NewsIcerik { get; set; }
        public string NewsBaslik { get; set; }
        public DateTime Date { get; set; }
    }
}