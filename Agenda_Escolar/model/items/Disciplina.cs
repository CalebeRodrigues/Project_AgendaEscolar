using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Escolar.model.items
{
    public class Disciplina
    {
        private int IDAnotação;
        private String name;
        private String ano;
        private String situacao;
        private int[,] notas;

        // notas[,] = linhas -> bimestres && columns = {nota1, nota2, exame, faltando para média e média atual

        int qtdBim;

        public Disciplina(int iDAnotação, string name, string ano, string situacao, int semestres)
        {
            IDAnotação = iDAnotação;
            this.name = name;
            this.ano = ano;
            this.situacao = situacao;
            qtdBim = semestres * 2;
            notas = new int[qtdBim, 5];
 
            for (int i = 0; i < (semestres * 2); i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    notas[i, x] = 0;
                }
            }
        }

        public void addNota(int bimestre, int nota, int num)
        {
            notas[bimestre, num] = nota;
            atualizaNotasValue();
        }

        private void atualizaNotasValue ()
        {
            for (int i = 0; i < qtdBim; i++)
            {
                int falta = 0;
                int sum = 0;
                
                sum = notas[i, 0] + notas[i, 1] + notas[i, 2];

                notas[i, 4] = sum / 2;

                falta = 6 - notas[i, 4];

                if(falta < 6)
                {
                    notas[i, 3] = falta;
                }
            }
        }
    }
}
