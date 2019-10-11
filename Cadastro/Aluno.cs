using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public string Bolsa { get; set; }

        //Esse método faz o cadastro de um aluno, contendo: Nome, Matrícula, idade, sexo, bolsista.
        public void CadastroAluno()
        {
            Console.Write("\nDigite o Nome do aluno: ");
            Nome = Console.ReadLine();
            if (!SomenteTexto(Nome)) {
                while (!SomenteTexto(Nome)) {
                    Console.Write("\nEsse nome é invalido, tente novamente: ");
                    Nome = Console.ReadLine();
                }
            }

            Random random = new Random();
            Matricula = random.Next(100000, 200000);
            Console.Write($"\nNúmero de Matrícula{Matricula}\n do aluno {Nome}.");

            Console.Write($"\nDigite a Idade do Aluno {Nome}: ");
            string idade = Console.ReadLine();
            if (!SomentoNumeros(idade)) {
                while (!SomentoNumeros(idade)) {
                    Console.Write("\nIdade digitada não é valida, digite novamente: ");
                    idade = Console.ReadLine();
                }
            }
            Idade = int.Parse(idade);

            Console.Write($"\nDigite o sexo (F/M) do Aluno { Nome } de {Idade} anos: ");
            Sexo = Console.ReadLine();
            if (!VerificandoSexo(Sexo)) {
                while (!VerificandoSexo(Sexo)) {
                    Console.Write("\nO sexo não é válido, digite novamente: ");
                    Sexo = Console.ReadLine();
                }
            }

            Console.Write($"\nO aluno {Nome} é bolsista? S/N ");
            Bolsa = Console.ReadLine();
            if (!Bolsista(Bolsa)) {
                while (!Bolsista(Bolsa)) {
                    Console.Write("\nO valor digitado não é válido, digite novamente: ");
                    Bolsa = Console.ReadLine();
                }
            }

        }
        public void ExibirAlunos() => Console.WriteLine($"Aluno(a) {Nome} da matrícula {Matricula} do sexo {Sexo} tem {Idade} anos");

        public bool Bolsista(string bolsa)
        {
            while (bolsa.ToUpper() != "S" && bolsa.ToUpper() != "N")
                return false;
            return true;
        }
    }
}
