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

            table = null;
            this.pessoa = pessoa;

            if (pessoa.getProvas().Count != 0) { configGridView(); }
        }

        private void configGridView()
        {
            gridListaProvas.DataSource = initializeTable(table);
            gridListaProvas.Columns[0].Width = 80;
            gridListaProvas.Columns[1].Width = 390;
            gridListaProvas.Columns[2].Width = 160;
        }

        public DataTable initializeTable (DataTable table)
        {
            table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Disciplina", typeof(String));
            table.Columns.Add("Data", typeof(String));

            foreach (model.entities.Provas provas in pessoa.getProvas())
            {
                table.Rows.Add(provas.getID(), provas.getNome(), provas.getData());
            }
            
            return table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ProvasDialog provasDialog = new ProvasDialog("Adicionar Provas", pessoa);

            provasDialog.ShowDialog();

            provasDialog.Close();

            configGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            model.entities.Provas prova = null;

            int id = int.Parse(gridListaProvas.CurrentRow.Cells[0].Value.ToString());

            foreach (model.entities.Provas p in pessoa.getProvas())
            {
                if (p.getID() == id)
                {
                    prova = p;
                }
            }

            ProvasDialog provasDialog = new ProvasDialog("Editar prova", prova);

            provasDialog.ShowDialog();
            configGridView();
        }
    }
}
