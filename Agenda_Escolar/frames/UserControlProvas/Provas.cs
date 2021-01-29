using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Escolar.frames.UserControlProvas
{
    public partial class Provas : Form
    {
        model.entities.Pessoa pessoa;
        DataTable table;

        public Provas(model.entities.Pessoa pessoa)
        {
            InitializeComponent();

            this.pessoa = pessoa;

            gridListaProvas.DataSource = initializeTable(table);
        }

        public DataTable initializeTable (DataTable table)
        {
            table = new DataTable();
            table.Columns.Add("Disciplina", typeof(String));
            table.Columns.Add("Data", typeof(String));

            foreach (model.entities.Provas provas in pessoa.getProvas())
            {
                table.Rows.Add(provas.getNome(), provas.getData());
            }
            
            return table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
