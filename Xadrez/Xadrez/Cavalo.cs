using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tab tab,Cor cor): base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 2);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha + 2 , Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha + 2, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
