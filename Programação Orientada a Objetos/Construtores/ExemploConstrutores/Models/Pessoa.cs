namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        // readonly só é alterado no construtor ou na inicialização
        private readonly string nome = "Thauer";
        private readonly string sobrenome;

         public Pessoa()
         {
             nome = string.Empty;
             sobrenome = string.Empty;
         }   

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"My name is... {nome} {sobrenome}");
        }
    }
}