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
    public partial class Form3 : Form
    {
        Tarea5_DanielEmilioMartinezEstevez.Class.Class1 litro = new Tarea5_DanielEmilioMartinezEstevez.Class.Class1();

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("error el campo esta vacio");
                textBox1.Focus();
                return;
            }

            double N1;
            N1 = Convert.ToDouble(textBox1.Text);

            textBox2.Text = Convert.ToString( litro.Cubo(N1));

        }
    }
}
