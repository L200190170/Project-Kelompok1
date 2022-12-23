using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Models
{
    public class Pemeliharaan
    {
        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Kerusakan { get; set; }
        public string Biaya { get; set; }
        public DateTime TglPengajuan { get; set; }
        public Status Status { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
    }
}
