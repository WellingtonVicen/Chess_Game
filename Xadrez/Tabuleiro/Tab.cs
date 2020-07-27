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

        public Peca Peca(int linha, int colunas)
        {
            return Pecas[linha, colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.linha, pos.coluna] = p;
            p.Posicao = pos;
        }
    }
}
