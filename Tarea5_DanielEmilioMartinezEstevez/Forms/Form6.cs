using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form6 : Form
    {
        Tarea5_DanielEmilioMartinezEstevez.Class.Class1 uno = new Tarea5_DanielEmilioMartinezEstevez.Class.Class1();
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo Vacio debe ser llenado");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo Vacio debe ser llenado");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo Vacio debe ser llenado");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo Vacio debe ser llenado");
                textBox4.Focus();
                return;
            }

            double precio, cantidad, isv;
            precio = Convert.ToDouble(textBox3.Text);
            cantidad = Convert.ToDouble(textBox4.Text);

            isv = precio * 0.15;

            textBox8.Text = Convert.ToString(uno.factura(precio, cantidad, isv));
            textBox7.Text = Convert.ToString(isv);
            textBox6.Text = Convert.ToString(precio * cantidad);
        }
    }
}
