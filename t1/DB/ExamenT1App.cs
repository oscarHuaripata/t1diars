using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t1.DB.Maps;
using t1.Models;

namespace t1.DB
{
    public class ExamenT1App :DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ciudad> Ciudads { get; set; }



        public ExamenT1App(DbContextOptions<ExamenT1App> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MapPersona());
            modelBuilder.ApplyConfiguration(new MapCiudad());
        }
    }
}
