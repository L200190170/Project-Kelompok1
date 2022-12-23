using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string StatusBarang { get; set; }
    }
}
