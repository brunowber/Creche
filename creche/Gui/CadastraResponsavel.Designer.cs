namespace Creche.Gui
{
    partial class CadastraResponsavel
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
            this.gb_turma = new System.Windows.Forms.GroupBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_setas = new System.Windows.Forms.Panel();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primeiro = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_ativo = new System.Windows.Forms.CheckBox();
            this.gb_turma.SuspendLayout();
            this.pn_setas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_turma
            // 
            this.gb_turma.Controls.Add(this.label4);
            this.gb_turma.Controls.Add(this.cb_ativo);
            this.gb_turma.Controls.Add(this.tb_nome);
            this.gb_turma.Controls.Add(this.tb_codigo);
            this.gb_turma.Controls.Add(this.label2);
            this.gb_turma.Controls.Add(this.label1);
            this.gb_turma.Enabled = false;
            this.gb_turma.Location = new System.Drawing.Point(12, 2);
            this.gb_turma.Name = "gb_turma";
            this.gb_turma.Size = new System.Drawing.Size(257, 120);
            this.gb_turma.TabIndex = 0;
            this.gb_turma.TabStop = false;
            this.gb_turma.Text = "Responsavel";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(47, 57);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(178, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Enabled = false;
            this.tb_codigo.Location = new System.Drawing.Point(48, 24);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(17, 167);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(58, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(81, 167);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(58, 23);
            this.btn_novo.TabIndex = 2;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(145, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pn_setas
            // 
            this.pn_setas.Controls.Add(this.btn_proximo);
            this.pn_setas.Controls.Add(this.btn_ultimo);
            this.pn_setas.Controls.Add(this.btn_anterior);
            this.pn_setas.Controls.Add(this.btn_primeiro);
            this.pn_setas.Location = new System.Drawing.Point(32, 128);
            this.pn_setas.Name = "pn_setas";
            this.pn_setas.Size = new System.Drawing.Size(219, 30);
            this.pn_setas.TabIndex = 4;
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
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(209, 167);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(58, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ativo:";
            // 
            // cb_ativo
            // 
            this.cb_ativo.AutoSize = true;
            this.cb_ativo.Checked = true;
            this.cb_ativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ativo.Enabled = false;
            this.cb_ativo.Location = new System.Drawing.Point(46, 91);
            this.cb_ativo.Name = "cb_ativo";
            this.cb_ativo.Size = new System.Drawing.Size(15, 14);
            this.cb_ativo.TabIndex = 10;
            this.cb_ativo.UseVisualStyleBackColor = true;
            // 
            // CadastraResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 206);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pn_setas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.gb_turma);
            this.Name = "CadastraResponsavel";
            this.Text = "CadastraResponsavel";
            this.gb_turma.ResumeLayout(false);
            this.gb_turma.PerformLayout();
            this.pn_setas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_turma;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_setas;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primeiro;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_ativo;
    }
}