namespace ExamenGranjaPorcina
{
    partial class FrmOpciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPuerquitos = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPuerquitos
            // 
            this.btnPuerquitos.Location = new System.Drawing.Point(21, 34);
            this.btnPuerquitos.Name = "btnPuerquitos";
            this.btnPuerquitos.Size = new System.Drawing.Size(237, 176);
            this.btnPuerquitos.TabIndex = 0;
            this.btnPuerquitos.Text = "Puerquitos";
            this.btnPuerquitos.UseVisualStyleBackColor = true;
            this.btnPuerquitos.Click += new System.EventHandler(this.btnPuerquitos_Click);
            // 
            // btnVacunas
            // 
            this.btnVacunas.Location = new System.Drawing.Point(286, 34);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(237, 176);
            this.btnVacunas.TabIndex = 1;
            this.btnVacunas.Text = "Vacunas";
            this.btnVacunas.UseVisualStyleBackColor = true;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(551, 34);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(237, 176);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 232);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnVacunas);
            this.Controls.Add(this.btnPuerquitos);
            this.Name = "FrmOpciones";
            this.Text = "FrmOpciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPuerquitos;
        private Button btnVacunas;
        private Button btnVentas;
    }
}