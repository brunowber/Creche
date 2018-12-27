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
    public partial class CadastroPagamentos : Form
    {
        private bool edit = false;
        private List<Crianca> criancasLista;
        private int indiceAtual = 0;
        private string _error = String.Empty;
        private CriancasController criancaController;

        public CadastroPagamentos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        public virtual void Clear()
        {
            this.tb_parcelas.Text = "1";
            this.mtb_valor.Text = "";
            this.dtp_vencimento.Value = DateTime.Now;
        }

        public virtual void ChangeEnable()
        {
            this.btn_salvar.Enabled = edit;
            this.gp_cadastro.Enabled = edit;
            this.btn_modificar.Enabled = !edit;
            this.btn_cancelar.Enabled = edit;
            this.pn_setas.Enabled = !edit;
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            this.edit = true;
            this.ChangeEnable();
            this.Clear();
        }

        private bool Valida()
        {
            if (tb_parcelas.Text == "")
            {
                this._error = "Campo parcelas não pode estar vazio";
                return false;
            }
            if (this.mtb_valor.Text.Length < 8)
            {
                this._error = "Campo valor tem que estar completo";
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
            long uid = Convert.ToInt64(this.tb_codigo.Text);
            for (int i = 0; i < Convert.ToInt32(tb_parcelas.Text); i++)
            {
                Pagamento pagamento = new Pagamento
                {
                    Valor = Convert.ToDecimal(this.mtb_valor.Text.Substring(2, 6)),
                    Dt_vencimento = this.dtp_vencimento.Value,
                    Valor_recebido = 0
                };
                this.criancaController.GravarPagamento(uid, pagamento);
                this.dtp_vencimento.Value = this.dtp_vencimento.Value.AddMonths(1);
            }
            MessageBox.Show("Pagamento inserida com sucesso");
            criancasLista = this.criancaController.LoadCriancas();
            this.Clear();
            this.edit = false;
            this.ChangeEnable();
            this.btn_modificar.Enabled = true;
            this.Preencher(this.indiceAtual);
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
            this.edit = true;
            this.ChangeEnable();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.edit = false;
            this.ChangeEnable();
            this.Clear();
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
            }
        }

        private void tb_parcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
