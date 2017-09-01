using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int soma= 0;

            for (int i = 0; i <= 1000; i++)
            {
              soma= soma + x;
              x++;
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
        
    }
}
