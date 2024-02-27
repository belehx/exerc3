using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            Console.WriteLine("Digite apenas a primeira letra do seu sexo: ");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'F')
            { 
                Console.WriteLine("sua resposta foi válida"); 
            } 
            Console.ReadKey();

        }
    }
}
