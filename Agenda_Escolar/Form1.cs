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

        model.entities.Pessoa pessoa;

        public Login()
        {
            InitializeComponent();

            pessoa = new model.entities.Pessoa(0, 0, null, null, "caca", "caca123");
            
            label1.Select();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Digite seu usuario")
            {
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.Text = "";
            }                      
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.Silver;
                txtUsuario.Text = "Digite seu usuario";
            }
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
            model.entities.Pessoa pessoa2 = new model.entities.Pessoa(0, 0, null, "Calebe", 
                                                                        txtUsuario.Text, txtSenha.Text);

            if(pessoa.Equals(pessoa2) == true)
            {
                MessageBox.Show("Seja bem vindo " + pessoa2.getNome() + "!", "Acesso autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frames.user.Inicio inicio = new frames.user.Inicio(pessoa);
                Hide();
                inicio.ShowDialog();
                resetForm(this);
            }
            else
            {
                MessageBox.Show("Usuario não reconhecido!");
            }
        }

        private void resetForm(Login login)
        {
            login = new Login();
            login.ShowDialog();
        }
    }
}
