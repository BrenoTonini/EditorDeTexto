using EditorDeTexto.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Entidades
{
    internal class Dicionario
    {
        private int TamanhoDicionario = 300007;   //numero primo proximo de 300000
        private TabelaHash Palavras;
        private const string NomeArquivo = "DicionarioDePalavras.txt";
        private string PathArquivo;

        public Dicionario()
        {
            Palavras = new TabelaHash(TamanhoDicionario);
            PathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NomeArquivo); //o arquivo deve estar no diretorio `...\bin\Debug\net8.0-windows`
            CarregarDicionario();
        }

        public int GetTamanho() { return Palavras.GetQuantidadeElementos(); }
        public string GetNomeArquivo() { return NomeArquivo; }
        public string GetPath() { return PathArquivo; }

        private void CarregarDicionario()
        {
            if (File.Exists(PathArquivo))
            {
                using StreamReader sr = new StreamReader(PathArquivo);
                {
                    while (!sr.EndOfStream)
                    {
                        string palavra = sr.ReadLine();
                        if (palavra != "" || palavra != null)
                        {
                            Palavras.Inserir(palavra);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    //cria o dicionario de palavras se ele n existir
                    using (StreamWriter sw = File.CreateText(PathArquivo))
                    {
                        MessageBox.Show($"Arquivo [{NomeArquivo}] criado em: {PathArquivo}", "Dicionário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    //se falhar a criação
                    MessageBox.Show($"Erro ao criar o arquivo [{NomeArquivo}]: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void MesclarPalavras(string pathDicionario)
        {
            if (File.Exists(pathDicionario))
            {
                using (StreamReader sr = new StreamReader(pathDicionario))
                {
                    using (StreamWriter sw = new StreamWriter(PathArquivo))
                    {
                        while (!sr.EndOfStream)
                        {
                            string palavra = sr.ReadLine();
                            if (!string.IsNullOrEmpty(palavra) && !EncontrarPalavra(palavra))
                            {
                                sw.WriteLine(palavra);
                                Palavras.Inserir(palavra);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Arquivo não encontrado: {pathDicionario}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool EncontrarPalavra(string palavra)
        {
            //busca a palavra em minúsculo e também do jeito que foi escrita.
            //no arquivo fornecido existem algumas palavras inseridas com primeira letra maiúscula.
            //exemplo: nomes de pessoas e países
            return Palavras.Buscar(palavra.ToLower()) || Palavras.Buscar(palavra);
        }

        public void AddNovaPalavra(string palavra)
        {
            if (EncontrarPalavra(palavra) == false)
            {
                if (File.Exists(PathArquivo))
                {
                    //escreve a nova palavra no arquivo do dicionario
                    using StreamWriter sw = new StreamWriter(PathArquivo, true);
                    {
                        sw.WriteLine(palavra);
                    }

                    //insere a nova palavra na tabela hash do dicionario
                    Palavras.Inserir(palavra);
                }
                else
                {
                    MessageBox.Show($"Arquivo [{NomeArquivo}] não existe no path: {PathArquivo}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
