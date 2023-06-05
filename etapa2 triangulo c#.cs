using System;
using System.Globalization;

namespace Course
{   //quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o seu método.
    public class Triangulo
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        //calculo da area dos triangulos
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }

    public class Program
    {   //criando variaveis
        public static void Main(string[] args)
        {
            Triangulo x = LerTriangulo("x");
            Triangulo y = LerTriangulo("y");

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            //mostra pro usuário o valor calculado de cada um dos triangulos
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //condicionais dos triangulos, mostra qual tem a maior area
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {   interface pro usuario colocar as medidas de cada triangulo
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             return triangulo;
        }

    }
}