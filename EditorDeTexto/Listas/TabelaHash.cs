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

        public void Release()
        {
            for (int i = 0; i < TamanhoTabela; i++)
            {
                Palavras[i] = new ArvoreBinaria(); // Reset each tree
            }
        }

        private int ValorString(string str)
        {
            int valor = 7;
            foreach (char c in str)
            {
                valor = 31 * valor + c;
            }
            return valor & 0x7FFFFFFF;
        }

        private int HashDivisao(int chave)
        {
            return (chave & 0x7FFFFFFF) % TamanhoTabela;
        }

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

        public bool Buscar(string palavra)
        {
            int chave = ValorString(palavra);
            int posicao = HashDivisao(chave);

            return Palavras[posicao].Search(chave);
        }
    }
}
