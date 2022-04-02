using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGranjaPorcina.Models
{
    internal class Cerdo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroCorral { get; set; }
        public double Peso { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaIngreso { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaNacimiento { get; set; }

        public bool Vendido { get; set; }

        public ICollection<Vacunas> Vacunas { get; set;}
        public ICollection<Ventas> Ventas { get; set; }






    }

}
