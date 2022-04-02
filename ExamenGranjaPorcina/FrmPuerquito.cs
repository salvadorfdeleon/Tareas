using ExamenGranjaPorcina.Data;
using ExamenGranjaPorcina.Models;
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
    public partial class FrmPuerquito : Form
    {
        private int id = 0;
        public FrmPuerquito()
        {
            InitializeComponent();
        }


        private void FrmPuerquitos_Load(object sender, EventArgs e)
        {
            ListaPuerquito();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            using (var context= new ApplicationDbContext())
            {
                //crear un objeto de puerquitos
                var puerquito = new Cerdo();
                //pasar los valores de los textbos a propiedades al  objeto
                puerquito.Nombre = txtNombre.Text;
                puerquito.NumeroCorral = Convert.ToInt32(txtNumCorral.Text);
                puerquito.Peso = Convert.ToDouble(txtPeso.Text);
                puerquito.FechaIngreso = dtpFechaIngreso.Value.Date;
                puerquito.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                puerquito.Vendido = false;

               context.Cerdo.Add(puerquito);
             
                context.SaveChanges();

                ListaPuerquito();
                limparcampos();



            }
        }
        private void ListaPuerquito()
        {
            using (var context = new ApplicationDbContext())
            {
                var puerquitos = context.Cerdo.ToList();
                dgvPuerquitos.DataSource = puerquitos;

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //aqui hacemos la consulata mediandte el id en nuestos registros 
                    var puerquito = context.Cerdo.First(x => x.Id == id );
                    if(puerquito != null)
                    {
                        puerquito.Nombre = txtNombre.Text;
                        puerquito.NumeroCorral = Convert.ToInt32(txtNumCorral.Text);
                        puerquito.Peso = Convert.ToDouble(txtPeso.Text);
                        puerquito.FechaIngreso = dtpFechaIngreso.Value.Date;
                        puerquito.FechaNacimiento = dtpFechaNacimiento.Value.Date;

                        context.SaveChanges();
                        ListaPuerquito();

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if(id != 0)
                {
                    //aqui hacemos la consulata mediandte el id en nuestos registros 
                    var puerquito = context.Cerdo.First(x => x.Id == id);
                    if (puerquito != null)
                    { 

                        context.Cerdo.Remove(puerquito);   
                        context.SaveChanges();
                        ListaPuerquito();
                    }

                }
            }   

        }

        private void dgvPuerquitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvPuerquitos.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvPuerquitos.CurrentRow.Cells[1].Value.ToString();
            txtNumCorral.Text = dgvPuerquitos.CurrentRow.Cells[2].Value.ToString();
            txtPeso.Text = dgvPuerquitos.CurrentRow.Cells[3].Value.ToString();
            dtpFechaIngreso.Value = Convert.ToDateTime(dgvPuerquitos.CurrentRow.Cells[4].Value.ToString());
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvPuerquitos.CurrentRow.Cells[5].Value.ToString());


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limparcampos();


        }

        private void limparcampos()
        {
            id = 0;
            txtNombre.Text = "";
            txtNumCorral.Text = "";
            txtPeso.Text = "";
            dtpFechaIngreso.Value = Convert.ToDateTime(DateTime.Now);
            dtpFechaNacimiento.Value = Convert.ToDateTime(DateTime.Now);
        }

    }
}
