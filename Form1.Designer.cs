
namespace Acervo_de_Jogos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbPlataforma = new System.Windows.Forms.TextBox();
            this.tbMidia = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCondic = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgAcervo = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo da Mídia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Condição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data da Compra";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(88, 23);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(178, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(88, 49);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(178, 20);
            this.tbCategoria.TabIndex = 8;
            // 
            // tbPlataforma
            // 
            this.tbPlataforma.Location = new System.Drawing.Point(88, 75);
            this.tbPlataforma.Name = "tbPlataforma";
            this.tbPlataforma.Size = new System.Drawing.Size(178, 20);
            this.tbPlataforma.TabIndex = 9;
            // 
            // tbMidia
            // 
            this.tbMidia.Location = new System.Drawing.Point(351, 23);
            this.tbMidia.Name = "tbMidia";
            this.tbMidia.Size = new System.Drawing.Size(178, 20);
            this.tbMidia.TabIndex = 10;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(351, 49);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(178, 20);
            this.tbValor.TabIndex = 11;
            // 
            // tbCondic
            // 
            this.tbCondic.Location = new System.Drawing.Point(351, 75);
            this.tbCondic.Name = "tbCondic";
            this.tbCondic.Size = new System.Drawing.Size(178, 20);
            this.tbCondic.TabIndex = 12;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(634, 23);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(178, 20);
            this.tbData.TabIndex = 13;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(28, 123);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(126, 56);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgAcervo
            // 
            this.dgAcervo.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colNome,
            this.colCategoria,
            this.colPlataforma,
            this.colMidia,
            this.colValor,
            this.colCondicao,
            this.colData});
            this.dgAcervo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgAcervo.Location = new System.Drawing.Point(28, 185);
            this.dgAcervo.Name = "dgAcervo";
            this.dgAcervo.Size = new System.Drawing.Size(840, 408);
            this.dgAcervo.TabIndex = 15;
            this.dgAcervo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAcervo_CellContentClick);
            this.dgAcervo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAcervo_CellContentClick);
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod.";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 177;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colPlataforma
            // 
            this.colPlataforma.HeaderText = "Plataforma";
            this.colPlataforma.Name = "colPlataforma";
            // 
            // colMidia
            // 
            this.colMidia.HeaderText = "Mídia";
            this.colMidia.Name = "colMidia";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 50;
            // 
            // colCondicao
            // 
            this.colCondicao.HeaderText = "Condição";
            this.colCondicao.Name = "colCondicao";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.Width = 70;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(245, 123);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(126, 56);
            this.btInserir.TabIndex = 16;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(491, 123);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(126, 56);
            this.btAlterar.TabIndex = 17;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cód.";
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(634, 51);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(74, 20);
            this.tbCod.TabIndex = 19;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(742, 123);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(126, 56);
            this.btDelete.TabIndex = 20;
            this.btDelete.Text = "Deletar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(894, 618);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgAcervo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCondic);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbMidia);
            this.Controls.Add(this.tbPlataforma);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Acervo de Jogos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbPlataforma;
        private System.Windows.Forms.TextBox tbMidia;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCondic;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgAcervo;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Button btDelete;
    }
}

