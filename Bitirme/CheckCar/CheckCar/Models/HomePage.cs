using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class HomePage
    {
        public List<Mark> Marka { get; set; }
        public List<Release> EnYuksekFiyat { get; set; }
        public List<Release> YeniEklenenler { get; set; }
        public List<CarDetail> CarDetail { get; set; }
        public List<News> News { get; set; }
    }
}