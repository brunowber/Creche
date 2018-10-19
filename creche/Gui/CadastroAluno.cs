using creche;
using creche.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creche.Gui
{
    public partial class CadastroAluno : Form
    {
        private bool edit = false;
        private bool atualiza = false;
        private List<Crianca> criancasLista;
        private int indiceAtual = 0;
        private string _error = String.Empty;
        private CriancasController criancaController;

        public CadastroAluno()
        {
            InitializeComponent();
        }

        public virtual void Clear()
        {
            this.tb_nome.Text = String.Empty;
            this.dtp_nascimento.Value = DateTime.Now;
            //this.turma_selector.
            this.cb_feminino.Checked = false;
            this.cb_masculino.Checked = false;
        }

        public virtual void ChangeEnable()
        {
            this.btn_salvar.Enabled = edit;
            this.gp_cadastro.Enabled = edit;
            this.btn_novo.Enabled = !edit;
            this.btn_modificar.Enabled = atualiza;
            this.btn_cancelar.Enabled = edit;
            //this.pn_setas.Enabled = !edit;
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            this.edit = true;
            this.ChangeEnable();
            this.Clear();
            
        }

        private bool Valida()
        {
            if (tb_nome.Text == "")
            {
                this._error = "Campo nome não pode estar vazio";
                return false;
            }
            if (cb_feminino.CheckState == this.cb_masculino.CheckState)
            {
                this._error = "É necessário escolher um sexo";
                return false;
            }
            if (turma_selector.Turma == null)
            {
                this._error = "Nenhuma turma escolhida";
                return false;
            }
            if (responsavel_selector.Responsavel.Uid_responsavel == 0)
            {
                this._error = "Nenhum responsavel escolhido";
                return false;
            }
            return true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show(this._error);
                return;
            }
            Crianca aluno = new Crianca
            {
                Nome = tb_nome.Text,
                Dt_nasc = dtp_nascimento.Value,
                Uid_turma = this.turma_selector.Turma.Uid_turma,
                Ativo = this.cb_ativo.Checked,
            };
            if (this.cb_masculino.CheckState == CheckState.Checked)
                aluno.Sexo = "M";
            else
                aluno.Sexo = "F";
            Responsavel responsavel = this.responsavel_selector.Responsavel;
            if (!atualiza)
            {
                this.criancaController.Gravar(aluno, responsavel);
                MessageBox.Show("Crianca inserida com sucesso");
            }
            else
            {
                aluno.Uid_crianca = Convert.ToInt64(this.tb_codigo.Text);
                this.criancaController.Update(aluno);
                MessageBox.Show("Crianca alterada com sucesso");
            }
            criancasLista = this.criancaController.LoadCriancas();
            this.Clear();
            this.edit = this.atualiza = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            //this.Preencher(this.indiceAtual);
        }

        private void cb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_masculino.CheckState == CheckState.Checked)
                this.cb_feminino.Checked = false;
        }

        private void cb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_feminino.CheckState == CheckState.Checked)
                this.cb_masculino.Checked = false;
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            if (this.criancaController == null)
                this.criancaController = new CriancasController();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

        }
    }
}
