using System;
using System.Globalization;

namespace Course
{   //quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o método.
    public class Program
    {   //criando as variaveis 
        public static void Main(string[] args)
        {
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");

            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);
            //vai imprimir pro usuario area do triangulo X e Y
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //condição dos traigulos, mostra qual tem maior area
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];
            // pede pro usuario colocar as medidas de cada um dos 3 lados dos triangulos
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return medidas;
        }
        //calculo da area dos triangulos
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

    }

}
