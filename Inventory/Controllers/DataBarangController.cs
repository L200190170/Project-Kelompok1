using InventorySekolah.Models;
using InventorySekolah.Repositories.Data;
using InventorySekolah.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Controllers
{
    public class DataBarangController : Controller
    {
        DataBarangRepository DataBarangRepository;
        public DataBarangController(DataBarangRepository DataBarangRepository)
        {
            this.DataBarangRepository = DataBarangRepository;
        }

        /*[HttpGet]*/
        public IActionResult Index()
        {

                var data = DataBarangRepository.Get();                
                return View(data);

        }

        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DataBarang dataBarang)
        {
            if (ModelState.IsValid)
            {
                var result = DataBarangRepository.Post(dataBarang);
                if (result > 0)
                    return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = DataBarangRepository.Get(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, DataBarang dataBarang)
        {
            if (ModelState.IsValid)
            {
                var result = DataBarangRepository.Put(id, dataBarang);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var data = DataBarangRepository.Get(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(DataBarang dataBarang)
        {
            if (ModelState.IsValid)
            {
                var result = DataBarangRepository.Delete(dataBarang);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }
    }
}
