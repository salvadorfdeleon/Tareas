using ExamenGranjaPorcina.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGranjaPorcina.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilider)
        {
            /*Crear  coneccion a base de datos
             *Host= localhost = 127.0.0.1
             *Database= GranjaPorcina
             *Username=postgres
             *Password=....
             */

            optionsBuilider.UseNpgsql("Host=localhost;Database=GPorcina;Username=postgres;password=Flores85");
            base.OnConfiguring(optionsBuilider);
        }

        public DbSet<Cerdo> Cerdo { get; set; }

        public DbSet<Vacunas> Vacunas { get; set;}

        public DbSet<Ventas> Ventas { get; set; }   


    }
}
