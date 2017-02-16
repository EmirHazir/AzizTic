using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzizTic.WebUI.ViewModels
{
    public enum KullaniciTip
    {
        admin,
        editor,
        member,
        guest
    }

    public class KullanicilarVM
    {
        public List<Kullanicilar> Kullanicilars { get; set; }
    }
}