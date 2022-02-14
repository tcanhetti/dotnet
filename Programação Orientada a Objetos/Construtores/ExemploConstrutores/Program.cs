using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica mat = new Matematica(15, 33);
            mat.Somar();
            const int xis = 40;
            xis = 4;


            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair; 
            // op.Invoke(10, 10);
            
            
            
            
            
            
            
            
            
            // Data data = new Data();
            // // data.SetMes(10);

            // data.Mes = 25;
            // data.ApresentarMes();




            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia2";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            


            //Instanciando Pessoa e chamando metodo Apresentar de forma que cite parte da musica do M&M "My name is"
            // Pessoa p1 = new Pessoa();
            // p1.Apresentar();

            // Pessoa p2 = new Pessoa(3.ToString(), "Shady!".ToUpper());
            // p2.Apresentar();
        }
    }
}
