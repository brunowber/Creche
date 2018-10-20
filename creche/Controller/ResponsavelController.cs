using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creche.Controller
{
    public class ResponsavelController
    {
        private readonly CrecheEntities banco = new CrecheEntities();

        public void Gravar(Responsavel _responsavel)
        {
            this.banco.Responsavels.Add(_responsavel);
            this.banco.SaveChanges();
        }

        public void Update(Responsavel _responsavel)
        {
            Responsavel responsavel = this.ProcurarResponsavelPorUid(_responsavel.Uid_responsavel);
            responsavel.Nome = _responsavel.Nome;
            responsavel.Ativo = _responsavel.Ativo;
            responsavel.Telefones.Clear();
            responsavel.Telefones = _responsavel.Telefones;
            this.banco.SaveChanges();
        }

        public bool Exist(long _uidTurma)
        {
            return this.banco.Turmas.Any(Turma => Turma.Uid_turma == _uidTurma);
        }

        public Responsavel ProcurarResponsavelPorUid(long _uidResponsavel)
        {
            return this.banco.Responsavels.Where(c => c.Uid_responsavel == _uidResponsavel).FirstOrDefault();
        }

        public List<Responsavel> LoadResponsavel()
        {
            return this.banco.Responsavels.ToList();
        }
    }
}
