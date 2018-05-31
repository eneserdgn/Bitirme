using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class MarkVersion
    {
        public int ID { get; set; }
        public string VersionName { get; set; }
        public string VersionImage { get; set; }
        public int MarkID { get; set; }
        public virtual Mark Mark { get; set; }
        public virtual ICollection<Release> Releases { get; set; }
    }
}