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
    public partial class CadastraResponsavel : Form
    {
        private bool edit = false;
        private bool atualiza = false;
        private List<Responsavel> responsavelLista;
        private int indiceAtual = 0;
        private string _error = String.Empty;
        private ResponsavelController responsavelController;

        public CadastraResponsavel()
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
            this.btn_cancelar.Enabled = edit;
            this.pn_setas.Enabled = !edit;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.edit = true;
            this.Clear();
            this.ChangeEnable();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.edit = false;
            this.ChangeEnable();
        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            if (this.responsavelLista.Count > 0)
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
            if (indiceAtual < this.responsavelLista.Count - 1)
            {
                indiceAtual += 1;
                Preencher(indiceAtual);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            if (this.responsavelLista.Count > 0)
            {
                indiceAtual = this.responsavelLista.Count - 1;
                Preencher(indiceAtual);
            }
        }

        private void CadastraResponsavel_Load(object sender, EventArgs e)
        {
            if (this.responsavelController == null)
                this.responsavelController = new ResponsavelController();
            responsavelLista = this.responsavelController.LoadResponsavel();
            if (responsavelLista.Count > 0)
            {
                this.Preencher(this.indiceAtual);
                this.btn_modificar.Enabled = true;
            }

        }

        public void Preencher(int index)
        {
            if (this.responsavelLista.Count > 0)
            {
                Responsavel responsavel = responsavelLista[index];
                this.tb_codigo.Text = Convert.ToString(responsavel.Uid_responsavel);
                this.tb_nome.Text = responsavel.Nome;
                this.cb_ativo.Checked = responsavel.Ativo.Value;
                if (responsavel.Telefones.Count > 0)
                    mtb_telefone1.Text = responsavel.Telefones.First().Numero;
                else
                    mtb_telefone1.Text = String.Empty;
                if (responsavel.Telefones.Count > 1)
                    mtb_telefone2.Text = responsavel.Telefones.Last().Numero;
                else
                    mtb_telefone2.Text = String.Empty;
            }
        }
        
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show(this._error);
                return;
            }
            Responsavel responsavel = new Responsavel
            {
                Nome = this.tb_nome.Text,
                Ativo = this.cb_ativo.Checked,
            };
            responsavel.Telefones.Clear();
            if (mtb_telefone1.Text.Length > 14)
            {
                Telefone telefone = new Telefone();
                telefone.Numero = mtb_telefone1.Text;
                responsavel.Telefones.Add(telefone);
            }
            if (mtb_telefone2.Text.Length > 14)
            {
                Telefone telefone2 = new Telefone();
                telefone2.Numero = mtb_telefone2.Text;
                responsavel.Telefones.Add(telefone2);
            }
            if (!atualiza)
            {
                this.responsavelController.Gravar(responsavel);
                MessageBox.Show("Responsavel inserida com sucesso");
            }
            else
            {
                responsavel.Uid_responsavel= Convert.ToInt64(this.tb_codigo.Text);
                this.responsavelController.Update(responsavel);
                MessageBox.Show("Crianca alterada com sucesso");
            }
            responsavelLista = this.responsavelController.LoadResponsavel();
            this.Clear();
            this.edit = this.atualiza = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
        }

        public virtual void Clear()
        {
            this.tb_nome.Text = String.Empty;
            this.tb_codigo.Text = String.Empty;
            this.mtb_telefone1.Text = String.Empty;
            this.mtb_telefone2.Text = String.Empty;
            this.cb_ativo.Checked = true;
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.atualiza = this.edit = true;
            this.ChangeEnable();
        }
    }
}
