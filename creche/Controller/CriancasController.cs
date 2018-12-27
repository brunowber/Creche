using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creche.Controller
{
    public class CriancasController
    {
        private CrecheEntities banco = new CrecheEntities();

        public void Gravar(Crianca _crianca, long _uidResponsavel)
        {
            this.banco.Criancas.Add(_crianca);
            Responsavel resp = this.ProcurarResponsavelPorUid(_uidResponsavel);
            resp.Criancas.Add(_crianca);
            this.banco.SaveChanges();
        }

        public void GravarPagamento(long _uid, Pagamento pagamento)
        {
            Crianca cria = this.ProcurarCriancaPorUid(_uid);
            cria.Pagamentos.Add(pagamento);
            this.banco.SaveChanges();
        }

        public void Update(Crianca _crianca, long _uidReponsavel)
        {
            Crianca cria = this.ProcurarCriancaPorUid(_crianca.Uid_crianca);
            this.banco.Criancas.Attach(cria);
            Responsavel resp = this.ProcurarResponsavelPorUid(_uidReponsavel);
            cria.Responsavels = new List<Responsavel>();
            cria.Nome = _crianca.Nome;
            cria.Sexo = _crianca.Sexo;
            cria.Ativo = _crianca.Ativo;
            cria.Dt_nasc = _crianca.Dt_nasc;
            cria.Uid_turma = _crianca.Uid_turma;
            resp.Criancas.Add(cria);
            this.banco.SaveChanges();
        }

        public void DeletarPagamento(long _uidPagamento)
        {
            Pagamento pagamento = this.ProcurarPagamentoPorUid(_uidPagamento);
            this.banco.Pagamentos.Remove(pagamento);
            this.banco.SaveChanges();
        }

        public void UpdatePagamento(decimal valorReceber, long _uidPagamento)
        {
            Pagamento pagamento = this.ProcurarPagamentoPorUid(_uidPagamento);
            pagamento.Valor_recebido = valorReceber;
            this.banco.SaveChanges();
        }

        public bool Exist(long _uidCrianca)
        {
            return this.banco.Criancas.Any(Crianca => Crianca.Uid_crianca== _uidCrianca);
        }

        public Crianca ProcurarCriancaPorUid(long _uidCrianca)
        {
            return this.banco.Criancas.Where(c => c.Uid_crianca == _uidCrianca).FirstOrDefault();
        }

        public Pagamento ProcurarPagamentoPorUid(long _uidPagamento)
        {
            return this.banco.Pagamentos.Where(c => c.Uid_pagamento == _uidPagamento).FirstOrDefault();
        }

        public Responsavel ProcurarResponsavelPorUid(long _uidResponsavel)
        {
            return this.banco.Responsavels.Where(c => c.Uid_responsavel == _uidResponsavel).FirstOrDefault();
        }

        public Turma ProcurarTurmaPorUid(long _uidResponsavel)
        {
            return this.banco.Turmas.Where(c => c.Uid_turma == _uidResponsavel).FirstOrDefault();
        }

        public List<Crianca> LoadCriancas()
        {
            return this.banco.Criancas.OrderBy(o => o.Nome).ToList();
        }

        public List<Crianca> ProcuraCriancasPorTurma(long _uidTurma)
        {
            return this.banco.Criancas.Where(c => c.Turma.Uid_turma == _uidTurma && c.Ativo == true).ToList();
        }

        public List<Crianca> ProcuraCriancasPorResponsavel(long _uidResponsavel)
        {
            return this.banco.Criancas.Where(c => c.Responsavels.FirstOrDefault().Uid_responsavel == _uidResponsavel && c.Ativo == true).ToList();
        }

        public List<Crianca> ProcuraCriancasPorNome(string nome)
        {
            return this.banco.Criancas.Where(c => c.Nome == nome && c.Ativo == true).ToList();
        }

        public Pagamento ProcuraPagamentoPorAluno(Crianca crianca)
        {
            return this.banco.Pagamentos.Where(c => c.Uid_crianca == crianca.Uid_crianca && c.Crianca.Ativo == true).FirstOrDefault();
        }

        public List<Pagamento> ProcuraPagamentoPorData(DateTime começo, DateTime fim)
        {
            return this.banco.Pagamentos.Where(c => c.Dt_vencimento >= começo && c.Dt_vencimento <= fim && c.Crianca.Ativo == true).ToList();
        }
    }
}
