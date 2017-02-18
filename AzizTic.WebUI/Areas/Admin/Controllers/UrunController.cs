using AzizTic.Entities.Concrete;
using AzizTic.Services.Abstract;
using AzizTic.WebUI.Areas.Admin.AVievModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzizTic.WebUI.Areas.Admin.Controllers
{
    public class UrunController : Controller
    {
        private IUrunlerService _urunService;
        private IKategoriService _kategoriService;
        public UrunController(IUrunlerService urunService, IKategoriService kategoriService)
        {
            _urunService = urunService;
            _kategoriService = kategoriService;
        }


        // GET: Admin/Urun
        public ActionResult Index()
        {
            var urunVM = new UrunVM
            {
                Urunlers = _urunService.GetAll()
            };
            return View(urunVM);
        }

        public ActionResult Insert()
        {
            var model = new UrunAddVM
            {
                Urun = new Urunler(),
                Kategoriler = _kategoriService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Insert(Urunler urun)
        {
            if (ModelState.IsValid)
            {
                _urunService.Add(urun);
                TempData.Add("mesaj","Ürün başarıyla eklendi");
            }
            return View("Insert");
        }

        public ActionResult Update(int urunid)
        {
            var model = new UrunUpdateVM
            {
                Urun = _urunService.GetByUrunId(urunid),
                Kategori = _kategoriService.GetAll(),
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Urunler urun)
        {
            if (ModelState.IsValid)
            {
                _urunService.Add(urun);
                TempData.Add("mesaj", "Ürün başarıyla güncellendi");

            }

            return RedirectToAction("Update");
        }

        public ActionResult Delete(int id)
        {
            _urunService.Delete(id);
            TempData.Add("mesaj", "Ürün başarıyla silindi");
            return View("Index");
        }

    }
}