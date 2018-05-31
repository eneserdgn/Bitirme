using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class Technology
    {
        public int ID { get; set; }
        public bool ArkaParkSensoru { get; set; }
        public bool GeriGorusKamerasi { get; set; }
        public bool HizSabitlemeSistemi { get; set; }
        public bool YağmurSensoru { get; set; }
        public bool StartStopSistemi { get; set; }
        public bool BluetoothBaglantisi { get; set; }
        public bool OtomatikKatlananYanAynalar { get; set; }
        public bool ElektronikParkFreni { get; set; }
        public bool YolBilgisayari { get; set; }
        public bool YokusKalkisDestekSistemi { get; set; }
        public bool FarSensoru { get; set; }
        public bool USBGirisi { get; set; }
        public bool NavigasyonSistemi { get; set; }
        public bool XenonOnFarlar { get; set; }
       
        public virtual CarDetail CarDetail { get; set; }
    }
}