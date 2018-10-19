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

        public void Gravar(Crianca _crianca, Responsavel _responsavel)
        {
            _responsavel.Criancas.Add(_crianca);
            this.banco.SaveChanges();
        }

        public void Update(Crianca _crianca)
        {
            Crianca turma = this.ProcurarCriancaPorUid(_crianca.Uid_crianca);
            //turma.Descricao = _turma.Descricao;
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

        public List<Crianca> LoadCriancas()
        {
            return this.banco.Criancas.ToList();
        }
    }
}
