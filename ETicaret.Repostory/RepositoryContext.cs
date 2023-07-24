using ETicaret.Api;
using ETicaret.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base (options) 
            {
            }
        public DbSet <Kategori> Kategoriler { get; set; }
        public DbSet <Rol> Roller { get; set; }
        public DbSet <Kullanici> Kullanicilar { get; set; }
    }
    
}


