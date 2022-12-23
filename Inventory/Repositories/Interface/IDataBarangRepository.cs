using InventorySekolah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Interface
{
    public interface IDataBarangRepository
    {
        List<DataBarang> Get();
        DataBarang Get(int id);
        int Post(DataBarang dataBarang);
        int Put(int id, DataBarang dataBarang);
        int Delete(DataBarang dataBarang);
    }
}
