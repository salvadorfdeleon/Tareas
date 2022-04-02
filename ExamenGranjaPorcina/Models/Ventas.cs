using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGranjaPorcina.Models
{
    internal class Ventas
    {
        public int Id { get; set; }
        public string NomComprador { get; set; }
        public double Precio { get; set; }

        [Column(TypeName="Date")]
        public DateTime Fecha { get; set; }
        public int CerdoId { get; set; }
        public Cerdo Cerdo { get; set; }

    }
}
