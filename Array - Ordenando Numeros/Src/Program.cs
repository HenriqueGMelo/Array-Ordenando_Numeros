using Array___Ordenando_Numeros.Src.Classes;
using System;

namespace Array___Ordenando_Numeros
{
    class Program
    {
        public static void Main(string[] args)
        {

            OrdenacaoCrescente crescente = new OrdenacaoCrescente();
            OrdenacaoDecrescente decrescente = new OrdenacaoDecrescente();

            int escolha, decisao;
            int continuar = 4;

            do
            {
                do
                {   
                    Console.WriteLine("Deseja ordenar valores por ondem Crescente ou Decrescente ?");
                    Console.WriteLine("1 Crescente \n" + 
                        "2 Decrescente \n" +
                        "3 Cancelar: ");
                    escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    decisao = 0;

                    if (escolha < 1 || escolha > 3)
                        do
                        {
                            Console.WriteLine("Opção inválida");
                            Console.Write("Deseja iniciar nova tentativa ? - 4 para Sim - 5 para Não: ");
                            decisao = int.Parse(Console.ReadLine());
                            Console.Clear();

                        } while (decisao <= 3 || decisao >= 6);

                } while (decisao == continuar);

                if (escolha == 3 || decisao == 5)
                {
                    break;
                }

                double[] vetor = new double[5];

                Console.WriteLine("Observação: Caso digite algo que não seja apenas um 'número', será considerado como '0' ");
                Console.WriteLine();
                Console.WriteLine("Digite até 5 números: ");
                Console.WriteLine();

                try
                {
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        Console.WriteLine($"Digite o {i+1}° número que desejar: ");
                        vetor[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine();
                }
              

                if (escolha == 1)
                {
                    crescente.OrdemCrescente(vetor);
                }
                else if (escolha == 2)
                {
                    decrescente.OrdemDecrescente(vetor);
                }

                Console.WriteLine();
                

                do
                {
                    Console.Write("Deseja inserir novos números ? - 4 para Sim - 5 para Não: ");
                    decisao = int.Parse(Console.ReadLine());
                    Console.Clear();

                } while (decisao <= 3 || decisao >= 6);

            } while (decisao == continuar);
        }
    }
}