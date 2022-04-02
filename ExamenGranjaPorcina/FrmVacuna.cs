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
    public partial class FrmVacuna : Form
    {
        private int vacunaid = 0;
        private int cerditoid = 0;
        public FrmVacuna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (vacunaid != 0)
                {
                    var vacuna = context.Vacunas.First(x => x.Id == vacunaid);
                    if (vacuna != null)
                    {
                        //vacuna.Vacuna = txtNomCerdito.Text;
                        vacuna.Vacuna = cmbVacunas.Text;

                        vacuna.Fecha = dtpFechaVacuna.Value.Date;


                        context.SaveChanges();
                        ListaVacunas();

                    }
                }
            }


        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (cerditoid != 0)
                {
                    //crear un objeto de puerquitos
                    var vacuna = new Vacunas();
                    //pasar los valores de los textbos a propiedades al  objeto

                    vacuna.Vacuna = cmbVacunas.Text;
                    vacuna.Fecha = dtpFechaVacuna.Value.Date;
                    vacuna.CerdoId = cerditoid;



                    context.Vacunas.Add(vacuna);
                    context.SaveChanges();

                    //ListaVacunas();
                    LimpiarCampos();
                }

            }
        }

        private void FrmVacunacion_Load(object sender, EventArgs e)
        {
            ListaPuerquitos();
            // ListaVacunas();
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (var context = new ApplicationDbContext())
            {
                if (vacunaid != 0)
                {
                    //aqui hacemos la consulata mediandte el id en nuestos registros 
                    var vacuna = context.Vacunas.First(x => x.Id == vacunaid);
                    if (vacuna != null)
                    {

                        context.Vacunas.Remove(vacuna);
                        context.SaveChanges();
                        ListaVacunas();
                        
                    }

                }
            }
            vacunasacual();
        }
        private void ListaPuerquitos()
        {
            using (var context = new ApplicationDbContext())
            {
                var Cerdito = context.Cerdo.ToList();
                dgvCerditos.DataSource = Cerdito;
            }
        }

        private void ListaVacunas()
        {
            using (var context = new ApplicationDbContext())
            {
                var vacuna = context.Vacunas.ToList();
                dgvVacunas.DataSource = vacuna;
            }
        }
        private void LimpiarCampos()
        {
            cerditoid = 0;
            cmbVacunas.Text = "";
            dtpFechaVacuna.Value = Convert.ToDateTime(DateTime.Now);

        }
        private void dgvVacunas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vacunasacual();
            /*vacunaid = Convert.ToInt32(dgvVacunas.CurrentRow.Cells[0].Value);
            cmbVacunas.Text = dgvVacunas.CurrentRow.Cells[1].Value.ToString();
            dtpFechaVacuna.Value = Convert.ToDateTime(dgvVacunas.CurrentRow.Cells[2].Value.ToString());*/


        }
        public void vacunasacual()
        {
            vacunaid = Convert.ToInt32(dgvVacunas.CurrentRow.Cells[0].Value);
            cmbVacunas.Text = dgvVacunas.CurrentRow.Cells[1].Value.ToString();
            dtpFechaVacuna.Value = Convert.ToDateTime(dgvVacunas.CurrentRow.Cells[2].Value.ToString());

        }


        private void txtNomPuerquito_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVPuerquitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             cerditoid = Convert.ToInt32(dgvCerditos.CurrentRow.Cells[0].Value);
             txtIdCerdito.Text = cerditoid.ToString();
             txtNomCerdito.Text = dgvCerditos.CurrentRow.Cells[1].Value.ToString();

               using (var context = new ApplicationDbContext())
               {
                  var vacunas = context.Vacunas.Include(x => x.Cerdo).Where(x => x.CerdoId == cerditoid).ToList();
                  dgvVacunas.DataSource = vacunas;
               }
        }

    }
}
    

