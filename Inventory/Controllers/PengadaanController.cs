using InventorySekolah.Context;
using InventorySekolah.Models;
using InventorySekolah.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Controllers
{
    public class PengadaanController : Controller
    {
        PengadaanRepository PengadaanRepository;

        public PengadaanController(PengadaanRepository PengadaanRepository)
        {
            this.PengadaanRepository = PengadaanRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = PengadaanRepository.Get();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pengadaan pengadaan)
        {
            if (ModelState.IsValid)
            {
                var result = PengadaanRepository.Post(pengadaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = PengadaanRepository.Get(id);
            return View(data);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Pengadaan pengadaan)
        {
            if (ModelState.IsValid)
            {
                var result = PengadaanRepository.Put(id, pengadaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var data = PengadaanRepository.Get(id);
            return View(data);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Pengadaan pengadaan)
        {
            if (ModelState.IsValid)
            {
                var result = PengadaanRepository.Delete(pengadaan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }
    }
}
