using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Tab
    {

        public int Linhas{ get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tab(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}
