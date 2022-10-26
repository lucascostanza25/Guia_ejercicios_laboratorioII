using Entidades_C10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10_Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtKilometros.Text) && string.IsNullOrEmpty(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Los campos de kilometros y litros están vacíos");
                }
                rtbCalculador.Text = $"{Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text))}";
            }
            catch(ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException)
            {
                MessageBox.Show("El formato que ingresó en los campos no corresponde a enteros");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
        }
    }
}
