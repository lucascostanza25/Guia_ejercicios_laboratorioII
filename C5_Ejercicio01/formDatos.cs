using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio01
{
    public partial class formDatos : Form
    {
        public formDatos()
        {
            InitializeComponent();
        }

        private void formDatos_Load(object sender, EventArgs e)
        {
            comboBox_Materia.Items.Add("Programacion II");
            comboBox_Materia.Items.Add("Estadistica");
            comboBox_Materia.Items.Add("Legislacion");
        }

        private void button_Saludar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_Apellido.Text) && string.IsNullOrEmpty(textBox_Nombre.Text) && !string.IsNullOrEmpty(comboBox_Materia.Text)) //No ingreso nombre
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n - Nombre", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(textBox_Apellido.Text) && !string.IsNullOrEmpty(textBox_Nombre.Text) && !string.IsNullOrEmpty(comboBox_Materia.Text)) //No ingreso apellido
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n - Apellido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(textBox_Apellido.Text) && string.IsNullOrEmpty(textBox_Nombre.Text) && string.IsNullOrEmpty(comboBox_Materia.Text)) //No ingreso nada
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n - Apellido \n - Nombre \n - Materia", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!string.IsNullOrEmpty(textBox_Apellido.Text) && !string.IsNullOrEmpty(textBox_Nombre.Text) && !string.IsNullOrEmpty(comboBox_Materia.Text)) //Ingreso todo
            {
                string titulo = "¡Hola Windows Forms!";
                string mensaje = $"Soy {textBox_Nombre.Text} {textBox_Apellido.Text} y mi materia favorita es {comboBox_Materia.Text}!";

                formSaludador miForm = new formSaludador(titulo, mensaje);
                miForm.ShowDialog();
            }
        }
        /*
        public bool Validar()
        {
            bool estado = false;

            if (!string.IsNullOrEmpty(textBox_Apellido.Text) && !string.IsNullOrEmpty(textBox_Nombre.Text) && !string.IsNullOrEmpty(comboBox_Materia.Text))
            {
                estado = true;
            }

            return estado;
        }*/
    }
}
