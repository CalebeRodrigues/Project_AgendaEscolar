using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Escolar.frames.UserControlProvas
{
    public partial class ProvasDialog : Form
    {
        model.entities.Provas provas;
        model.entities.Pessoa pessoa;

        public ProvasDialog(String functionJanela, model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;

            txtNomeJanela.Text = functionJanela;
            btnFunction.Text = "Adicionar";
            
        }

        public ProvasDialog(String functionJanela, model.entities.Provas provas)
        {
            InitializeComponent();
            

        }

        private void adicionarProva ()
        {
            provas = new model.entities.Provas(pessoa.getProvas().Count() + 1, txtNome.Text, txtData.Text);

            pessoa.getProvas().Add(provas);
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (btnFunction.Text == "Adicionar") { adicionarProva(); }

            Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
