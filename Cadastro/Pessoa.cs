using System;
using System.Text.RegularExpressions;

namespace Cadastro
{
    public class Pessoa{
        public string Nome {get; set;}
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void CadastrarPessoa()
        {

        }
        //Esse método verifica se os número recebido é positivo.
        public bool SomentoNumeros(string teste){
            while (!Regex.IsMatch(teste, @"^[0-9]+$"))
                return false;
            return true;
        }

        //Esse método verifica se o nome recebido é realmente só Strings. 
        public bool SomenteTexto(string texto){
            while(!Regex.IsMatch(texto, @"\d"))
                return false;
            return true;
        }

        //Esse método verifica se o sexo recebido corresponde com a comparação.
        public bool VerificandoSexo(string sexo){
            while(sexo.ToUpper() != "F" && sexo.ToUpper() != "M")
                return false;
            return true;
        }
    }
}
