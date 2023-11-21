using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembroEstaticoExercicio
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double ConversorDolar(double cotacao , double quantia)
        {
            double total = cotacao  * quantia;
            return total;
        }
        public static double ConversorEuro(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total;
        }
        public static double ConversorLibra(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total;
        }
        public static double ConversorYuan(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total;
        }
       
    }
}
