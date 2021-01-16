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
    public partial class Home : Form
    {
        Inicio inicio;

        public Home(Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

            inicio.alteraButton(inicio.btnSobre, "Sobre o desenvolvedor");

            inicio.alteraJanela(new Sobre());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

            inicio.alteraButton(inicio.btnPerfil, "Meu perfil");

            inicio.alteraJanela(new frames.userControl.Perfil(inicio.getPessoa()));
        }
    }
}
