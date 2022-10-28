using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array___Ordenando_Numeros.Src.Classes
{
    public class OrdenacaoDecrescente
    {
        public void OrdemDecrescente(double[] vetor)
        {
            for (int cont = 0; cont < vetor.Length; cont++)
            {
                for (int i = cont; i < vetor.Length; i++)
                {
                    if (vetor[cont] < vetor[i])
                    {
                        double valor = vetor[i];
                        vetor[i] = vetor[cont];
                        vetor[cont] = valor;
                    }
                }
            }
            Console.WriteLine("Números em Ordem Descrescente: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
