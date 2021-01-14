using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Escolar.model.entities
{
    public class Pessoa
    {
        private int ID;
        private long CPF;
        private String dataNascimento;
        private String nome;
        private String userName;
        private String senha;

        public Pessoa() { }

        public Pessoa (int ID, long CPF, String dataNascimento, String nome, String userName, String senha)
        {
            this.ID = ID;
            this.CPF = CPF;
            this.dataNascimento = dataNascimento;
            this.nome = nome;
            this.userName = userName;
            this.senha = senha;
        }
        
        public int getID() { return ID; }

        public long getCPF() { return CPF; }

        public String getDataNascimento() { return dataNascimento; }

        public String getNome() { return nome; }

        public String getUserName() { return userName; }

        public String getSenha() { return senha; }


        public override bool Equals(object obj)
        {
            var pessoa = obj as Pessoa;
            return pessoa != null &&
                   userName == pessoa.userName &&
                   senha == pessoa.senha;
        }

        public override int GetHashCode()
        {
            var hashCode = -1593225233;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(userName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(senha);
            return hashCode;
        }
        
    }
}
