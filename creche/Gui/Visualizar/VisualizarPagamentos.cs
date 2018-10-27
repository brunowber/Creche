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
                pagData.Recebido = false;
                this.pagamentoDataSet.Pagamento.AddPagamentoRow(pagData);
                quantoFalta += pagamento.Valor.Value - pagamento.Valor_recebido.Value;
            }
            if (quantoFalta > 0)
                this.lbl_falta.ForeColor = Color.Red;
            this.lbl_falta.Text = "-"+quantoFalta.ToString()+"R$";
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
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_pai_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            List<Crianca> crianca = this.criancaController.ProcuraCriancasPorResponsavel(responsavelSelector.Responsavel.Uid_responsavel);
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                quantoFalta = 0;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_turma_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            List<Crianca> crianca = this.criancaController.ProcuraCriancasPorTurma(turmaSelector.Turma.Uid_turma);
            if (crianca.Count > 0)
            {
                this.btn_salvar.Enabled = this.btn_deletar.Enabled = true;
                quantoFalta = 0;
                foreach (Crianca cria in crianca)
                    this.Populate(cria);
            }
            else
                MessageBox.Show("Não foi encontrado nenhuma criança");
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            this.pagamentoDataSet.Clear();
            this.quantoFalta = 0;
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
                pagData.Recebido = false;
                this.pagamentoDataSet.Pagamento.AddPagamentoRow(pagData);
                quantoFalta += pag.Valor.Value - pag.Valor_recebido.Value;
            }
            if (quantoFalta > 0)
                this.lbl_falta.ForeColor = Color.Red;
            this.lbl_falta.Text = "-" + quantoFalta.ToString() + "R$";
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            long uidPagamento = (long)dg_pagamento.Rows[dg_pagamento.CurrentCell.RowIndex].Cells[5].Value;
            this.dg_pagamento.Rows.RemoveAt(dg_pagamento.CurrentCell.RowIndex);
            this.criancaController.DeletarPagamento(uidPagamento);
            MessageBox.Show("Conta deleteda com sucesso");
            this.pagamentoDataSet.AcceptChanges();
        }
    }
}
