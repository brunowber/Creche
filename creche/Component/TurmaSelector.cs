using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using creche.Controller;
using creche;

namespace Creche.Component
{
    public partial class TurmaSelector : UserControl
    {
        private CadastroTurmaController cadastroTurmaController;

        public TurmaSelector()
        {
            InitializeComponent();
        }

        private void TurmaSelector_Load(object sender, EventArgs e)
        {
            if (this.cadastroTurmaController == null)
                this.cadastroTurmaController = new CadastroTurmaController();
            this.turmaBindingSource.DataSource = this.cadastroTurmaController.LoadTurmas();
        }

        private Turma _turma;
        public Turma Turma
        {
            get { return _turma; }
            set { this._turma = value; }
        }

        private void cb_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Turma = (Turma)this.cb_turma.SelectedValue;
        }
    }
}
