

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } // Linhas do tabuleiro 
        public int colunas { get; set; } // Colunas do tabuleiro 
        private Peca[,] pecas; // Matriz de pecas do tipo Peca que so pode ser acessado e alterado dentro da classe Tabuleiro


        public Tabuleiro(int linhas, int colunas) // Construtor do tabuleiro 
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // Instancia a matriz de pecas com a mesma dimensão do tabuleiro 
        }

        public Peca peca(int linha, int coluna) // Encapsulamento do atributo Matriz de Peças com a função de get 
        {

            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) // Função responsavel por adicionar a matriz de peças uma peça 
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;

        }
    }
}
