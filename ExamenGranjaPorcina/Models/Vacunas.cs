using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGranjaPorcina.Models
{
    internal class Vacunas

    { 
        public int Id { get; set; }
    public string Vacuna { get; set; }
    

    [Column(TypeName="Date")]
    public DateTime Fecha { get; set; }
        //Relacion de cerdo a muchas vacunas
    public int CerdoId { get; set; }
    public Cerdo Cerdo { get; set; }

    }
}
