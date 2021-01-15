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
        Button controlButton;

        public Inicio(model.entities.Pessoa pessoa)
        {
            InitializeComponent();
            controlButton = btnInicio;
            this.pessoa = pessoa;

            userName.Text = "Olá, " + this.pessoa.getPrimeiroNome();
            userName.Select();
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
            //control.FindForm().Close();
            control = new Sobre();
            control.FindForm().TopLevel = false;
            panelConteudo.Controls.Add(control);
            control.Visible = true;

            controlButton.BackColor = Color.Turquoise;
            btnSobre.BackColor = Color.LightSeaGreen;
            controlButton = btnSobre;
            txtTitulo.Text = "Sobre o desenvolvedor";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.Turquoise;
            btnInicio.BackColor = Color.LightSeaGreen;
            controlButton = btnInicio;
            txtTitulo.Text = "Agenda Escolar";
        }

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.Turquoise;
            btnAnotacoes.BackColor = Color.LightSeaGreen;
            controlButton = btnAnotacoes;
            txtTitulo.Text = "Anotações";
        }

        private void btnProvas_Click(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.Turquoise;
            btnProvas.BackColor = Color.LightSeaGreen;
            controlButton = btnProvas;
            txtTitulo.Text = "Lista de Provas";
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.Turquoise;
            btnPlanos.BackColor = Color.LightSeaGreen;
            controlButton = btnPlanos;
            txtTitulo.Text = "Planos de Estudo";
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
