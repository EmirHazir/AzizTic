using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzizTic.WebUI.ViewModels
{
    public enum OdemeTipleri
    {
        visa,
        master,

    }

    public class OdemelerVM
    {
        public List<Odemeler> Odemelers { get; set; }
    }
}