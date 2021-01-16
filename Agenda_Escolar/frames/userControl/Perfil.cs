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
    public partial class Perfil : Form
    {
        model.entities.Pessoa pessoa;

        public Perfil(model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;

            txtNome.Text = pessoa.getNome();
            txtCPF.Text = pessoa.getCPF().ToString();
            txtDataNascimento.Text = pessoa.getDataNascimento();
            txtUserName.Text = pessoa.getUserName();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado!");
        }
    }
}
