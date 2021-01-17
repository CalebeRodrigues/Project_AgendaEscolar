using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Escolar.frames.userControl
{
    public partial class PerfilAtualizaSenha : Form
    {

        model.entities.Pessoa pessoa;

        public PerfilAtualizaSenha(model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;
        }

        private void txtAtual_Enter(object sender, EventArgs e)
        {
            txtAtual.ForeColor = Color.Black;
            txtAtual.Text = "";
            txtAtual.PasswordChar = '*';
        }

        private void txtNova_Enter(object sender, EventArgs e)
        {
            txtNova.ForeColor = Color.Black;
            txtNova.Text = "";
            txtNova.PasswordChar = '*';
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if(pessoa.alterarSenha(txtAtual.Text, txtNova.Text))
            {
                MessageBox.Show("Senha alterada com sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar a senha. Verifique se os dados preenchidos estão corretos e tente novamente!",
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
