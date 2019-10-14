using System.Text.RegularExpressions;

namespace Cadastro{
    public class Pessoa{

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        //Esse método verifica se os número recebido é positivo.
        public bool SomentoNumeros(string teste){
            if(!Regex.IsMatch(teste, @"^[0-9]+$"))
                return false;
            return true;
        }

        //Esse método verifica se o nome recebido é não é nulo e somente string. 
        public bool SomenteTexto(string texto){
            if(!string.IsNullOrEmpty(texto) && Regex.IsMatch(texto, @"^[a-zA-Z]+$"))
                return true;
            return false;
        }

        //Esse método verifica se o sexo recebido corresponde com a comparação.
        public bool VerificandoSexo(string sexo){
            if(sexo.ToUpper() != "F" && sexo.ToUpper() != "M")
                return false;
            return true;
        }
    }
}
