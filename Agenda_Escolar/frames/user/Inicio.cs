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

        public Inicio(model.entities.Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;

            userName.Text = this.pessoa.getNome();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            String op = MessageBox.Show("Desejas sair do seu perfil?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();

            if (op == "Yes") Close();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados de Perfil do Usuario:"+ "\n\n  Nome: " + pessoa.getNome() +
                            "\n\n  CPF: " + pessoa.getCPF() +
                            "\n\n  Data Nascimento: " + pessoa.getDataNascimento() +
                            "\n\n  User Name: " + pessoa.getUserName(),                           
                
                    "Informações perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto desenvolvido por Calebe Barros Rodrigues\n\n"
                            + "Técnico em informatica (2017-2019) e estudante \n\nde Sistema de Informações (2020-2024), Barretos-SP.\n" 
                            + "\n\n       @ Calebe Barros Rodrigues, 2020.",
                    "Informações do Desenvolvedor!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
