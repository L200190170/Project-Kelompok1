using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Models
{
    public class Laporan
    {
        [Key]
        public int Id { get; set; }
        public DataBarang DataBarang { get; set; }
        [ForeignKey("DataBarang")]
        public int DataBarangId { get; set; }

        public Pengadaan Pengadaan { get; set; }
        [ForeignKey("Pengadaan")]
        public int PengadaanId { get; set; }

        public Pemeliharaan Pemeliharaan { get; set; }
        [ForeignKey("Pemeliharaan")]
        public int PemeliharaanId { get; set; }
    }
}
