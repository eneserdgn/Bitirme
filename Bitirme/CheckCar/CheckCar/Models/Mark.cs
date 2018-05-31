using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class Mark
    {
        
        public int ID { get; set; }
        public string MarkName { get; set; }
        public string MarkImage { get; set; }

        public virtual ICollection<MarkVersion> MarkVersions { get; set; }
    }
}