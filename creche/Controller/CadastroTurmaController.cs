using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creche.Controller
{
    public class CadastroTurmaController
    {
        private readonly CrecheEntities banco = new CrecheEntities();

        public void Gravar(Turma _turma)
        {
            this.banco.Turmas.Add(_turma);
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

        public List<Turma> LoadTurmas()
        {
            return this.banco.Turmas.ToList();
        }
    }
}
