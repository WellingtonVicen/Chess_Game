using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca 
    {

        private PartidaDeXadrez Partida;

        public Rei(Tab tab, Cor cor , PartidaDeXadrez partida) : base(tab, cor)
        {
            this.Partida = partida;
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

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QteMovimentos == 0;

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

            // # Jogada Especial Roque
            if(QteMovimentos == 0 && !Partida.Xeque)
            {
                // # jogadaespecial roque pequeno
                Posicao posT1 = new Posicao(Posicao.linha, Posicao.coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna + 2);
                    if(Tab.Peca(p1) == null && Tab.Peca(p2) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna + 2] = true;
                    }
                }

            }
            // # jogadaespecial roque grnade
            Posicao posT2 = new Posicao(Posicao.linha, Posicao.coluna - 4);
            if (TesteTorreParaRoque(posT2))
            {
                Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna - 1);
                Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna - 2);
                Posicao p3 = new Posicao(Posicao.linha, Posicao.coluna - 3);
                if (Tab.Peca(p1) == null && Tab.Peca(p2) == null && Tab.Peca(p3) == null)
                {
                    mat[Posicao.linha, Posicao.coluna - 2] = true;
                }
            }

            return mat;
        }
    }
}
