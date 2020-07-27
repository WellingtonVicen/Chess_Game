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
                for (int  col = 0;  col < tab.Colunas;  col++)
                {
                    if (tab.Peca(indice, col) == null)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(tab.Peca(indice, col) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
