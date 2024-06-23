namespace FilmotecaNovo
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txConsultar = new System.Windows.Forms.TextBox();
            this.txTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmotecaDataSet = new FilmotecaNovo.FilmotecaDataSet();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDiretor = new System.Windows.Forms.ComboBox();
            this.diretoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtLanc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txNacionalidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.cbAvaliacao = new System.Windows.Forms.ComboBox();
            this.avaliacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btLimpar = new System.Windows.Forms.Button();
            this.generosTableAdapter = new FilmotecaNovo.FilmotecaDataSetTableAdapters.GenerosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDMidiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.títuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDiretorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAvaliacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midiasTableAdapter = new FilmotecaNovo.FilmotecaDataSetTableAdapters.MidiasTableAdapter();
            this.diretoresTableAdapter = new FilmotecaNovo.FilmotecaDataSetTableAdapters.DiretoresTableAdapter();
            this.tiposTableAdapter = new FilmotecaNovo.FilmotecaDataSetTableAdapters.TiposTableAdapter();
            this.avaliacoesTableAdapter = new FilmotecaNovo.FilmotecaDataSetTableAdapters.AvaliacoesTableAdapter();
            this.txGenero = new System.Windows.Forms.TextBox();
            this.txFormato = new System.Windows.Forms.TextBox();
            this.txDiretor = new System.Windows.Forms.TextBox();
            this.txAvaliacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultar.FlatAppearance.BorderSize = 3;
            this.btConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btConsultar.Location = new System.Drawing.Point(94, 144);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(182, 29);
            this.btConsultar.TabIndex = 15;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btPipoca_Click);
            // 
            // txConsultar
            // 
            this.txConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txConsultar.Location = new System.Drawing.Point(94, 109);
            this.txConsultar.Name = "txConsultar";
            this.txConsultar.Size = new System.Drawing.Size(182, 20);
            this.txConsultar.TabIndex = 13;
            // 
            // txTitulo
            // 
            this.txTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txTitulo.Location = new System.Drawing.Point(332, 236);
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.Size = new System.Drawing.Size(156, 20);
            this.txTitulo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(251, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Título";
            // 
            // cbFormato
            // 
            this.cbFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.cbFormato.DataSource = this.tiposBindingSource;
            this.cbFormato.DisplayMember = "Nome_Tipo";
            this.cbFormato.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(657, 237);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(156, 24);
            this.cbFormato.TabIndex = 19;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "Tipos";
            this.tiposBindingSource.DataSource = this.filmotecaDataSet;
            // 
            // filmotecaDataSet
            // 
            this.filmotecaDataSet.DataSetName = "FilmotecaDataSet";
            this.filmotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.cbGenero.DataSource = this.generosBindingSource;
            this.cbGenero.DisplayMember = "Nome_Genero";
            this.cbGenero.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(657, 279);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(156, 24);
            this.cbGenero.TabIndex = 21;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.filmotecaDataSet;
            // 
            // cbDiretor
            // 
            this.cbDiretor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.cbDiretor.DataSource = this.diretoresBindingSource;
            this.cbDiretor.DisplayMember = "Nome_Diretor";
            this.cbDiretor.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiretor.FormattingEnabled = true;
            this.cbDiretor.Location = new System.Drawing.Point(657, 321);
            this.cbDiretor.Name = "cbDiretor";
            this.cbDiretor.Size = new System.Drawing.Size(156, 24);
            this.cbDiretor.TabIndex = 23;
            // 
            // diretoresBindingSource
            // 
            this.diretoresBindingSource.DataMember = "Diretores";
            this.diretoresBindingSource.DataSource = this.filmotecaDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(190, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lançamento";
            // 
            // dtLanc
            // 
            this.dtLanc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dtLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLanc.Location = new System.Drawing.Point(332, 279);
            this.dtLanc.Name = "dtLanc";
            this.dtLanc.Size = new System.Drawing.Size(156, 20);
            this.dtLanc.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(170, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nacionalidade";
            // 
            // txNacionalidade
            // 
            this.txNacionalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txNacionalidade.Location = new System.Drawing.Point(332, 322);
            this.txNacionalidade.Name = "txNacionalidade";
            this.txNacionalidade.Size = new System.Drawing.Size(156, 20);
            this.txNacionalidade.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(565, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Diretor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(565, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(176)))));
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(553, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Formato";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btAdicionar.FlatAppearance.BorderSize = 3;
            this.btAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btAdicionar.Location = new System.Drawing.Point(405, 123);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(142, 64);
            this.btAdicionar.TabIndex = 31;
            this.btAdicionar.Text = "ADICIONAR";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btAlterar.FlatAppearance.BorderSize = 3;
            this.btAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btAlterar.Location = new System.Drawing.Point(576, 123);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(142, 64);
            this.btAlterar.TabIndex = 32;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btExcluir.FlatAppearance.BorderSize = 3;
            this.btExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btExcluir.Location = new System.Drawing.Point(747, 123);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(142, 64);
            this.btExcluir.TabIndex = 33;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // cbAvaliacao
            // 
            this.cbAvaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.cbAvaliacao.DataSource = this.avaliacoesBindingSource;
            this.cbAvaliacao.DisplayMember = "Descricao";
            this.cbAvaliacao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvaliacao.FormattingEnabled = true;
            this.cbAvaliacao.Location = new System.Drawing.Point(439, 373);
            this.cbAvaliacao.Name = "cbAvaliacao";
            this.cbAvaliacao.Size = new System.Drawing.Size(161, 24);
            this.cbAvaliacao.TabIndex = 34;
            // 
            // avaliacoesBindingSource
            // 
            this.avaliacoesBindingSource.DataMember = "Avaliacoes";
            this.avaliacoesBindingSource.DataSource = this.filmotecaDataSet;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btLimpar.FlatAppearance.BorderSize = 3;
            this.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btLimpar.Location = new System.Drawing.Point(94, 179);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(182, 29);
            this.btLimpar.TabIndex = 35;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMidiaDataGridViewTextBoxColumn,
            this.títuloDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.nacionalidadeDataGridViewTextBoxColumn,
            this.iDGeneroDataGridViewTextBoxColumn,
            this.iDDiretorDataGridViewTextBoxColumn,
            this.iDAvaliacaoDataGridViewTextBoxColumn,
            this.iDTipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.midiasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(94, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // iDMidiaDataGridViewTextBoxColumn
            // 
            this.iDMidiaDataGridViewTextBoxColumn.DataPropertyName = "ID_Midia";
            this.iDMidiaDataGridViewTextBoxColumn.HeaderText = "ID_Midia";
            this.iDMidiaDataGridViewTextBoxColumn.Name = "iDMidiaDataGridViewTextBoxColumn";
            this.iDMidiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // títuloDataGridViewTextBoxColumn
            // 
            this.títuloDataGridViewTextBoxColumn.DataPropertyName = "Título";
            this.títuloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.títuloDataGridViewTextBoxColumn.Name = "títuloDataGridViewTextBoxColumn";
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            this.nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // iDGeneroDataGridViewTextBoxColumn
            // 
            this.iDGeneroDataGridViewTextBoxColumn.DataPropertyName = "ID_Genero";
            this.iDGeneroDataGridViewTextBoxColumn.HeaderText = "ID_Genero";
            this.iDGeneroDataGridViewTextBoxColumn.Name = "iDGeneroDataGridViewTextBoxColumn";
            // 
            // iDDiretorDataGridViewTextBoxColumn
            // 
            this.iDDiretorDataGridViewTextBoxColumn.DataPropertyName = "ID_Diretor";
            this.iDDiretorDataGridViewTextBoxColumn.HeaderText = "ID_Diretor";
            this.iDDiretorDataGridViewTextBoxColumn.Name = "iDDiretorDataGridViewTextBoxColumn";
            // 
            // iDAvaliacaoDataGridViewTextBoxColumn
            // 
            this.iDAvaliacaoDataGridViewTextBoxColumn.DataPropertyName = "ID_Avaliacao";
            this.iDAvaliacaoDataGridViewTextBoxColumn.HeaderText = "ID_Avaliacao";
            this.iDAvaliacaoDataGridViewTextBoxColumn.Name = "iDAvaliacaoDataGridViewTextBoxColumn";
            // 
            // iDTipoDataGridViewTextBoxColumn
            // 
            this.iDTipoDataGridViewTextBoxColumn.DataPropertyName = "ID_Tipo";
            this.iDTipoDataGridViewTextBoxColumn.HeaderText = "ID_Tipo";
            this.iDTipoDataGridViewTextBoxColumn.Name = "iDTipoDataGridViewTextBoxColumn";
            // 
            // midiasBindingSource
            // 
            this.midiasBindingSource.DataMember = "Midias";
            this.midiasBindingSource.DataSource = this.filmotecaDataSet;
            // 
            // midiasTableAdapter
            // 
            this.midiasTableAdapter.ClearBeforeFill = true;
            // 
            // diretoresTableAdapter
            // 
            this.diretoresTableAdapter.ClearBeforeFill = true;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // avaliacoesTableAdapter
            // 
            this.avaliacoesTableAdapter.ClearBeforeFill = true;
            // 
            // txGenero
            // 
            this.txGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txGenero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generosBindingSource, "ID_Genero", true));
            this.txGenero.Location = new System.Drawing.Point(819, 281);
            this.txGenero.Name = "txGenero";
            this.txGenero.Size = new System.Drawing.Size(25, 20);
            this.txGenero.TabIndex = 37;
            // 
            // txFormato
            // 
            this.txFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txFormato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tiposBindingSource, "ID_Tipo", true));
            this.txFormato.Location = new System.Drawing.Point(819, 239);
            this.txFormato.Name = "txFormato";
            this.txFormato.Size = new System.Drawing.Size(25, 20);
            this.txFormato.TabIndex = 38;
            // 
            // txDiretor
            // 
            this.txDiretor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txDiretor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diretoresBindingSource, "ID_Diretor", true));
            this.txDiretor.Location = new System.Drawing.Point(819, 322);
            this.txDiretor.Name = "txDiretor";
            this.txDiretor.Size = new System.Drawing.Size(25, 20);
            this.txDiretor.TabIndex = 39;
            // 
            // txAvaliacao
            // 
            this.txAvaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txAvaliacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avaliacoesBindingSource, "ID_Avaliacao", true));
            this.txAvaliacao.Location = new System.Drawing.Point(606, 375);
            this.txAvaliacao.Name = "txAvaliacao";
            this.txAvaliacao.Size = new System.Drawing.Size(25, 20);
            this.txAvaliacao.TabIndex = 40;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 645);
            this.Controls.Add(this.txAvaliacao);
            this.Controls.Add(this.txDiretor);
            this.Controls.Add(this.txFormato);
            this.Controls.Add(this.txGenero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.cbAvaliacao);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txNacionalidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtLanc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDiretor);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTitulo);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txConsultar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Sala de Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txConsultar;
        private System.Windows.Forms.TextBox txTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbDiretor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtLanc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNacionalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ComboBox cbAvaliacao;
        private System.Windows.Forms.Button btLimpar;
        private FilmotecaDataSet filmotecaDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private FilmotecaDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource midiasBindingSource;
        private FilmotecaDataSetTableAdapters.MidiasTableAdapter midiasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMidiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn títuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDiretorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAvaliacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diretoresBindingSource;
        private FilmotecaDataSetTableAdapters.DiretoresTableAdapter diretoresTableAdapter;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private FilmotecaDataSetTableAdapters.TiposTableAdapter tiposTableAdapter;
        private System.Windows.Forms.BindingSource avaliacoesBindingSource;
        private FilmotecaDataSetTableAdapters.AvaliacoesTableAdapter avaliacoesTableAdapter;
        private System.Windows.Forms.TextBox txGenero;
        private System.Windows.Forms.TextBox txFormato;
        private System.Windows.Forms.TextBox txDiretor;
        private System.Windows.Forms.TextBox txAvaliacao;
    }
}