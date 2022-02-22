using System;
using Colecoes.Helper;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
      
            while(N-- > 0) {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval =  (int)Math.Sqrt(val);
                int resposta = val - newval;
            
                Console.WriteLine(resposta);
            }
            List<string> teste = new List<string>();
            System.Collections.IEnumerable

        // LINQ (Language Integrated Query)

            // int[] arrayNumeros = new int[10] {100, 1, 3, 0, 6, 8, 11, 3, 6, 15};

            // var minimo = arrayNumeros.Min();
            // var maximo = arrayNumeros.Max();
            // var media = arrayNumeros.Average();
            // var soma = arrayNumeros.Sum();
            // var arrayUnico = arrayNumeros.Distinct().ToArray();

            // System.Console.WriteLine($"Minimo: {minimo}");
            // System.Console.WriteLine($"Maximo: {maximo}");
            // System.Console.WriteLine($"Media: {media}");
            // System.Console.WriteLine($"Soma: {soma}");

            // System.Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");
            // System.Console.WriteLine($"Array disinto: {string.Join(", ", arrayUnico)}");


            // var numerosParesQuery =
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0 ).OrderBy( x => x).ToList();

            // System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));


            // Dicionarios
            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("PR", "Paraná");
            // estados.Add("SC", "Santa Catarina");
            // estados.Add("RS", "Rio Grande do Sul");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "SC";

            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionario");
            // }

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "PR - Atualizado";

            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Trabalhando com filas e pilhas
            // Pilha (LIFO)
            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push("Livro 1");
            // pilhaLivros.Push("Livro 2");
            // pilhaLivros.Push("Livro 3");
            // pilhaLivros.Push("Livro 4");

            // while(pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // Fila (FIFO)
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Thauer");
            // fila.Enqueue("Marina");
            // fila.Enqueue("Miguel");
            // fila.Enqueue("Helena");

            // while( fila.Count > 0 )
            // {
            //     System.Console.WriteLine($"Quantidade de pessoas na fila: {fila.Count}");
            //     System.Console.WriteLine($"Vez de {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()}");
            // }



            // Trabalhando com Listas

            // List<string> estados = new List<string>  {"PR", "SC", "RS"};
            // OperacoesLista opLista = new OperacoesLista();
            // string[] estadosArray = new string[2] {"SP", "MG"};


            // estados.Insert(0, estadosArray[0]);

            // opLista.ImprimirListaString(estados);


            // Trabalhando com incremento de lista
            // estados.AddRange(estadosArray);

            // opLista.ImprimirListaString(estados);




            //             System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            //             opLista.ImprimirListaString(estados);

            //             System.Console.WriteLine("Removendo o elemento");
            //             estados.Remove("RS");
            // // Nota que ao remover um item da lista ela reposiciona os demais, não tendo valor nulo entre os itens // //
            // // uma grande vantagem comparado aos arrays que teriamos que fazer esse trabalho manualmente. // // // // //
            //             opLista.ImprimirListaString(estados);





            //Manipulação de arrays
            //Usando a classe Array

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[10] { 99, 89, 2, 99, 99, 1, 1, 55, 3, 99};
            // int[] arrayCopia = new int[20];
            // int novoTamanho = 40;

            //System.Console.WriteLine("Capacitade atual");


            // Testando busca por indice

            // int valorProcurado = 3;
            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > 0)
            // {
            //     System.Console.WriteLine($"Valor {valorProcurado} encontrado e está no indice {indice}.");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Não encontrei o valor: {valorProcurado} portanto não há indice para ele");
            // }

            // Testando o metodo Find da classe Array
            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine($"Valor {valorAchado} encontrado.");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Não encontrei o valor: {valorProcurado}");
            // }


            // int contador = 0;
            // bool existe = op.Existe(array, valorProcurado);

            // foreach (int item in array)
            // {
            //     if(item == valorProcurado)
            //     {
            //         contador++;
            //     }
            // }


            // if(existe)
            // {
            //     string plural = "";
            //     System.Console.WriteLine($"Encontrei o valor: {valorProcurado}");
            //     if(contador > 1){
            //         plural = "es";
            //     }
            //     System.Console.WriteLine($"O valor foi encontrado {contador} vez{plural}");
            // }
            // else 
            // {
            //     System.Console.WriteLine($"Não encontrei o valor: {valorProcurado}");
            // }



            //Testando copia entre arrays
            // System.Console.WriteLine("Array original:");
            // op.ImprimirArrayConcatenado(array);
            // System.Console.WriteLine("Array cópia original:");
            // op.ImprimirArrayConcatenado(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array copiado");
            // op.ImprimirArrayConcatenado(arrayCopia);

            // System.Console.WriteLine("Array cópia ordenado:");
            // op.Ordenar(refarrayCopia);
            // op.ImprimirArrayConcatenado(arrayCopia);



            // System.Console.WriteLine("Ordenando com a classe Array");
            // op.Ordenar(ref array);
            // op.ImprimirArrayConcatenado(array);

            //Testando alguns algoritmos de ordenação
            //Bobble sort encerrando os testes

            // op.OrdenarBubbleSort(ref array);

            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArrayConcatenado(array);

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