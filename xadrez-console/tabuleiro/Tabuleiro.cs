using System;
using xadretabuleiro;
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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) // Função responsavel por adicionar a matriz de peças uma peça 
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            }

            else
            {
                pecas[pos.linha, pos.coluna] = p;
                p.posicao = pos;
            }
        }

        public bool posicaoValida(Posicao pos) // Metodo responsavel por verificar se a posição da peça entra dentro da dimensao do tabuleiro
        {
            if (pos.linha >= linhas || pos.linha < 0 || pos.coluna >= colunas || pos.coluna < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void validarPosicao(Posicao pos) // Metodo responsavel por validar uma posicao e caso invalide lancar uma excecao 
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
