using InventorySekolah.Context;
using InventorySekolah.Models;
using InventorySekolah.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Data
{
    public class DataBarangRepository
    {
        MyContext myContext;
        public DataBarangRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public List<SelectListItem> Statuss { get; internal set; }

        public int Delete(DataBarang dataBarang)
        {
            myContext.DataBarangs.Remove(dataBarang);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<DataBarang> Get()
        {
            var data = myContext.DataBarangs.Include(x => x.Status).ToList();
            return data;
        }

        public DataBarang Get(int id)
        {
            var data = myContext.DataBarangs.Include(x => x.Status).Where(x => x.Id.Equals(id)).FirstOrDefault();
            return data;
        }

        public int Post(DataBarang dataBarang)
        {
            /*DataBarangCreate dataBarangCreate = new DataBarangCreate();
            dataBarangCreate.DataBarang = new DataBarang();
            List<SelectListItem> statuss = myContext.Statuss
                .OrderBy(n => n.StatusBarang)
                    .Select(n =>
                    new SelectListItem
                    {
                        Text = n.StatusBarang
                    }).ToList();*/
            myContext.DataBarangs.Add(dataBarang);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Put(int id, DataBarang dataBarang)
        {
            var data = myContext.DataBarangs.Find(id);
            data.TglMasuk = dataBarang.TglMasuk;
            data.Nama = dataBarang.Nama;
            data.Kode = dataBarang.Kode;
            data.Stok = dataBarang.Stok;
            data.StatusId = dataBarang.StatusId;
            myContext.DataBarangs.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
