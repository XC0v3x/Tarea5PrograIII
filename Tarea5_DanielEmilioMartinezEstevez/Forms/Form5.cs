using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form5 : Form
    {
        Tarea5_DanielEmilioMartinezEstevez.Class.Class1 pro = new Tarea5_DanielEmilioMartinezEstevez.Class.Class1();
        double contador = 0, aprobados = 0, reprobados = 0, cant = 0, promG = 0, promT;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo esta vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo esta vacio");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo esta vacio");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo esta vacio");
                textBox4.Focus();
                return;
            }

            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo esta vacio");
                textBox5.Focus();
                return;
            }

            double n1, n2, n3, n4;

            n1 = Convert.ToDouble(textBox2.Text);
            n2 = Convert.ToDouble(textBox3.Text);
            n3 = Convert.ToDouble(textBox4.Text);
            n4 = Convert.ToDouble(textBox5.Text);

            cant = pro.promedio(n1, n2, n3, n4);

            if(cant >= 65)
            {
                aprobados++;
                contador++;
            }
            else
            {
                reprobados++;
                contador++;
            }

            promG = cant + promG;
            promT = promG / contador;

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToString(cant));
            textBox6.Text = Convert.ToString(aprobados);
            textBox7.Text = Convert.ToString(reprobados);
            textBox8.Text = Convert.ToString(promT);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
