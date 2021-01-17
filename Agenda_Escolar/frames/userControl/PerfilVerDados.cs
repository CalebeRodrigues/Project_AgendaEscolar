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
    public partial class PerfilVerDados : Form
    {
        model.entities.Pessoa pessoa;

        public PerfilVerDados(model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;

            txtNome.Text = pessoa.getNome();
            txtCPF.Text = pessoa.getCPF().ToString();
            txtDataNascimento.Text = pessoa.getDataNascimento();
            txtUserName.Text = pessoa.getUserName();
        }

        private void PerfilVerDados_Load(object sender, EventArgs e)
        {

        }
    }
}
