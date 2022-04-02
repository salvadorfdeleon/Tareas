using ExamenGranjaPorcina.Data;
using ExamenGranjaPorcina.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranjaPorcinaExamen
{
    public partial class FrmVenta : Form
    {
        private int id = 0;
        public FrmVenta()
        {
            InitializeComponent();
            
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            ListarVentas();
            ListaPuerquitos();

        }

       public void ListarVentas()
        {
            using (var context = new ApplicationDbContext())
            {
                
                var cerdito = context.Cerdo.Where(x => x.Vendido == true).ToList();
                dgvInfoVentas.DataSource = cerdito;
            }
            
        }

        private void ListaPuerquitos()
        {
            using (var context = new ApplicationDbContext())
            {
                
                var cerdito = context.Cerdo.Where(x => x.Vendido == false).ToList();
                dgvCerditosV.DataSource = cerdito;
            }
        }

        private void dgvInfoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarVentas();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            using(var context = new ApplicationDbContext())
            {
                var venta = new Ventas();
                venta.NomComprador = txtNomCliente.Text;
                venta.Precio = Convert.ToDouble(txtPrecio.Text);
                venta.Fecha = dtpFechaVenta.Value.Date;
                venta.CerdoId = id;
                context.Ventas.Add(venta);

                context.SaveChanges();

                if (id != 0)
                {
                    //aqui hacemos la consulata mediandte el id en nuestos registros 
                    var puerquito = context.Cerdo.First(x => x.Id == id);
                    if (puerquito != null)
                    {
                        puerquito.Vendido = true;
                        context.SaveChanges();
                        

                    }
                }
            }
            ListaPuerquitos();
            ListarVentas();

        }

       

        private void dgvCerditosV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCerditosV.CurrentRow.Cells[0].Value);

           
        }
    }
}
