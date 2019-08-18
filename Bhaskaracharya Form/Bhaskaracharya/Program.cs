using System;

namespace Bhaskaracharya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formula de Bhaskara");
            Console.WriteLine("Digite os valores de a, b e c ");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O Delta da Formula é " + delta);
            Console.WriteLine("A primeira raiz da Fórmula é: " + x1);
            Console.WriteLine("A segunda raiz da Fórmula é: " + x2);
        }
    }
}
