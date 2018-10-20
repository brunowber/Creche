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
            this.cb_feminino.Checked = false;
            this.cb_masculino.Checked = false;
            this.cb_ativo.Checked = true;
        }

        public virtual void ChangeEnable()
        {
            this.btn_salvar.Enabled = edit;
            this.gp_cadastro.Enabled = edit;
            this.btn_novo.Enabled = !edit;
            this.btn_modificar.Enabled = atualiza;
            this.btn_cancelar.Enabled = edit;
            this.pn_setas.Enabled = !edit;
            this.cb_ativo.Enabled = atualiza;
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
            if (responsavel_selector.Responsavel == null)
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
            long uidResponsavel = this.responsavel_selector.Responsavel.Uid_responsavel;
            if (!atualiza)
            {
                this.criancaController.Gravar(aluno, uidResponsavel);
                MessageBox.Show("Crianca inserida com sucesso");
            }
            else
            {
                aluno.Uid_crianca = Convert.ToInt64(this.tb_codigo.Text);
                this.criancaController.Update(aluno, uidResponsavel);
                MessageBox.Show("Crianca alterada com sucesso");
            }
            criancasLista = this.criancaController.LoadCriancas();
            this.Clear();
            this.edit = this.atualiza = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
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
            this.criancasLista = criancaController.LoadCriancas();
            if(this.criancasLista.Count > 0)
            {
                this.Preencher(this.indiceAtual);
                this.btn_modificar.Enabled = true;
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.atualiza = this.edit = true;
            this.ChangeEnable();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.edit = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            if (this.criancasLista.Count > 0)
            {
                indiceAtual = 0;
                Preencher(indiceAtual);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (indiceAtual > 0)
            {
                indiceAtual -= 1;
                Preencher(indiceAtual);
            }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (indiceAtual < this.criancasLista.Count - 1)
            {
                indiceAtual += 1;
                Preencher(indiceAtual);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            if (this.criancasLista.Count > 0)
            {
                indiceAtual = this.criancasLista.Count - 1;
                Preencher(indiceAtual);
            }
        }

        public void Preencher(int index)
        {
            if (this.criancasLista.Count > 0)
            {
                Crianca crianca = criancasLista[index];
                this.tb_codigo.Text = Convert.ToString(crianca.Uid_crianca);
                this.tb_nome.Text = crianca.Nome;
                this.dtp_nascimento.Value = crianca.Dt_nasc.Value;
                if (crianca.Sexo == "M")
                    this.cb_masculino.Checked = true;
                else
                    this.cb_feminino.Checked = true;
                this.cb_ativo.Checked = crianca.Ativo.Value;
                this.turma_selector.Turma = crianca.Turma;
                this.responsavel_selector.Responsavel = crianca.Responsavels.FirstOrDefault();
                this.turma_selector.Turma = crianca.Turma;
            }
        }
    }
}
