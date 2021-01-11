using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Escolar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            label1.Select();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
            txtSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String op = MessageBox.Show("Desejas fechar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();

            if (op == "Yes") Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

        }
    }
}
