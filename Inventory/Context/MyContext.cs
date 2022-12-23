using InventorySekolah.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySekolah.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Pengadaan> Pengadaans { get; set; }
        public DbSet<Pemeliharaan> Pemeliharaans { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<DataBarang> DataBarangs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Laporan> Laporans { get; set; }

    }
}
