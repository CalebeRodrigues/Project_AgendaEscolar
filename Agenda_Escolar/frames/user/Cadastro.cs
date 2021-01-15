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
    public partial class Cadastro : Form
    {
        int ID;
        bool exist;

        public Cadastro(int ID)
        {
            InitializeComponent();
            this.ID = ID++;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            exist = false;
        }

        public model.entities.Pessoa cadastraPessoa ()
        {
            return pessoa;
        }

        public bool isCadastroExist()
        {
            return exist;
        }

        model.entities.Pessoa pessoa;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                exist = true;

                pessoa = new model.entities.Pessoa
                    (ID, Convert.ToInt64(mskCPF.Text), mskNascimento.Text, txtNome.Text, txtUserName.Text, txtSenha.Text);

                MessageBox.Show("Cadastro realizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao realizar cadastro. Verifique se todos os campos estão preenchidos e " +
                                "tente novamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
