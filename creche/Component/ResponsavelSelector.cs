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
    public partial class ResponsavelSelector : UserControl
    {
        private ResponsavelController responsavelController;

        public ResponsavelSelector()
        {
            InitializeComponent();
        }

        private void TurmaSelector_Load(object sender, EventArgs e)
        {
            if (this.responsavelController == null)
                this.responsavelController = new ResponsavelController();
            this.responsavelBindingSource.DataSource = this.responsavelController.LoadResponsavel();
            this.cb_responsavel.SelectedIndex = -1;
            this.cb_responsavel.SelectedItem = null;
        }

        private Responsavel _responsavel;
        public Responsavel Responsavel
        {
            get { return _responsavel; }
            set {
                this._responsavel = value;
                if (value != null)
                {
                    cb_responsavel.SelectedIndex = cb_responsavel.FindStringExact(value.ToString());
                }
            }
        }

        private void cb_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Responsavel = (Responsavel)this.cb_responsavel.SelectedValue;
        }
    }
}
