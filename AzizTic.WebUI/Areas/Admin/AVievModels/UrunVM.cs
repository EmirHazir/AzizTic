using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzizTic.WebUI.Areas.Admin.AVievModels
{
    public class UrunVM
    {
        public List<Urunler> Urunlers { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokAdeti { get; set; }
        public int KategoriId { get; set; }
    }
}