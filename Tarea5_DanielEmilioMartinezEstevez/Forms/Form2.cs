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
    public partial class Form2 : Form
    {
        Tarea5_DanielEmilioMartinezEstevez.Class.Class1 porcentaje = new Tarea5_DanielEmilioMartinezEstevez.Class.Class1();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double preciov, precioc;
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox1.Focus();
                return;
            }

            if(textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox2.Focus();
                return;
            }

            preciov = Convert.ToDouble(textBox1.Text);
            precioc = Convert.ToDouble(textBox2.Text);

           textBox3.Text = Convert.ToString (porcentaje.porcentaje(preciov, precioc));

        }
    }
}
