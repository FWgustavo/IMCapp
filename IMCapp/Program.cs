using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc <= 16.9)
            {
                Console.WriteLine("Você está muito abaixo do peso " + imc);
            }
            else if (imc <= 18.4)
            {
                Console.WriteLine("Você está abaixo do peso " + imc);
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Seu peso está normal " + imc);
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Você está acima do peso " + imc);
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1 " + imc);
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Obesidade Grau 2 " + imc);
            }
            else if(imc > 40)
            {
                Console.WriteLine("Obesidade Grau 3 " +imc);
            }
            Console.ReadKey();
        }
    }
}
