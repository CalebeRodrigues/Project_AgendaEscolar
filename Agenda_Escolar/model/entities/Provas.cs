using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Escolar.model.entities
{
    public class Provas
    {
        private int ID;
        private String Nome;
        private String Data;

        public Provas(int iD, string nome, string data)
        {
            ID = iD;
            Nome = nome;
            Data = data;
        }

        public int getID() { return ID; }
        public String getNome() { return Nome; }
        public String getData() { return Data; }

        public void setNome(String nome) { Nome = nome;  }
        public void setData(String data) { Data = data;  }
    }
}
