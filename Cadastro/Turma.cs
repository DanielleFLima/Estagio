using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Turma
    {
        public int Numero { get; set; }
        public Professor professor { get; set; }
        public List<Aluno> alunos { get; set; } = new List<Aluno>();

        public void cadastros(){

            Console.Write("Digite o número da Turma: ");
            Numero = int.Parse(Console.ReadLine());

            professor.CadastroProfessor();

            Console.Write("Digite a quantidade de alunos: ");
        }

    }
}
