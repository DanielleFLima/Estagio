using System;

namespace Cadastro{
    public class Aluno : Pessoa{
        public int Matricula { get; set; }
        public string Bolsa { get; set; }

        //Esse método faz o cadastro de um aluno, contendo: Nome, Matrícula, idade, sexo, bolsista.
        public void CadastroAluno(){
            Console.Write("\nDigite o Nome do aluno(a): ");
            Nome = Console.ReadLine();
            while (!SomenteTexto(Nome)){
                Console.Write("\nEsse nome é invalido, tente novamente: ");
                Nome = Console.ReadLine();
            }

            Random random = new Random();
            Matricula = random.Next(100000, 200000);
            Console.Write($"Número de Matrícula {Matricula} do aluno(a) {Nome}");

            Console.Write($"\nDigite a Idade do aluno(a) {Nome}: ");
            string idade = Console.ReadLine();
            while (!SomentoNumeros(idade) || int.Parse(idade) <= 0) {
                Console.Write("\nIdade digitada não é valida, digite novamente: ");
                idade = Console.ReadLine();
            }
            Idade = int.Parse(idade);

            Console.Write($"Digite o sexo (F/M) do aluno(a) { Nome } de {Idade} anos: ");
            Sexo = Console.ReadLine();
            while (!VerificandoSexo(Sexo)){
                Console.Write("\nO sexo não é válido, digite novamente: ");
                Sexo = Console.ReadLine();
            }

            Console.Write($"O aluno(a) {Nome} é bolsista? S/N: ");
            Bolsa = Console.ReadLine();
            while (!Bolsista(Bolsa)){
                Console.Write("\nO valor digitado não é válido, digite novamente: ");
                Bolsa = Console.ReadLine();
            }
        }

        //Esse método imprime os dados do cadastro do Aluno
        public void ExibirAlunos() => Console.Write($"\nAluno(a) {Nome}, da matrícula {Matricula}, do sexo {Sexo} tem {Idade} anos");

        //Esse método verifica se o Aluno é bolsista
        public bool Bolsista(string bolsa){
            if(bolsa.ToUpper() != "S" && bolsa.ToUpper() != "N")
                return false;
            return true;
        }
    }
}
