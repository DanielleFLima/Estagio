using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Professor : Pessoa
    {
        public int Registro { get; set; }

        public void CadastroProfessor()
        {
            Console.Write("\nDigite o Nome do Professor: ");
            Nome = Console.ReadLine();
            if (!SomenteTexto(Nome)) {
                while (!SomenteTexto(Nome)) {
                    Console.Write("\nEsse nome é invalido, tente novamente: ");
                    Nome = Console.ReadLine();
                }
            }

            Console.Write("Digite o registro do Professor: ");
            Registro = int.Parse(Console.ReadLine());

            Console.Write($"\nDigite a Idade do Professor {Nome}: ");
            Idade = int.Parse(Console.ReadLine());
            string idade = Console.ReadLine();
            if (!SomentoNumeros(idade)){
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
            Console.ReadLine();
        }
    }
}
