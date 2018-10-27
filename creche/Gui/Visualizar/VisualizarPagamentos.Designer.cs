namespace creche.Gui.Visualizar
{
    partial class VisualizarPagamentos
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
            this.dg_pagamento = new System.Windows.Forms.DataGridView();
            this.pagamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoDataSet = new creche.Dataset.PagamentoDataSet();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_nome = new System.Windows.Forms.Button();
            this.gb_pagamentos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_falta = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_todas_criancas = new System.Windows.Forms.Button();
            this.btn_pai = new System.Windows.Forms.Button();
            this.btn_turma = new System.Windows.Forms.Button();
            this.dtp_começo = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.responsavelSelector = new Creche.Component.ResponsavelSelector();
            this.turmaSelector = new Creche.Component.TurmaSelector();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorreceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recebidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataSet)).BeginInit();
            this.gb_pagamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_pagamento
            // 
            this.dg_pagamento.AllowUserToAddRows = false;
            this.dg_pagamento.AllowUserToDeleteRows = false;
            this.dg_pagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_pagamento.AutoGenerateColumns = false;
            this.dg_pagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.valorreceberDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.recebidoDataGridViewCheckBoxColumn,
            this.Codigo_pagamento});
            this.dg_pagamento.DataSource = this.pagamentoBindingSource1;
            this.dg_pagamento.Location = new System.Drawing.Point(6, 19);
            this.dg_pagamento.Name = "dg_pagamento";
            this.dg_pagamento.Size = new System.Drawing.Size(713, 178);
            this.dg_pagamento.TabIndex = 0;
            this.dg_pagamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pagamentoBindingSource1
            // 
            this.pagamentoBindingSource1.DataMember = "Pagamento";
            this.pagamentoBindingSource1.DataSource = this.pagamentoBindingSource;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = this.pagamentoDataSet;
            this.pagamentoBindingSource.Position = 0;
            // 
            // pagamentoDataSet
            // 
            this.pagamentoDataSet.DataSetName = "PagamentoDataSet";
            this.pagamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(80, 13);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(237, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(36, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // btn_nome
            // 
            this.btn_nome.Location = new System.Drawing.Point(324, 10);
            this.btn_nome.Name = "btn_nome";
            this.btn_nome.Size = new System.Drawing.Size(95, 23);
            this.btn_nome.TabIndex = 3;
            this.btn_nome.Text = "Pesquisar nome";
            this.btn_nome.UseVisualStyleBackColor = true;
            this.btn_nome.Click += new System.EventHandler(this.btn_nome_Click);
            // 
            // gb_pagamentos
            // 
            this.gb_pagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_pagamentos.Controls.Add(this.btn_deletar);
            this.gb_pagamentos.Controls.Add(this.label2);
            this.gb_pagamentos.Controls.Add(this.lbl_falta);
            this.gb_pagamentos.Controls.Add(this.btn_salvar);
            this.gb_pagamentos.Controls.Add(this.dg_pagamento);
            this.gb_pagamentos.Location = new System.Drawing.Point(12, 142);
            this.gb_pagamentos.Name = "gb_pagamentos";
            this.gb_pagamentos.Size = new System.Drawing.Size(725, 232);
            this.gb_pagamentos.TabIndex = 5;
            this.gb_pagamentos.TabStop = false;
            this.gb_pagamentos.Text = "Pagamentos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Falta:";
            // 
            // lbl_falta
            // 
            this.lbl_falta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_falta.AutoSize = true;
            this.lbl_falta.Location = new System.Drawing.Point(664, 208);
            this.lbl_falta.Name = "lbl_falta";
            this.lbl_falta.Size = new System.Drawing.Size(0, 13);
            this.lbl_falta.TabIndex = 15;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(6, 203);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_todas_criancas
            // 
            this.btn_todas_criancas.Location = new System.Drawing.Point(426, 12);
            this.btn_todas_criancas.Name = "btn_todas_criancas";
            this.btn_todas_criancas.Size = new System.Drawing.Size(99, 23);
            this.btn_todas_criancas.TabIndex = 6;
            this.btn_todas_criancas.Text = "Pesquisar todos";
            this.btn_todas_criancas.UseVisualStyleBackColor = true;
            this.btn_todas_criancas.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_pai
            // 
            this.btn_pai.Location = new System.Drawing.Point(324, 39);
            this.btn_pai.Name = "btn_pai";
            this.btn_pai.Size = new System.Drawing.Size(95, 23);
            this.btn_pai.TabIndex = 7;
            this.btn_pai.Text = "Pesquisar pai";
            this.btn_pai.UseVisualStyleBackColor = true;
            this.btn_pai.Click += new System.EventHandler(this.btn_pai_Click);
            // 
            // btn_turma
            // 
            this.btn_turma.Location = new System.Drawing.Point(324, 73);
            this.btn_turma.Name = "btn_turma";
            this.btn_turma.Size = new System.Drawing.Size(95, 23);
            this.btn_turma.TabIndex = 8;
            this.btn_turma.Text = "Pesquisar turma";
            this.btn_turma.UseVisualStyleBackColor = true;
            this.btn_turma.Click += new System.EventHandler(this.btn_turma_Click);
            // 
            // dtp_começo
            // 
            this.dtp_começo.Location = new System.Drawing.Point(18, 121);
            this.dtp_começo.Name = "dtp_começo";
            this.dtp_começo.Size = new System.Drawing.Size(251, 20);
            this.dtp_começo.TabIndex = 11;
            // 
            // dtp_fim
            // 
            this.dtp_fim.Location = new System.Drawing.Point(301, 122);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(251, 20);
            this.dtp_fim.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "até";
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(566, 121);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(99, 23);
            this.btn_data.TabIndex = 14;
            this.btn_data.Text = "Pesquisar data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(87, 203);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 17;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // responsavelSelector
            // 
            this.responsavelSelector.Location = new System.Drawing.Point(2, 39);
            this.responsavelSelector.Name = "responsavelSelector";
            this.responsavelSelector.Responsavel = null;
            this.responsavelSelector.Size = new System.Drawing.Size(316, 26);
            this.responsavelSelector.TabIndex = 10;
            // 
            // turmaSelector
            // 
            this.turmaSelector.Location = new System.Drawing.Point(29, 73);
            this.turmaSelector.Name = "turmaSelector";
            this.turmaSelector.Size = new System.Drawing.Size(290, 30);
            this.turmaSelector.TabIndex = 9;
            this.turmaSelector.Turma = null;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // valorreceberDataGridViewTextBoxColumn
            // 
            this.valorreceberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorreceberDataGridViewTextBoxColumn.DataPropertyName = "Valor_receber";
            this.valorreceberDataGridViewTextBoxColumn.HeaderText = "Valor_receber";
            this.valorreceberDataGridViewTextBoxColumn.MaxInputLength = 7;
            this.valorreceberDataGridViewTextBoxColumn.Name = "valorreceberDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recebidoDataGridViewCheckBoxColumn
            // 
            this.recebidoDataGridViewCheckBoxColumn.DataPropertyName = "Recebido";
            this.recebidoDataGridViewCheckBoxColumn.FalseValue = "false";
            this.recebidoDataGridViewCheckBoxColumn.HeaderText = "Recebido";
            this.recebidoDataGridViewCheckBoxColumn.Name = "recebidoDataGridViewCheckBoxColumn";
            this.recebidoDataGridViewCheckBoxColumn.TrueValue = "true";
            this.recebidoDataGridViewCheckBoxColumn.Width = 70;
            // 
            // Codigo_pagamento
            // 
            this.Codigo_pagamento.DataPropertyName = "Codigo_pagamento";
            this.Codigo_pagamento.HeaderText = "Codigo_pagamento";
            this.Codigo_pagamento.Name = "Codigo_pagamento";
            this.Codigo_pagamento.Visible = false;
            // 
            // VisualizarPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 386);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.dtp_começo);
            this.Controls.Add(this.responsavelSelector);
            this.Controls.Add(this.turmaSelector);
            this.Controls.Add(this.btn_turma);
            this.Controls.Add(this.btn_pai);
            this.Controls.Add(this.btn_todas_criancas);
            this.Controls.Add(this.gb_pagamentos);
            this.Controls.Add(this.btn_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tb_nome);
            this.Name = "VisualizarPagamentos";
            this.Text = "VisualizarPagamentos";
            this.Load += new System.EventHandler(this.VisualizarPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataSet)).EndInit();
            this.gb_pagamentos.ResumeLayout(false);
            this.gb_pagamentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_pagamento;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_nome;
        private System.Windows.Forms.BindingSource pagamentoBindingSource1;
        private Dataset.PagamentoDataSet pagamentoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_pagamentos;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_todas_criancas;
        private System.Windows.Forms.Button btn_pai;
        private System.Windows.Forms.Button btn_turma;
        private Creche.Component.TurmaSelector turmaSelector;
        private Creche.Component.ResponsavelSelector responsavelSelector;
        private System.Windows.Forms.DateTimePicker dtp_começo;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Label lbl_falta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorreceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recebidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_pagamento;
    }
}