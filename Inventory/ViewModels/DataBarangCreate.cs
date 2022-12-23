using InventorySekolah.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.ViewModels
{
    public class DataBarangCreate
    {
        public DataBarang DataBarang { get; set; }
        public IEnumerable<SelectListItem> Statuss { get; set; }
    }
}
