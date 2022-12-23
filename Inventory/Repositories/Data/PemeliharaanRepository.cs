using InventorySekolah.Context;
using InventorySekolah.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Data
{
    public class PemeliharaanRepository
    {
        MyContext myContext;

        public PemeliharaanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(Pemeliharaan pemeliharaan)
        {
            myContext.Pemeliharaans.Remove(pemeliharaan);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Pemeliharaan> Get()
        {
            var data = myContext.Pemeliharaans.Include(x => x.Status).ToList();
            return data;
        }

        public Pemeliharaan Get(int id)
        {
            var data = myContext.Pemeliharaans.Include(x => x.Status).Where(x => x.Id.Equals(id)).FirstOrDefault();
            return data;
        }

        public int Post(Pemeliharaan pemeliharaan)
        {
            myContext.Pemeliharaans.Add(pemeliharaan);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(int id, Pemeliharaan pemeliharaan)
        {
            var data = myContext.Pemeliharaans.Find(id);
            data.Nama = pemeliharaan.Nama;
            data.Kerusakan = pemeliharaan.Kerusakan;
            data.Biaya = pemeliharaan.Biaya;
            data.TglPengajuan = pemeliharaan.TglPengajuan;
            data.StatusId = pemeliharaan.StatusId;
            myContext.Pemeliharaans.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
