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

        public void Update(Turma _turma)
        {
            Turma turma = this.ProcurarTurmaPorUid(_turma.Uid_turma);
            turma.Descricao = _turma.Descricao;
            this.banco.SaveChanges();
        }

        public bool Exist(long _uidTurma)
        {
            return this.banco.Turmas.Any(Turma => Turma.Uid_turma == _uidTurma);
        }

        public Turma ProcurarTurmaPorUid(long _uidTurma)
        {
            return this.banco.Turmas.Where(c => c.Uid_turma == _uidTurma).FirstOrDefault();
        }

        public List<Responsavel> LoadResponsavel()
        {
            return this.banco.Responsavels.ToList();
        }
    }
}
