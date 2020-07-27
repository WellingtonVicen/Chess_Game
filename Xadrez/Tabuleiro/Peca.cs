using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tab Tab { get; protected set; }

        public Peca(Posicao posicao,  Tab tab, Cor cor)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            this.QteMovimentos = 0;
        }
    }
}
