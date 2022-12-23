using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Models
{
    public class Pengadaan
    {
        [Key]
        public int Id { get; set; }
        public DateTime TglPengajuan { get; set; }
        public string Nama { get; set; }
        public int Jumlah { get; set; }
        public string HargaPerUnit { get; set; }
        public string HargaTotal { get; set; }
        public Status Status { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
    }
}
