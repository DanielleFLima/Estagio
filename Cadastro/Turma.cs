using System;
using System.Collections.Generic;

namespace Cadastro{
    public class Turma{
        public int Codigo { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        //Esse método faz o cadastro da turma, constando (Número da turma, dados do professor e lista com dados dos alunos)
        public void CadastroTurma(){

            Console.Write("Olá, para efetuar o cadastro digite o Código da Turma: ");
            int.TryParse(Console.ReadLine(), out int cdg);
            while (cdg <= 0) {
                Console.Write("\nNúmero inválido. Digite um número positivo: ");
                int.TryParse(Console.ReadLine(), out cdg);
            }
            Codigo = cdg;

            Professor professor = new Professor();
            professor.CadastroProfessor();

            Console.Write("\nDigite a quantidade de alunos que deseja cadastrar: ");
            int.TryParse(Console.ReadLine(), out int qtdAlunos);
            while (qtdAlunos <= 0) {
                Console.Write("\nNúmero inválido. Digite um número positivo: ");
                int.TryParse(Console.ReadLine(), out qtdAlunos);
            }

            for (int i = 0; i < qtdAlunos; i++) {
                Aluno aluno = new Aluno();
                aluno.CadastroAluno();
                Alunos.Add(aluno);
            }

            Console.Write($"\nTurma : {Codigo}, tem {qtdAlunos}");

            professor.ExibirProfessor();

            foreach (Aluno i in Alunos)
                i.ExibirAlunos();

            Console.WriteLine();
        }
    }
}
