//Krupali Patel 
//CPT 231-S14
//Assignment 7 03/13/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace M7.Models
{
    public class BtsContext:DbContext
    {
        public BtsContext(DbContextOptions<BtsContext> options) :
            base(options)
        {

        }
        public DbSet<Bts> Bts { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bts>().HasData(
               new Bts
               {
                   BtsId = 1,
                   Name = "Jimin",
                   Ratings ="9.8"
               },
               new Bts
               {
                   BtsId = 2,
                   Name = "RM",
                   Ratings = "10"
               },
               new Bts
               {
                   BtsId = 3,
                   Name = "Suga",
                   Ratings = "9"
               },
               new Bts
               {
                   BtsId = 4,
                   Name = "Jungkook",
                   Ratings = "6"
               }
                );
        }

        
    }

}
