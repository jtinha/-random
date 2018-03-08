using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2D180222
{
    class Program
    {
        static void Main(string[] args)
        {
            

            char c = ('S');

            while (c == 'S') {
               
                int[]baaa ={3,4,5 };
                int blblblb = int.Parse(Console.ReadLine());

                if (blblblb == 3)
                {
                    Console.WriteLine("uedrep êcov");
                    Console.WriteLine("vc acertou e revelou um segredo");
                    Console.WriteLine("Você gostaria de tentar de novo? DIgite S se sim. Se n quiser, faz qualque coisa.");
                    c = char.Parse(Console.ReadLine());
                    Console.Clear();

                }
                
                else if (blblblb == 9)
                {
                    Console.WriteLine("axourt");
                    Console.WriteLine("cv revelou outra mensagem,agora desvenda TUDO!");
                    Console.WriteLine("Você gostaria de tentar de novo? DIgite S se sim. Se n quiser, faz qualque coisa.");
                    c = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (blblblb == 5)
                {
                    Console.WriteLine("ues");
                    Console.WriteLine("Mais uma mensagen");
                    Console.WriteLine("Você gostaria de tentar de novo? DIgite S se sim. Se n quiser, faz qualque coisa.");
                    c = char.Parse(Console.ReadLine());
                }
                else if(blblblb == 7)
                {
                    Console.WriteLine("opmet");
                    Console.WriteLine("falta só uma");
                    Console.WriteLine("Você gostaria de tentar de novo? DIgite S se sim. Se n quiser, faz qualque coisa.");
                    c = char.Parse(Console.ReadLine());

                }

                else {
                    Console.WriteLine("ERRODSADVFAVA!!!");
                    Console.WriteLine("Você gostaria de tentar de novo? DIgite S se sim. Se n quiser, faz qualque coisa.");
                    c = char.Parse(Console.ReadLine());
                    Console.Clear();
                }

                               
            }
        }
    }
}
