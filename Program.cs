using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _numerosInteiros = new int[2];

            Console.WriteLine("------ Sequência Limites ------\n");

            for (int i = 0; i < _numerosInteiros.Length; i++)
            {
                Console.Write($"Digite o {i+1}º valor: ");
                int.TryParse(Console
                .ReadLine()
                .ToString(), out _numerosInteiros[i]);
            }

            if(_numerosInteiros[0] > _numerosInteiros[1]){
                Console.WriteLine($"\nO número {_numerosInteiros[0]} é maior do que o número {_numerosInteiros[1]}, por favor, tente novamente.");
            }
            else{
                Console.WriteLine($"\nInício: {_numerosInteiros[0]} ");
                Console.WriteLine($"Fim: {_numerosInteiros[1]} \n");

                do{
                    Console.Write($"{_numerosInteiros[0]} ");
                    _numerosInteiros[0]+=1;
                } while (_numerosInteiros[0] != (_numerosInteiros[1]+1));
            }
        }
    }
}
