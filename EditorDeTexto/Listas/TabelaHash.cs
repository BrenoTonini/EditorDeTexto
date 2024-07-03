using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Listas
{
    //tabela hash com tratamento externo de colisões
    internal class TabelaHash
    {
        private int QuantidadeElementos;
        private int TamanhoTabela;
        private ArvoreBinaria[] Palavras;

        public TabelaHash(int tamanho)
        {
            TamanhoTabela = tamanho;
            Palavras = new ArvoreBinaria[TamanhoTabela];
            for (int i = 0; i < TamanhoTabela; i++)
            {
                Palavras[i] = new ArvoreBinaria();
            }
            QuantidadeElementos = 0;
        }

        public int GetQuantidadeElementos() { return QuantidadeElementos; }
        public int GetTamanhoTabela() { return TamanhoTabela; }

        //gera o valor chave do elemento
        private int ValorString(string str)
        {
            int valor = 7;
            foreach (char c in str)
            {
                valor = 31 * valor + c;
            }
            //operação "and" com "0x7FFFFFFF" remove o bit de sinal da chave
            //evita overflow
            return valor & 0x7FFFFFFF;
        }

        //encontra a posição de busca e inserção do elemento
        //retorna o index
        private int HashDivisao(int chave)
        {
            return (chave & 0x7FFFFFFF) % TamanhoTabela;
        }

        //insere elemento
        public bool Inserir(string palavra)
        {
            int chave = ValorString(palavra);
            int posicao = HashDivisao(chave);

            if (!Palavras[posicao].Search(chave))
            {
                Palavras[posicao].Add(chave);
                QuantidadeElementos++;
                return true;
            }

            return false;
        }

        //busca se o elemento existe na tabela
        public bool Buscar(string palavra)
        {
            int chave = ValorString(palavra);
            int posicao = HashDivisao(chave);

            return Palavras[posicao].Search(chave);
        }
    }
}