using System.Collections.Generic;
using AzizTic.Entities.Concrete;

namespace AzizTic.WebUI.Areas.Admin.AVievModels
{
    public class UrunAddVM
    {
        public List<Kategoriler> Kategoriler { get; set; }
        public Urunler Urun { get; set; }
    }
}