using System;
using System.Globalization;

namespace _02_Triangulo
{
    class minhaClasse
    {
        static void Main(string[] args)
        {
            /*
                Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
                Perimetro = XX.X
                Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
                Area = XX.X

                ENTRADA
                A entrada contém três valores reais.
                
                SAÍDA
                O resultado deve ser apresentado com uma casa decimal.
                
                Exemplo de Entrada	Exemplo de Saída
                6.0 4.0 2.0
                
                Area = 10.0
             */

            double a, b, c, resultado;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if ((a <(b + c)) && (b < (a + c)) && (c < (a + b))) //complete a condicional
            {
                resultado = a + b + c;
                Console.WriteLine("Perimetro = {0:0.0}", resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                resultado = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0:0.0}", resultado.ToString("F1", CultureInfo.InvariantCulture));
            }   
        }
    }
}
