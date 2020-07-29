using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca 
    {
        public Rei(Tab tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
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

            // acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // ne
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            pos.DefinirValores(Posicao.linha , Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //se
            pos.DefinirValores(Posicao.linha+ 1, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //so
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna -1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda
            pos.DefinirValores(Posicao.linha , Posicao.coluna  - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //no
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
