using System;

namespace Cadastro{
    public class Professor : Pessoa{
        public int Registro { get; set; }

        //Esse método faz o cadastro de um Professor, contendo(Nome, Registro, idade, sexo)
        public void CadastroProfessor(){
            Console.Write("\nDigite o Nome do Professor(a): ");
            Nome = Console.ReadLine();
            while (!SomenteTexto(Nome)) {
                Console.Write("\nEsse nome é invalido, tente novamente: ");
                Nome = Console.ReadLine();
            }

            Console.Write($"Digite o Registro do Professor(a) {Nome}: ");
            string registro = Console.ReadLine();
            while (!SomentoNumeros(registro)) {
                Console.Write("\nRegistro inválido, digite novamente: ");
                registro = Console.ReadLine();
            }
            Registro = int.Parse(registro);


            Console.Write($"Digite a Idade do Professor(a) {Nome}: ");
            string idade = Console.ReadLine();
            while (!SomentoNumeros(idade) || int.Parse(idade) <= 0) {
                Console.Write("\nIdade digitada não é valida, digite novamente: ");
                idade = Console.ReadLine();
            }
            Idade = int.Parse(idade);

            Console.Write($"Digite o sexo (F/M) do professor(a) { Nome } de {Idade} anos: ");
            Sexo = Console.ReadLine();
            while (!VerificandoSexo(Sexo)) {
                Console.Write("\nO sexo não é válido, digite novamente: ");
                Sexo = Console.ReadLine();
            }
        }
        //Esse método imprime os dados do cadastro do Professor
        public void ExibirProfessor() => Console.WriteLine($"\nProfessor(a) {Nome} Registro {Registro} do sexo {Sexo} tem {Idade} anos");
    }
}