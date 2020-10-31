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
    public partial class Form4 : Form
    {
        Tarea5_DanielEmilioMartinezEstevez.Class.Class1 fal = new Tarea5_DanielEmilioMartinezEstevez.Class.Class1();
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox5.Focus();
                return;
            }

            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox3.Focus();
                return;
            }

            

            double n1, n2, n3;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);

            if (n1 > 20 || n1 < 0)
            {
                MessageBox.Show("Error la calificacion no es valida");
                textBox1.Focus();
                return;
            }

            if (n2 > 20 || n2 < 0)
            {
                MessageBox.Show("Error la calificacion no es valida");
                textBox2.Focus();
                return;
            }

            if (n3 > 20 || n3 < 0)
            {
                MessageBox.Show("Error la calificacion no es valida");
                textBox3.Focus();
                return;
            }

            textBox4.Text = Convert.ToString(fal.faltante(n1, n2, n3));

            dataGridView1.Rows.Add(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
