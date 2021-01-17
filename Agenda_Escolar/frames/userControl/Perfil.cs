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
        Control control;

        public Perfil(model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;

            control = new PerfilVerDados(pessoa);
            control.FindForm().TopLevel = false;
            panel1.Controls.Add(control);
            control.Visible = false;
        }

        public void alteraJanela(Form form)
        {
            control.FindForm().Close();
            control = form;
            control.FindForm().TopLevel = false;
            panel1.Controls.Add(control);
            control.Visible = true;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            alteraJanela(new PerfilVerDados(pessoa));
        }
    }
}
