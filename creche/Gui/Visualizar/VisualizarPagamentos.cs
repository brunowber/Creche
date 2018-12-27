using creche.Controller;
using creche.Dataset;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace creche.Gui.Visualizar
{
    public partial class VisualizarPagamentos : Form
    {
        private CriancasController criancaController;
        private decimal quantoFalta = 0;

        public VisualizarPagamentos()
        {
            InitializeComponent();
        }

        private void btn_nome_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            List<Crianca> crianca = this.criancaController.ProcuraCriancasPorNome(this.tb_nome.Text);
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                quantoFalta = 0;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
                this.CalculaQuantoFalta();
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        public void Populate(Crianca crianca)
        {
            foreach (Pagamento pagamento in crianca.Pagamentos)
            {
                PagamentoDataSet.PagamentoRow pagData = this.pagamentoDataSet.Pagamento.NewPagamentoRow();
                pagData.Codigo_crianca = crianca.Uid_crianca;
                pagData.Nome = crianca.Nome;
                pagData.Codigo_pagamento = pagamento.Uid_pagamento;
                pagData.Data = pagamento.Dt_vencimento.Value;
                pagData.Valor = pagamento.Valor.Value;
                pagData.Valor_receber = pagamento.Valor_recebido.Value;
                pagData.Recebido = pagData.Valor_receber >= pagData.Valor;
                this.pagamentoDataSet.Pagamento.AddPagamentoRow(pagData);
            }
        }

        private void VisualizarPagamentos_Load(object sender, EventArgs e)
        {
            if (criancaController == null)
                criancaController = new CriancasController();
            this.dtp_fim.Value = this.dtp_fim.Value.AddMonths(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            foreach (PagamentoDataSet.PagamentoRow pagData in this.pagamentoDataSet.Pagamento)
            {
                this.criancaController.UpdatePagamento(pagData.Valor_receber, pagData.Codigo_pagamento);
            }
            MessageBox.Show("Contas pagadas com sucesso");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dg_pagamento.IsCurrentCellDirty)
                    dg_pagamento.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if ((bool)dg_pagamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == false)
                    dg_pagamento.Rows[e.RowIndex].Cells[2].Value = dg_pagamento.Rows[e.RowIndex].Cells[1].Value;
                else
                    dg_pagamento.Rows[e.RowIndex].Cells[2].Value = "0";
            }

        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            List<Crianca> crianca = this.criancaController.LoadCriancas();
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                quantoFalta = 0;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
                this.CalculaQuantoFalta();
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_pai_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            if (responsavelSelector.Responsavel == null)
                return;
            List<Crianca> crianca = this.criancaController.ProcuraCriancasPorResponsavel(responsavelSelector.Responsavel.Uid_responsavel);
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
                this.CalculaQuantoFalta();
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_turma_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            if (turmaSelector.Turma == null)
                return;
            List<Crianca> crianca = this.criancaController.ProcuraCriancasPorTurma(turmaSelector.Turma.Uid_turma);
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
                this.CalculaQuantoFalta();
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            List<Pagamento> pagamentos = this.criancaController.ProcuraPagamentoPorData(dtp_começo.Value, dtp_fim.Value);
            foreach (Pagamento pag in pagamentos)
            {
                PagamentoDataSet.PagamentoRow pagData = this.pagamentoDataSet.Pagamento.NewPagamentoRow();
                pagData.Codigo_crianca = pag.Uid_crianca.Value;
                pagData.Nome = this.criancaController.ProcurarCriancaPorUid(pag.Uid_crianca.Value).Nome;
                pagData.Codigo_pagamento = pag.Uid_pagamento;
                pagData.Data = pag.Dt_vencimento.Value;
                pagData.Valor = pag.Valor.Value ;
                pagData.Valor_receber = pag.Valor_recebido.Value;
                pagData.Recebido = pagData.Valor_receber >= pagData.Valor;
                this.pagamentoDataSet.Pagamento.AddPagamentoRow(pagData);
            }
            this.CalculaQuantoFalta();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            long uidPagamento = (long)dg_pagamento.Rows[dg_pagamento.CurrentCell.RowIndex].Cells[5].Value;
            this.dg_pagamento.Rows.RemoveAt(dg_pagamento.CurrentCell.RowIndex);
            this.criancaController.DeletarPagamento(uidPagamento);
            MessageBox.Show("Conta deleteda com sucesso");
            this.pagamentoDataSet.AcceptChanges();
        }

        private void dg_pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                this.btn_deletar.PerformClick();
        }

        private void dg_pagamento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.CalculaQuantoFalta();
        }

        private void CalculaQuantoFalta()
        {
            this.quantoFalta = 0;
            decimal ganho = 0;
            this.lbl_falta.Text = "";
            foreach (PagamentoDataSet.PagamentoRow pagData in this.pagamentoDataSet.Pagamento)
            {
                this.quantoFalta += pagData.Valor - pagData.Valor_receber;
                ganho += pagData.Valor_receber;
            }
            if (quantoFalta > 0)
            {
                this.lbl_falta.ForeColor = Color.Red;
                this.lbl_falta.Text += "-";
            }
            else
                this.lbl_falta.ForeColor = Color.Green;
            this.lbl_falta.Text += quantoFalta.ToString() + "R$";
            this.lbl_ganho.Text = ganho.ToString() + "R$";

            foreach (DataGridViewRow row in dg_pagamento.Rows)
            {
                if (Convert.ToDecimal(row.Cells[2].Value) < Convert.ToDecimal(row.Cells[1].Value))
                    row.DefaultCellStyle.BackColor = Color.Red;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

        }
    }
}
