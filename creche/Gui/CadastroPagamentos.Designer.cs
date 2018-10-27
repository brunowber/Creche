namespace Creche.Gui
{
    partial class CadastroPagamentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.gp_cadastro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_parcelas = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_valor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.dtp_vencimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_setas = new System.Windows.Forms.Panel();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primeiro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gp_cadastro.SuspendLayout();
            this.pn_setas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Location = new System.Drawing.Point(13, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 46);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(246, 13);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(327, 13);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Desabilitar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(165, 13);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(84, 13);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Enabled = false;
            this.btn_novo.Location = new System.Drawing.Point(3, 13);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // gp_cadastro
            // 
            this.gp_cadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_cadastro.Controls.Add(this.label4);
            this.gp_cadastro.Controls.Add(this.tb_parcelas);
            this.gp_cadastro.Controls.Add(this.tb_nome);
            this.gp_cadastro.Controls.Add(this.label3);
            this.gp_cadastro.Controls.Add(this.label1);
            this.gp_cadastro.Controls.Add(this.mtb_valor);
            this.gp_cadastro.Controls.Add(this.label5);
            this.gp_cadastro.Controls.Add(this.tb_codigo);
            this.gp_cadastro.Controls.Add(this.dtp_vencimento);
            this.gp_cadastro.Controls.Add(this.label2);
            this.gp_cadastro.Enabled = false;
            this.gp_cadastro.Location = new System.Drawing.Point(12, 12);
            this.gp_cadastro.Name = "gp_cadastro";
            this.gp_cadastro.Size = new System.Drawing.Size(409, 174);
            this.gp_cadastro.TabIndex = 3;
            this.gp_cadastro.TabStop = false;
            this.gp_cadastro.Text = "Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Parcelas:";
            // 
            // tb_parcelas
            // 
            this.tb_parcelas.Location = new System.Drawing.Point(95, 133);
            this.tb_parcelas.MaxLength = 2;
            this.tb_parcelas.Name = "tb_parcelas";
            this.tb_parcelas.Size = new System.Drawing.Size(28, 20);
            this.tb_parcelas.TabIndex = 16;
            this.tb_parcelas.Text = "1";
            this.tb_parcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_parcelas_KeyPress);
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(95, 50);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(261, 20);
            this.tb_nome.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor:";
            // 
            // mtb_valor
            // 
            this.mtb_valor.Location = new System.Drawing.Point(95, 107);
            this.mtb_valor.Mask = "$999.00";
            this.mtb_valor.Name = "mtb_valor";
            this.mtb_valor.Size = new System.Drawing.Size(100, 20);
            this.mtb_valor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Enabled = false;
            this.tb_codigo.Location = new System.Drawing.Point(95, 19);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(76, 20);
            this.tb_codigo.TabIndex = 10;
            // 
            // dtp_vencimento
            // 
            this.dtp_vencimento.Location = new System.Drawing.Point(95, 76);
            this.dtp_vencimento.Name = "dtp_vencimento";
            this.dtp_vencimento.Size = new System.Drawing.Size(245, 20);
            this.dtp_vencimento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Vencimento:";
            // 
            // pn_setas
            // 
            this.pn_setas.Controls.Add(this.btn_proximo);
            this.pn_setas.Controls.Add(this.btn_ultimo);
            this.pn_setas.Controls.Add(this.btn_anterior);
            this.pn_setas.Controls.Add(this.btn_primeiro);
            this.pn_setas.Location = new System.Drawing.Point(97, 190);
            this.pn_setas.Name = "pn_setas";
            this.pn_setas.Size = new System.Drawing.Size(219, 30);
            this.pn_setas.TabIndex = 14;
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(136, 4);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(35, 23);
            this.btn_proximo.TabIndex = 5;
            this.btn_proximo.Text = ">";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Location = new System.Drawing.Point(177, 4);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(35, 23);
            this.btn_ultimo.TabIndex = 4;
            this.btn_ultimo.Text = ">>";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(44, 4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(35, 23);
            this.btn_anterior.TabIndex = 3;
            this.btn_anterior.Text = "<";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_primeiro
            // 
            this.btn_primeiro.Location = new System.Drawing.Point(3, 4);
            this.btn_primeiro.Name = "btn_primeiro";
            this.btn_primeiro.Size = new System.Drawing.Size(35, 23);
            this.btn_primeiro.TabIndex = 2;
            this.btn_primeiro.Text = "<<";
            this.btn_primeiro.UseVisualStyleBackColor = true;
            this.btn_primeiro.Click += new System.EventHandler(this.btn_primeiro_Click);
            // 
            // CadastroPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 280);
            this.Controls.Add(this.pn_setas);
            this.Controls.Add(this.gp_cadastro);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroPagamentos";
            this.Text = "CadastroCommon";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.panel1.ResumeLayout(false);
            this.gp_cadastro.ResumeLayout(false);
            this.gp_cadastro.PerformLayout();
            this.pn_setas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.GroupBox gp_cadastro;
        private System.Windows.Forms.DateTimePicker dtp_vencimento;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Panel pn_setas;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primeiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_parcelas;
    }
}