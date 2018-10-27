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
    public partial class CadastraTurma : Form
    {
        private CadastroTurmaController cadastroTurmaController;
        private bool edit = false;
        private bool atualiza = false;
        private string _error = string.Empty;
        private List<Turma> turmaLista;
        private int indiceAtual = 0;

        public CadastraTurma()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void ChangeEnable()
        {
            this.btn_salvar.Enabled = edit;
            this.gb_turma.Enabled = edit;
            this.btn_novo.Enabled = !edit;
            this.btn_modificar.Enabled = atualiza;
            this.btn_cancelar.Enabled = edit;
            this.pn_setas.Enabled = !edit;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.edit = true;
            this.ChangeEnable();
            this.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.edit = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
        }

        private void CadastraTurma_Load(object sender, EventArgs e)
        {
            if (this.cadastroTurmaController == null)
                this.cadastroTurmaController = new CadastroTurmaController();
            this.turmaLista = this.cadastroTurmaController.LoadTurmas();
            if (this.turmaLista.Count > 0)
            {
                this.btn_modificar.Enabled = true;
                this.Preencher(0);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show(this._error);
                return;
            }
            Turma aluno = new Turma
            {
                Descricao = tb_nome.Text,
            };
            if (!atualiza)
            {
                this.cadastroTurmaController.Gravar(aluno);
                MessageBox.Show("Turma criada com sucesso");
            }
            else
            {
                aluno.Uid_turma = Convert.ToInt64(this.tb_codigo.Text);
                this.cadastroTurmaController.Update(aluno);
                MessageBox.Show("Turma modificada com sucesso");
            }
            turmaLista = this.cadastroTurmaController.LoadTurmas();
            this.Clear();
            this.edit = this.atualiza = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
        }

        private void Clear()
        {
            this.tb_codigo.Text = "";
            this.tb_nome.Text = "";
        }

        private bool Valida()
        {
            if (tb_nome.Text == "")
            {
                this._error = "Campo nome não pode estar vazio";
                return false;
            }
            return true;
        }

        public void Preencher(int index)
        {
            if (this.turmaLista.Count > 0)
            {
                Turma turma = turmaLista[index];
                this.tb_codigo.Text = Convert.ToString(turma.Uid_turma);
                this.tb_nome.Text = turma.Descricao;
            }
        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            if (this.turmaLista.Count > 0)
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
            if (indiceAtual < this.turmaLista.Count - 1)
            {
                indiceAtual += 1;
                Preencher(indiceAtual);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            if (this.turmaLista.Count > 0)
            {
                indiceAtual = this.turmaLista.Count - 1;
                Preencher(indiceAtual);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.atualiza = this.edit = true;
            this.ChangeEnable();
        }
    }
}
