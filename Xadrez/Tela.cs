using System;
using Tabuleiro;
using Xadrez;

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
                    Tela.ImprimirPeca(tab.Peca(indice, col));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tab tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                Console.Write(8 - linhas + " ");
                for (int col = 0; col < tab.Colunas; col++)
                {
                    if(posicoesPossiveis[linhas, col])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Tela.ImprimirPeca(tab.Peca(linhas, col));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {

                if (peca.Cor == Cor.Branca)
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
                Console.Write(" ");
            }
            
        }
    }
}
