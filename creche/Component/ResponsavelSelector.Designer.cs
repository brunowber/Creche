namespace Creche.Component
{
    partial class ResponsavelSelector
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
            this.cb_responsavel = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_turma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_responsavel
            // 
            this.cb_responsavel.DataSource = this.responsavelBindingSource;
            this.cb_responsavel.FormattingEnabled = true;
            this.cb_responsavel.Location = new System.Drawing.Point(76, 3);
            this.cb_responsavel.Name = "cb_responsavel";
            this.cb_responsavel.Size = new System.Drawing.Size(239, 21);
            this.cb_responsavel.TabIndex = 0;
            this.cb_responsavel.SelectedIndexChanged += new System.EventHandler(this.cb_turma_SelectedIndexChanged);
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(2, 6);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(72, 13);
            this.lbl_turma.TabIndex = 1;
            this.lbl_turma.Text = "Responsavel:";
            // 
            // ResponsavelSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_turma);
            this.Controls.Add(this.cb_responsavel);
            this.Name = "ResponsavelSelector";
            this.Size = new System.Drawing.Size(327, 26);
            this.Load += new System.EventHandler(this.TurmaSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_responsavel;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
    }
}
