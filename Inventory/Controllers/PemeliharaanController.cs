using InventorySekolah.Models;
using InventorySekolah.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Controllers
{
    public class PemeliharaanController : Controller
    {
        PemeliharaanRepository PemeliharaanRepository;
        public PemeliharaanController(PemeliharaanRepository PemeliharaanRepository)
        {
            this.PemeliharaanRepository = PemeliharaanRepository;
        }
        public IActionResult Index()
        {
            var data = PemeliharaanRepository.Get();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pemeliharaan pemeliharaan)
        {
            if (ModelState.IsValid)
            {
                var result = PemeliharaanRepository.Post(pemeliharaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var data = PemeliharaanRepository.Get(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Pemeliharaan pemeliharaan)
        {
            if (ModelState.IsValid)
            {
                var result = PemeliharaanRepository.Put(id, pemeliharaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(Pemeliharaan pemeliharaan)
        {
            if (ModelState.IsValid)
            {
                //myContext.Pemeliharaans.Remove(pemeliharaan);
                var result = PemeliharaanRepository.Delete(pemeliharaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

    }
}
