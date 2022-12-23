using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Models
{
    public class DataBarang
    {
        [Key]
        public int Id { get; set; }
        public DateTime TglMasuk { get; set; }
        public string Nama { get; set; }
        public string Kode { get; set; }
        public int Stok { get; set; }
        public Status Status { get; set; }
        [ForeignKey("Status")]
        [DisplayName("Status")]
        public int StatusId { get; set; }
    }
}
