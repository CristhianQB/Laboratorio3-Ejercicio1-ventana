using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3_Ejercicio1_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fruta = int.Parse(txtb1.Text);
            int cantidad = int.Parse(txtb2.Text);
            int distancia = int.Parse(txtb3.Text);

            switch (fruta)
            {
                case 0:
                    if (distancia < 30)
                    {
                        int total = 2 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else
                    {
                        int total = 4 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

                case 1:
                    if (distancia < 30)
                    {
                        int total = 6 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else
                    {
                        int total = 9 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

                case 2:
                    if (distancia < 30)
                    {
                        int total =3 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else
                    {
                        int total = 5 * cantidad * distancia;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

            }
        }
    }
}
