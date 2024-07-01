using EditorDeTexto.Entidades;
using EditorDeTexto.Listas;
using System.Text.RegularExpressions;
using System.Timers;

namespace EditorDeTexto
{
    public partial class Main : Form
    {
        private Dicionario Dicionario;
        private string CaminhoArquivoAtual;
        bool ArquivoFoiAlterado;

        //intervalo da rotina de verificação de palavras
        private System.Windows.Forms.Timer Timer;

        public Main()
        {
            InicializaDicionario();
            InitializeComponent();
            toolStripTextBox1.Text = Dicionario.GetTamanho() + " palavras";

            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 500; // 200ms de espera para a rotina de verificação
            Timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Timer.Stop();
            ArquivoFoiAlterado = true;
            VerificarPalavras();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Timer.Stop();
            Timer.Start();
        }

        private void VerificarPalavras()
        {
            string texto = richTextBox1.Text;
            int cursorPosition = richTextBox1.SelectionStart;

            richTextBox1.TextChanged -= RichTextBox1_TextChanged;

            char[] separadores = new char[] { ' ', '.', ',', ';', ':', '!', '?', '\n', '\t' };
            string[] palavras = texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);

            foreach (string palavra in palavras)
            {
                if (Regex.IsMatch(palavra, @"^[a-zA-ZÀ-ÖØ-öø-ÿÇç]+$") && !Dicionario.EncontrarPalavra(palavra))
                {
                    string pattern = $@"\b{Regex.Escape(palavra)}\b";
                    MatchCollection matches = Regex.Matches(richTextBox1.Text, pattern);

                    foreach (Match match in matches)
                    {
                        richTextBox1.Select(match.Index, match.Length);
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                        richTextBox1.SelectionColor = Color.Red;

                    }
                }
            }

            richTextBox1.Select(cursorPosition, 0);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;

            richTextBox1.TextChanged += RichTextBox1_TextChanged;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void AbrirArquivo()
        {
            if (ArquivoFoiAlterado)
            {
                if (MessageBox.Show("Deseja sair sem salvar alterações?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    SalvarArquivo();
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CaminhoArquivoAtual = openFileDialog1.FileName;
                    using (StreamReader sr = new StreamReader(CaminhoArquivoAtual))
                    {
                        richTextBox1.Text = sr.ReadToEnd();
                        Text = "Editor de texto - " + openFileDialog1.FileName;
                    }
                    ArquivoFoiAlterado = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            if (!string.IsNullOrEmpty(CaminhoArquivoAtual))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(CaminhoArquivoAtual, false))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                    ArquivoFoiAlterado = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SalvarArquivoComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivoComo();
        }

        private void SalvarArquivoComo()
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        CaminhoArquivoAtual = saveFileDialog1.FileName;
                        using (StreamWriter sw = new StreamWriter(CaminhoArquivoAtual, false))
                        {
                            sw.Write(richTextBox1.Text);
                        }
                        ArquivoFoiAlterado = false;
                        Text = "Editor de texto - " + saveFileDialog1.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ArquivoFoiAlterado)
            {
                DialogResult resultado = MessageBox.Show("Deseja salvar alterações antes de sair?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resultado == DialogResult.Yes)
                {
                    SalvarArquivo();
                }
                else if (resultado == DialogResult.No)
                {
                    //nao salva e sai
                }
                else
                {
                    //nao sai
                    return;
                }
            }
            CaminhoArquivoAtual = null;
            richTextBox1.Text = string.Empty;
            Text = "Editor de Texto";
            ArquivoFoiAlterado = false;
        }

        private void InicializaDicionario()
        {
            Dicionario = new Dicionario();
        }
        private void incluirDicionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncluirDicionario();
        }

        private void IncluirDicionario()
        {
            OpenFileDialog dialogoIncluirDicionario = new OpenFileDialog();
            dialogoIncluirDicionario.Filter = "Arquivos de Texto|*.txt";
            dialogoIncluirDicionario.Title = "Selecione o arquivo de palavras a ser incluído";
            try
            {
                if (dialogoIncluirDicionario.ShowDialog() == DialogResult.OK)
                {
                    string pathDicionario = dialogoIncluirDicionario.FileName;

                    Dicionario.MesclarPalavras(pathDicionario);
                    MessageBox.Show("Palavras incluídas com sucesso no dicionário!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao incluir palavras no dicionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //atualiza a contagem de palavras na aba de dicionário
            toolStripTextBox1.Text = Dicionario.GetTamanho() + " palavras";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNovaPalavra();
            }
        }
        private void AddNovaPalavra()
        {
            string palavra = toolStripTextBox2.Text;
            

            //expressao regular pra saber se é uma palavra com somente letras em minúsculo
            //o textbox só está aceitando minúsculo
            if (!string.IsNullOrEmpty(palavra) && !palavra.Contains(' '))
            {
                Dicionario.AddNovaPalavra(palavra);
            }
            else
            {
                MessageBox.Show("Palavra inválida. Espaços vazios não são aceitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            toolStripTextBox2.Text = string.Empty;

            //atualiza a contagem de palavras na aba de dicionário
            toolStripTextBox1.Text = Dicionario.GetTamanho() + " palavras";
            
            VerificarPalavras();
        }
    }
}
