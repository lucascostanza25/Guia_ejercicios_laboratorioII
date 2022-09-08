using Entidades_C5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio02
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void button_Ingresar_Click(object sender, EventArgs e)
        {
            string genero = "";
            string[] arrayMaterias = new string[3];

            if (checkBox_Cplus.Checked == true) arrayMaterias[0] = checkBox_Cplus.Text;
            if (checkBox_Csharp.Checked == true) arrayMaterias[1] = checkBox_Csharp.Text;
            if (checkBox_JavaS.Checked == true) arrayMaterias[2] = checkBox_JavaS.Text;

            if (radioButton_Masc.Checked == true) genero = radioButton_Masc.Text;
            if (radioButton_Fem.Checked == true) genero = radioButton_Fem.Text;
            if (radioButton_Nb.Checked == true) genero = radioButton_Nb.Text;

            Ingresante miIngresante = new Ingresante(textBox_Nombre.Text,
                textBox_Direccion.Text, genero, listBox_Pais.Text, arrayMaterias, (int)numericUpDown_Edad.Value);

            MessageBox.Show(miIngresante.Mostrar());
        }
    }
}
