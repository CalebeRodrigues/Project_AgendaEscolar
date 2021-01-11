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

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
