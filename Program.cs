using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double p;
            double r;

            Console.WriteLine("Vamos descobrir se você esta no seu peso ideal");
            Console.Write("Digite seu peso atual: ");
            p=double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            a= double.Parse(Console.ReadLine());

            r = p / (Math.Pow(a, 2));
            Console.WriteLine("A relação entre peso e altura é {0}", r);
            if (r < 20)
                Console.WriteLine("Abaixo do Peso");
            else
                if (r >= 25)
                Console.WriteLine("Você esta acima do peso");
            else
                Console.WriteLine("Peso ideal");

        }
    }
}
