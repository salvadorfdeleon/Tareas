namespace GranjaPorcinaExamen
{
    partial class FrmVacuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCerdito = new System.Windows.Forms.TextBox();
            this.dtpFechaVacuna = new System.Windows.Forms.DateTimePicker();
            this.dgvCerditos = new System.Windows.Forms.DataGridView();
            this.btnVacunar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVacunas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCerdito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacuna";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // txtNomCerdito
            // 
            this.txtNomCerdito.Enabled = false;
            this.txtNomCerdito.Location = new System.Drawing.Point(221, 102);
            this.txtNomCerdito.Name = "txtNomCerdito";
            this.txtNomCerdito.Size = new System.Drawing.Size(274, 27);
            this.txtNomCerdito.TabIndex = 2;
            this.txtNomCerdito.TextChanged += new System.EventHandler(this.txtNomPuerquito_TextChanged);
            // 
            // dtpFechaVacuna
            // 
            this.dtpFechaVacuna.Location = new System.Drawing.Point(579, 20);
            this.dtpFechaVacuna.Name = "dtpFechaVacuna";
            this.dtpFechaVacuna.Size = new System.Drawing.Size(294, 27);
            this.dtpFechaVacuna.TabIndex = 3;
            // 
            // dgvCerditos
            // 
            this.dgvCerditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerditos.Location = new System.Drawing.Point(26, 199);
            this.dgvCerditos.Name = "dgvCerditos";
            this.dgvCerditos.RowHeadersWidth = 51;
            this.dgvCerditos.RowTemplate.Height = 29;
            this.dgvCerditos.Size = new System.Drawing.Size(847, 195);
            this.dgvCerditos.TabIndex = 4;
            this.dgvCerditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVPuerquitos_CellContentClick);
            // 
            // btnVacunar
            // 
            this.btnVacunar.Location = new System.Drawing.Point(402, 145);
            this.btnVacunar.Name = "btnVacunar";
            this.btnVacunar.Size = new System.Drawing.Size(144, 48);
            this.btnVacunar.TabIndex = 5;
            this.btnVacunar.Text = "Vacunar";
            this.btnVacunar.UseVisualStyleBackColor = true;
            this.btnVacunar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(561, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 48);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(729, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 48);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Location = new System.Drawing.Point(26, 420);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.RowHeadersWidth = 51;
            this.dgvVacunas.RowTemplate.Height = 29;
            this.dgvVacunas.Size = new System.Drawing.Size(847, 180);
            this.dgvVacunas.TabIndex = 8;
            this.dgvVacunas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacunas_CellContentClick_1);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(26, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puerquitos Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vacunados";
            // 
            // cmbVacunas
            // 
            this.cmbVacunas.FormattingEnabled = true;
            this.cmbVacunas.Items.AddRange(new object[] {
            "Rabia",
            "Parvovirus",
            "Covid",
            "Pueco loco",
            "Salmonela"});
            this.cmbVacunas.Location = new System.Drawing.Point(221, 19);
            this.cmbVacunas.Name = "cmbVacunas";
            this.cmbVacunas.Size = new System.Drawing.Size(274, 28);
            this.cmbVacunas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de Puerquito";
            // 
            // txtIdCerdito
            // 
            this.txtIdCerdito.Enabled = false;
            this.txtIdCerdito.Location = new System.Drawing.Point(221, 62);
            this.txtIdCerdito.Name = "txtIdCerdito";
            this.txtIdCerdito.Size = new System.Drawing.Size(37, 27);
            this.txtIdCerdito.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Puerquito";
            // 
            // FrmVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdCerdito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVacunas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVacunas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVacunar);
            this.Controls.Add(this.dgvCerditos);
            this.Controls.Add(this.dtpFechaVacuna);
            this.Controls.Add(this.txtNomCerdito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVacuna";
            this.Text = "FrmVacuna";
            this.Load += new System.EventHandler(this.FrmVacunacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomCerdito;
        private DateTimePicker dtpFechaVacuna;
        private DataGridView dgvCerditos;
        private Button btnVacunar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvVacunas;
        private Label label3;
        private Label label4;
        private ComboBox cmbVacunas;
        private Label label5;
        private TextBox txtIdCerdito;
        private Label label6;
    }
}