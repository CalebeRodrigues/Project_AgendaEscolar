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

        private List<Provas> listProvas = new List<Provas>();

        public Pessoa() { }

        public Pessoa (int ID, long CPF, String dataNascimento, String nome, String userName, String senha, List<Provas> provas)
        {
            this.ID = ID;
            this.CPF = CPF;
            this.dataNascimento = dataNascimento;
            this.nome = nome;
            this.userName = userName;
            this.senha = senha;
            listProvas = provas;
        }
        
        public int getID() { return ID; }

        public long getCPF() { return CPF; }

        public String getDataNascimento() { return dataNascimento; }

        public String getNome() { return nome; }

        public String getUserName() { return userName; }

        public String getSenha() { return senha; }

        public List<Provas> getProvas() { return listProvas; }

        public void setProvas (List<Provas> provas) { listProvas = provas; }

        public void setNome(String nome) { this.nome = nome; }

        public void setUserName(String userName) { this.userName = userName; }

        public bool alterarSenha(String senhaAtual, String senha) {

            if (senhaAtual == getSenha())
            {
                this.senha = senha; return true;
            }

            return false;
        }

        public String getPrimeiroNome ()
        {
            if(nome != null)
            {
                String[] primeiroNome = nome.Split(' ');
                return primeiroNome[0];
            }

            return null;
        }

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
