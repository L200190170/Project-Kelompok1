using InventorySekolah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Repositories.Interface
{
    interface IPemeliharaanRepository
    {
        List<Pemeliharaan> Get();
        //GET BY ID
        Pemeliharaan Get(int id);
        //POST
        int Post(Pemeliharaan dataBarang);
        //PUT
        int Put(int id, Pemeliharaan pemeliharaan);
        //DELETE
        int Delete(Pemeliharaan pemeliharaan);
    }
}
