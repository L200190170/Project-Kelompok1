using InventorySekolah.Context;
using InventorySekolah.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Data
{
    public class PengadaanRepository
    {
        MyContext myContext;
        public PengadaanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(Pengadaan pengadaan)
        {
            myContext.Pengadaans.Remove(pengadaan);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Pengadaan> Get()
        {
            var data = myContext.Pengadaans.Include(x => x.Status).ToList();
            return data;
        }

        public Pengadaan Get(int id)
        {
            var data = myContext.Pengadaans.Include(x => x.Status).Where(x => x.Id.Equals(id)).FirstOrDefault();
            return data;
        }

        public int Post(Pengadaan pengadaan)
        {
            myContext.Pengadaans.Add(pengadaan);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(int id, Pengadaan pengadaan)
        {
            var data = myContext.Pengadaans.Find(id);
            data.TglPengajuan = pengadaan.TglPengajuan;
            data.Nama = pengadaan.Nama;
            data.Jumlah = pengadaan.Jumlah;
            data.HargaPerUnit = pengadaan.HargaPerUnit;
            data.HargaTotal = pengadaan.HargaTotal;
            data.StatusId = pengadaan.StatusId;
            myContext.Pengadaans.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
