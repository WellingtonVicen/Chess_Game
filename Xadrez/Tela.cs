using System;
using Tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tab tab)
        {
            for (int indice = 0; indice < tab.Linhas; indice++)
            {
                Console.Write(8 - indice + " ");
                for (int  col = 0;  col < tab.Colunas;  col++)
                {
                    if (tab.Peca(indice, col) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.ImprimirPeca(tab.Peca(indice, col));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
