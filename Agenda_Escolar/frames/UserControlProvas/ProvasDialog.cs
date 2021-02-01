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
            this.provas = provas;
            txtNomeJanela.Text = functionJanela;
            txtNome.Text = provas.getNome();
            txtData.Text = provas.getData();

            btnFunction.Text = "Salvar";
        }

        private void adicionarProva ()
        {
            int cont;

            if(pessoa.getProvas().Count == 0)
            {
                cont = 1;
            }
            else
            {
                cont = pessoa.getProvas().Count + 1;
            }

            provas = new model.entities.Provas(cont, txtNome.Text, txtData.Text);

            pessoa.getProvas().Add(provas);

            MessageBox.Show("Prova adicionada com sucesso!");
        }

        private void editarProva()
        {
            provas.setNome(txtNome.Text);
            provas.setData(txtData.Text);
            MessageBox.Show("Alterado com sucesso.");
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (btnFunction.Text == "Adicionar") { adicionarProva(); }

            else if (btnFunction.Text == "Salvar") { editarProva(); }

            Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
