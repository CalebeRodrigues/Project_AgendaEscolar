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

        List<model.entities.Pessoa> pessoa = new List<model.entities.Pessoa>();
        int ID = 0;

        public Login()
        {
            InitializeComponent();

            pessoa.Add(new model.entities.Pessoa
                            (0, 11111111111, "27/11/2002", "Calebe Barros Rodrigues", "caca", "caca123"));
            
            label1.Select();
        }

        public void atualizaList(model.entities.Pessoa pessoa)
        {
            foreach (model.entities.Pessoa p in this.pessoa)
            {
                if (pessoa.getID() == p.getID())
                {
                    this.pessoa.Remove(p);
                    this.pessoa.Add(pessoa);
                    break;
                }
            }            
        }

        private bool verificaLogin(model.entities.Pessoa test)
        {
            foreach (model.entities.Pessoa list in pessoa){
                if (list.Equals(test)){
                    return true;
                }
            }
            return false;
        }

        private model.entities.Pessoa GetPessoa (model.entities.Pessoa pessoaTest)
        {
            foreach (model.entities.Pessoa list in pessoa)
            {
                if (list.Equals(pessoaTest))
                {
                    pessoaTest = list;
                    return list;
                }
            }

            return null;
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
            model.entities.Pessoa pessoaLogin = new model.entities.Pessoa(0, 00000000000, null,
                                    null, txtUsuario.Text, txtSenha.Text);

            if(verificaLogin(pessoaLogin))
            {
                pessoaLogin = GetPessoa(pessoaLogin);
                MessageBox.Show("Seja bem vindo " + pessoaLogin.getNome() + "!", "Acesso autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frames.user.Inicio inicio = new frames.user.Inicio(pessoaLogin, this);
                Hide();
                inicio.ShowDialog();
                resetForm(this);
            }
            else
            {
                MessageBox.Show("Usuario não reconhecido!");
            }
        }

        private void resetForm(Login form)
        {
            Login login = new Login();
            login.pessoa = form.pessoa;
            login.ID = form.ID;
            form = login;
            form.ShowDialog();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frames.user.Cadastro cadastro = new frames.user.Cadastro(ID);
            Hide();
            cadastro.ShowDialog();


            resetForm(this);

            if (cadastro.isCadastroExist())
            {
                pessoa.Add(cadastro.cadastraPessoa());
                cadastro.Close();
            }

        }


    }
}
