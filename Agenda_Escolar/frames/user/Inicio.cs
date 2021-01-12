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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            String op = MessageBox.Show("Desejas sair do seu perfil?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();

            if (op == "Yes") Close();
        }
    }
}
