using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {

       public Tab Tab { get; private set; }
        public int Turno { get; private set; }
       public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }


        public PartidaDeXadrez()
        {
            Tab = new Tab(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
           ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
           Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();


        }

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if(Tab.Peca(pos) == null)
            {
                throw new TabException("Não existe peca na posição de origem escolhidda!");
            }
            if(JogadorAtual != Tab.Peca(pos).Cor)
            {
                throw new TabException("A peça de Origem escolhida não é sua!");
            }
            if (!Tab.Peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabException("Não há movimentos possiveis para a peca de origem  escolhida!");
            }
        }


        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                  throw  new TabException("Posicao de destino invalida!");
            }
        }

        private void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;

            }
        }

        private  void ColocarPecas()
        {

            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c',1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());


        }
    }
}
