using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creche.Gui
{
    public partial class CadastraResponsavel : Form
    {
        private bool edit = false;
        public CadastraResponsavel()
        {
            InitializeComponent();
        }

        private void ChangeEnable()
        {
            this.btn_salvar.Enabled = edit;
            this.gb_turma.Enabled = edit;
            this.btn_novo.Enabled = !edit;
            this.btn_cancelar.Enabled = edit;
            this.pn_setas.Enabled = !edit;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.edit = true;
            this.ChangeEnable();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.edit = false;
            this.ChangeEnable();
        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {

        }
    }
}
