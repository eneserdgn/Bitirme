using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class CarDetail
    {
        
        public int ID { get; set; }
        public string CarName { get; set; }
        public string CarDetailImage { get; set; }
        public string YakitTuketimi { get; set; }
        public string MalzemeKalitesi { get; set; }
        public string Yoltutusu { get; set; }
        public string HızlanmaPerformansı { get; set; }
        public string SesYalıtımı { get; set; }
        public string VitesGecisleri { get; set; }
        public string IcMekanGenisligi { get; set; }
        public string DonanimTeknolojisi { get; set; }
        public string İkinciElPiyasa { get; set; }

        public virtual Release Release { get; set; }      
        public virtual Security Security { get; set; }       
        public virtual TechnicalSpecification TechnicalSpecification { get; set; }       
        public virtual Technology Technology { get; set; }



    }
}