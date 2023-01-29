using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, n1, n2, n3, promedio;

            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
                nota2 = Convert.ToDouble(txtNota2.Text);
                nota3 = Convert.ToDouble(txtNota3.Text);

            
                n1 = nota1 * 0.30;
                n2 = nota2 * 0.30;
                n3 = nota3 * 0.40;

                promedio = n1 + n2 + n3;

                txtPromedio.Text = promedio.ToString();


                if (promedio == 10)
                {
                    txtBeca.Text = "Tiene el 50% de la BECA";
                }
                else
                {
                    if (promedio >= 9.0 && promedio <= 9.9)
                    {
                        txtBeca.Text = "Tiene el 30% de la BECA";
                    }
                    else
                    {
                        if (promedio >= 8.0 && promedio <= 8.9)
                        {
                            txtBeca.Text = "Tiene el 10% de la BECA";
                        }
                        else
                        {
                            if (promedio <= 7.0)
                            {
                                txtBeca.Text = "Esta reprobado, no tiene BECA";
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Porfavor ingresa un numero del 0 - 10",ex.Message);
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBeca.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
