using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Manipulação de arrays
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[9] { 34, 89, 2, 56, 99, 12, 1, 55, 3};

            System.Console.WriteLine("Array original:");
            op.ImprimirArrayConcatenado(array);

            op.OrdenarBubbleSort(ref array);

            System.Console.WriteLine("Array ordenado:");
            op.ImprimirArrayConcatenado(array);

            //Imprimindo concatenado
            // System.Console.WriteLine("Array concatenado:");
            // op.ImprimirArrayConcatenado(array);

            //Acessando todos os indices
            // string[,] arrayString = new string[3, 4]
            // {
            //     {"Linha: 1 | Coluna 1", "Linha: 1 | Coluna 2", "Linha: 1 | Coluna 3", "Linha: 1 | Coluna 4"},
            //     {"Linha: 2 | Coluna 1", "Linha: 2 | Coluna 2", "Linha: 2 | Coluna 3", "Linha: 2 | Coluna 4"},
            //     {"Linha: 3 | Coluna 1", "Linha: 3 | Coluna 2", "Linha: 3 | Coluna 3", "Linha: 3 | Coluna 4"}
            // };
            
            // for (int i = 0; i < arrayString.GetLength(0); i++)
            // {
            //     for (int j = 0; j < arrayString.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(arrayString[i, j]);
            //     }
            // }



            // Imprimir cada item
            //  foreach (int item in arrayInteiros)
            //  {
            //      System.Console.WriteLine(item);
            //  }
        }
    }
}