using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_DanielEmilioMartinezEstevez.Class
{
    class Class1
    {
        public double porcentaje(double P1, double P2)
        {
            double contenedor, ToT;
            string texto;
            contenedor = P1 / P2;
            ToT = contenedor / 100;

            texto = Convert.ToString(ToT);
            return ToT;
        }

        public double Cubo(double Lado)
        {
            double litros, total;
            litros = Lado * Lado * Lado;
            total = litros * 1000;
            return total;

        }

        public double faltante(double N1 = 0, double N2 = 0, double N3 = 0)
        {
            double faltante;
            faltante = 65 - (N1 + N2 + N3);
            return faltante;
        }

        public double promedio(double N1 = 0, double N2 = 0, double N3 = 0, double N4 = 0)
        {
            double prom;
            prom = (N1 + N2 + N3 + N4) / 4;
            return prom;
        }

        public double factura(double P, double C, double I)
        {
            double sub, total;
            sub = P * C;
            total = sub + I;
            return total;
        }
    }
}
