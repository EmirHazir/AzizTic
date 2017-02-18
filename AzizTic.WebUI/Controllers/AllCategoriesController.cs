using AzizTic.Services.Abstract;
using AzizTic.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzizTic.WebUI.Controllers
{
    public class AllCategoriesController : Controller
    {
        //private IKategoriService _kategoriService;
        //public AllCategoriesController(IKategoriService kategoriService)
        //{
        //    _kategoriService = kategoriService;
        //}
        public ActionResult Index()
        {
            //KategoriVM model = new KategoriVM
            //{
            //    Kategorilers = _kategoriService.GetAll()
            //};
            return View();//modeli basıcam ama önyüzde patlıyor 
        }
    }
}