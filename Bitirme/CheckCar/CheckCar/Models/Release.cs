using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class Release
    {
        
        public int ID { get; set; }
        public string ReleaseYear { get; set; }
        public string ReleaseName { get; set; }
        public string Price { get; set; }
        public bool OnSale { get; set; }

        public virtual CarDetail CarDetail { get; set; }

        public int MarkVersionID { get; set; }
        public virtual MarkVersion MarkVersion { get; set; }

    }

    

}