using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Di_Tema5_Ejer6_VengaDeEstaSi
{
    public enum Modo
    {
        BARRAS,
        LINEAS
    }
    public partial class Grafico : Control
    {
        int[] valores = { 0, 0, 0 };

        string ejeY;

        public string EjeY
        {
            set
            {
                this.ejeY = value;
                this.Refresh();
            }
            get
            {
                return ejeY;
            }
        }
        string ejeX;

        public string EjeX
        {
            set
            {
                this.ejeX = value;
                this.Refresh();
            }
            get
            {
                return ejeX;
            }
        }
        private bool automatico;

        public bool Automatico
        {
            set
            {
                this.automatico = value;
                
                this.Refresh();
            }
            get
            {
                return this.automatico;
            }
        }
        Modo m = Modo.BARRAS;

        public Modo M
        {
            get
            {
                return m;
            }
            set
            {
                this.m = value;
                this.Refresh();
            }
        }
        string nombreA;
        
        public string NombreA
        {
            set
            {
                this.nombreA = value;
                this.Refresh();
            }
            get
            {
                return nombreA;
            }
        }

        string nombreB;
        public string NombreB
        {
            set
            {
                this.nombreB = value;
                this.Refresh();
            }
            get
            {
                return nombreB;
            }
        }

        string nombreC;
        public string NombreC
        {
            set
            {
                this.nombreC = value;
                
                this.Refresh();
            }
            get
            {
                return nombreC;
            }
        }


        public int PorcentajeA
        {
            set
            {
                valores[0] = value;
                this.Refresh();
            }
            get
            {
                return valores[0];
            }
        }
        public int PorcentajeB
        {
            set
            {
                valores[1] = value;
                this.Refresh();
            }
            get
            {
                return valores[1];
            }
        }

        public int PorcentajeC
        {
            set
            {
                valores[2] = value;
                this.Refresh();
            }
            get
            {
                return valores[2];
            }
        }
        int valorMaximo;
        public int ValorMaximo
        {
            set
            {
                valorMaximo = value;
                this.Refresh();
            }
            get
            {
                return valorMaximo;
            }
        }
        public Grafico()
        {
            InitializeComponent();
            this.ValorMaximo = 200;
            this.nombreA = "";
            this.nombreB = "";
            this.nombreC = "";
            this.ejeY = "";
            this.ejeX = "";
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (automatico)
            {
                int aux = 0;
                for(int i = 0; i < valores.Length; i++)
                {
                    if(valores[i] > aux)
                    {
                        aux = valores[i];
                    }
                }
                valorMaximo = aux;
            }
            Pen p;
            Graphics g = pe.Graphics;
            p = new Pen(Color.Black);

            g.DrawLine(p, new Point(50, 0), new Point(50, 300));
            g.DrawLine(p, new Point(50, 300), new Point(450, 300));
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(p, new Point(45, i * 30), new Point(55, i * 30));
                if (valorMaximo > 0)
                    g.DrawString("" + ((float)ValorMaximo / 10) * (10 - i), this.Font, Brushes.Black, new PointF(10, i * 30));
            }

            g.DrawLine(p, new Point(150, 305), new Point(150, 295));
            g.DrawString(nombreA, this.Font, Brushes.Black, new PointF(150, 310));
            g.DrawLine(p, new Point(250, 305), new Point(250, 295));
            g.DrawString(nombreB, this.Font, Brushes.Black, new PointF(250, 310));
            g.DrawLine(p, new Point(350, 305), new Point(350, 295));
            g.DrawString(nombreC, this.Font, Brushes.Black, new PointF(350, 310));

            for (int i = 0; i < ejeY.Length; i++)
            {
                g.TranslateTransform(30, 100 + (ejeY.Length - i) * 10);
                g.RotateTransform(270);
                g.DrawString(ejeY[i] + "", this.Font, Brushes.Black,new PointF(0,0));
                g.ResetTransform();
            }
            g.DrawString(ejeX, this.Font, Brushes.Black, new PointF(230, 340));
            if (m == Modo.BARRAS)
            {
                p = new Pen(Color.Blue, 80);
                if (valores[0] > valorMaximo)
                    p = new Pen(Color.Red, 80);
                g.DrawLine(p, new Point(150, 300), new Point(150, 300 - (300 * valores[0] / valorMaximo)));

                p = new Pen(Color.Green, 80);
                if (valores[1] > valorMaximo)
                    p = new Pen(Color.Red, 80);
                g.DrawLine(p, new Point(250, 300), new Point(250, 300 - (300 * valores[1] / valorMaximo)));

                p = new Pen(Color.Yellow, 80);
                if (valores[2] > valorMaximo)
                    p = new Pen(Color.Red, 80);
                g.DrawLine(p, new Point(350, 300), new Point(350, 300 - (300 * valores[2] / valorMaximo)));
            }
            else
            {
                if(m == Modo.LINEAS)
                {
                    p = new Pen(this.ForeColor, 2);
                    g.DrawLine(p, new Point(50, 300), new Point(150, 300 - (300 * valores[0] / valorMaximo)));
                    g.DrawLine(p, new Point(150, 300 - (300 * valores[0] / valorMaximo)), new Point(250, 300 - (300 * valores[1] / valorMaximo)));
                    g.DrawLine(p, new Point(250, 300 - (300 * valores[1]/ valorMaximo)), new Point(350, 300 - (300 * valores[2] / valorMaximo)));
                    
                }
            }

        }
    }
}
