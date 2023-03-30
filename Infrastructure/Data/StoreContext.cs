using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
            


        }

        // <which object should be queried or saved> into table Products
        // => Set<Character>() means, this is a set of objects Character
        public DbSet<Product> Products { get; set; }


    }




}