namespace Creche.Component
{
    partial class CriancaSelector
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_crianca = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_crianca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_crianca
            // 
            this.cb_crianca.DataSource = this.responsavelBindingSource;
            this.cb_crianca.FormattingEnabled = true;
            this.cb_crianca.Location = new System.Drawing.Point(49, 2);
            this.cb_crianca.Name = "cb_crianca";
            this.cb_crianca.Size = new System.Drawing.Size(239, 21);
            this.cb_crianca.TabIndex = 0;
            this.cb_crianca.SelectedIndexChanged += new System.EventHandler(this.cb_turma_SelectedIndexChanged);
            // 
            // lbl_crianca
            // 
            this.lbl_crianca.AutoSize = true;
            this.lbl_crianca.Location = new System.Drawing.Point(2, 6);
            this.lbl_crianca.Name = "lbl_crianca";
            this.lbl_crianca.Size = new System.Drawing.Size(46, 13);
            this.lbl_crianca.TabIndex = 1;
            this.lbl_crianca.Text = "Crianca:";
            // 
            // CriancaSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_crianca);
            this.Controls.Add(this.cb_crianca);
            this.Name = "CriancaSelector";
            this.Size = new System.Drawing.Size(292, 26);
            this.Load += new System.EventHandler(this.TurmaSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_crianca;
        private System.Windows.Forms.Label lbl_crianca;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
    }
}
