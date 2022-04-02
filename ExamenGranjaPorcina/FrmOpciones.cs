using GranjaPorcinaExamen;

namespace ExamenGranjaPorcina
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmVenta frmVentas = new FrmVenta();
            frmVentas.Show();
        }

        private void btnPuerquitos_Click(object sender, EventArgs e)
        {
            FrmPuerquito frmpuerquitos = new FrmPuerquito();
            frmpuerquitos.Show();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            FrmVacuna frmvacunas = new FrmVacuna();
            frmvacunas.Show();
        }
    }
}