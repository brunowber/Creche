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
    public partial class CriancaSelector : UserControl
    {
        private CriancasController criancaController;

        public CriancaSelector()
        {
            InitializeComponent();
        }

        private void TurmaSelector_Load(object sender, EventArgs e)
        {
            if (this.criancaController == null)
                this.criancaController = new CriancasController();
            this.responsavelBindingSource.DataSource = this.criancaController.LoadCriancas();
            this.cb_crianca.SelectedIndex = -1;
            this.cb_crianca.SelectedItem = null;
        }

        private Crianca _crianca;
        public Crianca Crianca
        {
            get { return _crianca; }
            set {
                this._crianca = value;
                if (value != null)
                {
                    cb_crianca.SelectedIndex = cb_crianca.FindStringExact(value.ToString());
                }
            }
        }

        private void cb_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Crianca = (Crianca)this.cb_crianca.SelectedValue;
        }
    }
}
