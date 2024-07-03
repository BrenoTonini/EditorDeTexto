
namespace EditorDeTexto
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            dicionárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            adicionarPalavraToolStripMenuItem = new ToolStripMenuItem();
            incluirDicionarioToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            toolStripTextBox2 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Calibri", 12F);
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Margin = new Padding(15, 15, 3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(567, 465);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, dicionárioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, salvarComoToolStripMenuItem });
            arquivoToolStripMenuItem.Image = Properties.Resources.file_106358;
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(77, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Image = Properties.Resources.plus_106443;
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = Properties.Resources.filedirectory_106375;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = Properties.Resources.diskette;
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Image = Properties.Resources.diskette;
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(180, 22);
            salvarComoToolStripMenuItem.Text = "Salvar como...";
            salvarComoToolStripMenuItem.Click += salvarComoToolStripMenuItem_Click;
            // 
            // dicionárioToolStripMenuItem
            // 
            dicionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripSeparator1, adicionarPalavraToolStripMenuItem, incluirDicionarioToolStripMenuItem });
            dicionárioToolStripMenuItem.Font = new Font("Segoe UI", 9F);
            dicionárioToolStripMenuItem.Image = Properties.Resources.search_106530;
            dicionárioToolStripMenuItem.Name = "dicionárioToolStripMenuItem";
            dicionárioToolStripMenuItem.Size = new Size(89, 20);
            dicionárioToolStripMenuItem.Text = "Dicionário";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Enabled = false;
            toolStripTextBox1.Font = new Font("Calibri", 9F, FontStyle.Bold);
            toolStripTextBox1.Image = Properties.Resources.info_106396;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(180, 22);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // adicionarPalavraToolStripMenuItem
            // 
            adicionarPalavraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox2 });
            adicionarPalavraToolStripMenuItem.Image = Properties.Resources.plus_106443;
            adicionarPalavraToolStripMenuItem.Name = "adicionarPalavraToolStripMenuItem";
            adicionarPalavraToolStripMenuItem.Size = new Size(180, 22);
            adicionarPalavraToolStripMenuItem.Text = "Adicionar Palavra";
            // 
            // incluirDicionarioToolStripMenuItem
            // 
            incluirDicionarioToolStripMenuItem.Image = Properties.Resources.dictionary;
            incluirDicionarioToolStripMenuItem.Name = "incluirDicionarioToolStripMenuItem";
            incluirDicionarioToolStripMenuItem.Size = new Size(180, 22);
            incluirDicionarioToolStripMenuItem.Text = "Incluir Dicionario";
            incluirDicionarioToolStripMenuItem.Click += incluirDicionarioToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Title = "Selecione o Arquivo";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.BackColor = SystemColors.ControlLight;
            toolStripTextBox2.CharacterCasing = CharacterCasing.Lower;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.KeyDown += new KeyEventHandler(toolStripTextBox2_KeyDown);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 489);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Editor de Texto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripMenuItem dicionárioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem adicionarPalavraToolStripMenuItem;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem incluirDicionarioToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox2;
        private FontDialog fontDialog1;
    }
}