using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class TechnicalSpecification
    {

        public int ID { get; set; }
        public string SilindirHacmi { get; set; }
        public string BeygirGucu { get; set; }
        public string YakitTuru { get; set; }
        public string SehirIciOrtalamaTuketim { get; set; }
        public string SehirDisiOrtalamaTuketim { get; set; }
        public string KarmaYakitTuketimi { get; set; }
        public string VitesTipi { get; set; }
        public string MaksimimTork { get; set; }
        public string LastikOlculeri { get; set; }
        public string SifirdanTuzeHizlanma { get; set; }
        public string MaksimumHiz { get; set; }
        public string Uzunluk { get; set; }
        public string Genişlik { get; set; }
        public string Tukseklik { get; set; }
        public string BagajHacmi { get; set; }
        public string BosAgırlik { get; set; }
        public string YakitDeposu { get; set; }
        public string YıllıkVergisi { get; set; }
       
        public virtual CarDetail CarDetail { get; set; }
    }
}