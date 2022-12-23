using InventorySekolah.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Controllers
{
    public class StatusController : Controller
    {
        MyContext myContext;

        public StatusController(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public IActionResult Index()
        {
            var data = myContext.Statuss.ToList();
            return View(data);
        }
    }
}
