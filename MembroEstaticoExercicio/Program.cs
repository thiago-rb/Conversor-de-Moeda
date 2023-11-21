using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembroEstaticoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual moeda quer converter?");
            Console.WriteLine(" - Euro");
            Console.WriteLine(" - Dolar");
            Console.WriteLine(" - Libra");
            Console.WriteLine(" - Yuan");
            Console.WriteLine(" - Fim");
            Console.Write("Insira a moeda para a conversão: ");
            string moeda = Console.ReadLine();
            string nomemoeda = moeda.ToLower();

            while (nomemoeda != "FIM")
            {
                Console.Write($"Insira a cotação atual do(a) {nomemoeda}: ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Insira quantas unidades de {nomemoeda} você irá comprar: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double valorfinal = 0;
     
                switch (nomemoeda)
                {
                    case "euro": 
                        valorfinal = ConversorDeMoedas.ConversorEuro(cotacao, quantia);
                        break;

                    case "dolar": 
                        valorfinal = ConversorDeMoedas.ConversorDolar(cotacao, quantia);
                        break;

                    case "dólar":
                        valorfinal = ConversorDeMoedas.ConversorDolar(cotacao, quantia);
                        break;

                    case "libra": 
                        valorfinal = ConversorDeMoedas.ConversorLibra(cotacao, quantia);
                        break; 

                    case "yuan": 
                        valorfinal = ConversorDeMoedas.ConversorYuan(cotacao, quantia);
                        break;
                }

                Console.WriteLine("Valor a ser pago em reais:  " + valorfinal.ToString("F2", CultureInfo.InvariantCulture));

                Console.Write("Insira a moeda para a conversão: ");
                moeda = Console.ReadLine();
            }

        }
    }
}
