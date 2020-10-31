using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_DanielEmilioMartinezEstevez
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea5_DanielEmilioMartinezEstevez.Forms.Form2 porcentaje = new Tarea5_DanielEmilioMartinezEstevez.Forms.Form2();
            porcentaje.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarea5_DanielEmilioMartinezEstevez.Forms.Form3 litros = new Tarea5_DanielEmilioMartinezEstevez.Forms.Form3();
            litros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tarea5_DanielEmilioMartinezEstevez.Forms.Form4 falta = new Tarea5_DanielEmilioMartinezEstevez.Forms.Form4();
            falta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tarea5_DanielEmilioMartinezEstevez.Forms.Form5 promedio = new Tarea5_DanielEmilioMartinezEstevez.Forms.Form5();
            promedio.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tarea5_DanielEmilioMartinezEstevez.Forms.Form6 factura = new Tarea5_DanielEmilioMartinezEstevez.Forms.Form6();
            factura.Show();
        }
    }
}
