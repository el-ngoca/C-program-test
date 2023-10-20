using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaTest.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Potencia(int x, int y)
        {
            double p = Math.Pow(x,y);
            Console.WriteLine($"{x} ^{y} = {p}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {angulo}graus = {Math.Round(seno, 4)}");
        }

         public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cos = Math.Cos(radiano);

            Console.WriteLine($"Coseno de {angulo}graus = {Math.Round(cos, 4)}");
        }


         public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tag = Math.Sin(radiano);

            Console.WriteLine($"Tangente de {angulo}graus = {Math.Round(tag, 4)}");
        }
    }
}