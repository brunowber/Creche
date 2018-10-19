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

        public bool Exist(long _uidCrianca)
        {
            return this.banco.Criancas.Any(Crianca => Crianca.Uid_crianca== _uidCrianca);
        }

        public Crianca ProcurarCriancaPorUid(long _uidCrianca)
        {
            return this.banco.Criancas.Where(c => c.Uid_crianca == _uidCrianca).FirstOrDefault();
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
            return this.banco.Criancas.ToList();
        }
    }
}
