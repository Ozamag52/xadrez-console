using tabuleiro;

namespace xadrez
{
    class Rei : Peca // A classe Rei e uma classe que herda os atributos e metodos da classe generica Peca
    {


        public Rei(Tabuleiro tab, Cor cor) : base(tab , cor)
        {
        }

        public override string ToString()
        {
            return "R"; 
        }

    }
}
