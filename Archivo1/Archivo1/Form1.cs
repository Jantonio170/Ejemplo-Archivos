using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo1
{
    public partial class Form1 : Form
    {
        Stack pila = new Stack();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(textBox1.Text);
            textBox1.Clear();
            letras();
        }

        public void letras()
        {
            string[] array2 = new string[pila.Count];
            pila.CopyTo(array2, 0);
            string let = "";
            for (int i=0; i<pila.Count; i++)
            {
                let = let + array2[i];
                label1.Text = let;
            }
        }
    }
}
