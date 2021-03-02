namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grafico1 = new Di_Tema5_Ejer6_VengaDeEstaSi.Grafico();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            this.grafico1.Automatico = true;
            this.grafico1.EjeX = "Cosas";
            this.grafico1.EjeY = "Cosas";
            this.grafico1.Location = new System.Drawing.Point(67, 12);
            this.grafico1.M = Di_Tema5_Ejer6_VengaDeEstaSi.Modo.LINEAS;
            this.grafico1.Name = "grafico1";
            this.grafico1.NombreA = "Algo1";
            this.grafico1.NombreB = "Algo2";
            this.grafico1.NombreC = "Algo3";
            this.grafico1.PorcentajeA = 20;
            this.grafico1.PorcentajeB = 32;
            this.grafico1.PorcentajeC = 40;
            this.grafico1.Size = new System.Drawing.Size(453, 374);
            this.grafico1.TabIndex = 0;
            this.grafico1.Text = "grafico1";
            this.grafico1.ValorMaximo = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grafico1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Di_Tema5_Ejer6_VengaDeEstaSi.Grafico grafico1;
    }
}

