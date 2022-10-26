using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6_Ejercicio03
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        private List<string> myList = new List<string>();
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            myList.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string palabra in myList)
            {
                if (!myDictionary.ContainsKey(palabra) && palabra != " ")
                {
                    myDictionary.Add(palabra, 1);
                }
                else
                {
                    myDictionary[palabra] += 1;
                }
            }

            MessageBox.Show(Mostrar());
        }
        
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in myDictionary)
                {
                    if (myDictionary.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (myDictionary.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }
    }
}
