using creche.Gui.Visualizar;
using Creche.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno cadAluno = new CadastroAluno();
            cadAluno.Show();
        }

        private void TurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraTurma cadTurma = new CadastraTurma();
            cadTurma.Show();
        }

        private void responsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraResponsavel cadastraResponsavel = new CadastraResponsavel();
            cadastraResponsavel.Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPagamentos cadastroPagamentos = new CadastroPagamentos();
            cadastroPagamentos.Show();
        }

        private void pagamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarPagamentos visualizarPagamentos = new VisualizarPagamentos();
            visualizarPagamentos.Show();
        }
    }
}
