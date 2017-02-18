using System.Collections.Generic;
using AzizTic.Entities.Concrete;

namespace AzizTic.WebUI.Areas.Admin.AVievModels
{
    public class UrunUpdateVM
    {
        public List<Kategoriler> Kategori { get; set; }
        public Urunler Urun { get; set; }
    }
}