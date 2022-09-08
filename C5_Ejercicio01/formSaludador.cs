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
    public partial class formSaludador : Form
    {
        public formSaludador(string titulo, string mensaje)
        {
            InitializeComponent();
            label_Mensaje.Text = mensaje;
            label_Titulo.Text = titulo;
        }
    }
}
