using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Escolar.frames.user
{
    public partial class Inicio : Form
    {
        model.entities.Pessoa pessoa;
        Control control;
        Login login;
        Button controlButton;

        public Inicio(model.entities.Pessoa pessoa, Login login)
        {
            InitializeComponent();
            controlButton = btnInicio;
            this.pessoa = pessoa;
            this.login = login;

            control = new Home(this);
            control.FindForm().TopLevel = false;
            panelConteudo.Controls.Add(control);
            control.Visible = true;

            userName.Text = "Olá, " + this.pessoa.getPrimeiroNome();
            panelConteudo.Select();
        }

        public model.entities.Pessoa getPessoa() { return pessoa; }

        public void alteraJanela(Form form)
        {
            control.FindForm().Close();
            control = form;
            control.FindForm().TopLevel = false;
            panelConteudo.Controls.Add(control);
            control.Visible = true;
        }

        public void alteraButton(Button button, String text)
        {
            controlButton.BackColor = Color.Gainsboro;
            button.BackColor = Color.DarkGray;
            controlButton = button;
            txtTitulo.Text = text;
        }

        public void executeFunction(model.entities.Pessoa pessoa, Button button, String text, Form form)
        {
            login.atualizaList(pessoa);

            alteraJanela(form);

            alteraButton(button, text);
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            String op = MessageBox.Show("Desejas sair do seu perfil?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();

            if (op == "Yes") Close();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados de Perfil do Usuário:"+ "\n\n  Nome: " + pessoa.getNome() +
                            "\n\n  CPF: " + pessoa.getCPF() +
                            "\n\n  Data Nascimento: " + pessoa.getDataNascimento() +
                            "\n\n  User Name: " + pessoa.getUserName(),                           
                
                    "Informações perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            executeFunction(pessoa, btnSobre, "Sobre o desenvolvedor", new Sobre());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            executeFunction(pessoa, btnInicio, "Agenda Escolar", new Home(this));
        }

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            login.atualizaList(pessoa);

            control.Visible = false;

            alteraButton(btnAnotacoes, "Anotações");
        }

        private void btnProvas_Click(object sender, EventArgs e)
        {
            executeFunction(pessoa, btnProvas, "Lista de Provas", new frames.UserControlProvas.Provas(pessoa));
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            login.atualizaList(pessoa);

            control.Visible = false;

            alteraButton(btnPlanos, "Planos de Estudo");
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            login.atualizaList(pessoa);

            control.Visible = false;

            alteraButton(btnOpcoes, "Configurações");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            login.atualizaList(pessoa);
            
            alteraJanela(new frames.userControl.Perfil(pessoa));

            alteraButton(btnPerfil, "Meu perfil");
        }

    }
}
