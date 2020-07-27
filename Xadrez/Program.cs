using System;
using Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tab tab = new Tab(8, 8);

            Tela.ImprimirTabuleiro(tab);



            Console.ReadLine();
 
        }
    }
}
