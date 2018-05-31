using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class Security
    {
        
        public int ID { get; set; }
        public bool SurucuHavaYastigi { get; set; }
        public bool YanPerdeHavaYastigi { get; set; }
        public bool LastikBasıncKontrolSistemi { get; set; }
        public bool EBD { get; set; }
        public bool ASR { get; set; }
        public bool LedGunduzFari { get; set; }
        public bool YolcuHavaYastigi { get; set; }
        public bool DizHavaYastigi { get; set; }
        public bool ABS { get; set; }
        public bool ESP { get; set; }
        public bool OnSisFarlari { get; set; }
        public bool AlasimJantlar { get; set; }
       
        public virtual CarDetail CarDetail { get; set; }
    }
}