using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Listas
{
    internal class ArvoreBinaria
    {
        private NoArvore Raiz;

        public ArvoreBinaria()
        {
            Raiz = null;
        }
        public ArvoreBinaria(int valor)
        {
            Raiz = new NoArvore(valor);
        }

        //adiciona nó
        public void Add(int valor)
        {
            Add(Raiz, valor);
        }

        //recursão pra adicionar
        private void Add(NoArvore no, int valor)
        {
            if (Raiz == null)
            {
                Raiz = new NoArvore(valor);
            }
            else if (no.GetValue() == valor)
            {
                return;
            }
            else if (no.GetValue() > valor)
            {
                if (no.GetLeft() == null)
                {
                    no.SetLeft(new NoArvore(valor));
                }
                else
                {
                    Add(no.GetLeft(), valor);
                }
            }
            else
            {
                if (no.GetRight() == null)
                {
                    no.SetRight(new NoArvore(valor));
                }
                else
                {
                    Add(no.GetRight(), valor);
                }
            }
        }

        //busca se o valor existe na árvore
        public bool Search(int valor)
        {
            if (Raiz != null)
            {
                return Search(Raiz, valor);
            }
            return false;
        }

        //recursão pra busca
        private bool Search(NoArvore no, int valor)
        {
            if (no.GetValue() == valor)
            {
                return true;
            }
            else if (no.GetValue() > valor)
            {
                if (no.GetLeft() != null)
                {
                    return Search(no.GetLeft(), valor);
                }
                else { return false; }
            }
            else
            {
                if (no.GetRight() != null)
                {
                    return Search(no.GetRight(), valor);
                }
                else { return false; }
            }
        }
    }
}