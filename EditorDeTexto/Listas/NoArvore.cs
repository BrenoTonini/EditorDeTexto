using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Listas
{
    internal class NoArvore
    {
        private int Value;
        private NoArvore Right;
        private NoArvore Left;

        public NoArvore(int value)
        {
            Value = value;
            Right = null;
            Left = null;
        }

        public int GetValue() { return Value; }
        public void SetValue(int value) { Value = value; }
        public NoArvore GetRight() { return Right; }
        public void SetRight(NoArvore right) { Right = right; }
        public NoArvore GetLeft() { return Left; }
        public void SetLeft(NoArvore left) { Left = left; }
    }
}
