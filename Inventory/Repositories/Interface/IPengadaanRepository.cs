using InventorySekolah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Interface
{
    public interface IPengadaanRepository
    {
        List<Pengadaan> Get();
        Pengadaan Get(int id);
        int Post(Pengadaan pengadaan);
        int Put(int id, Pengadaan pengadaan);
        int Delete(Pengadaan pengadaan);
    }
}
