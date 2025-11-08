using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4
{
    class MaxMin
    {

        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet, out int ma, out int me)
        {
            int cont = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                cont++;
                if (vet[i] < me)
                    me = vet[i];

                cont++;
                if (vet[i] > ma)
                    ma = vet[i];
            }
            Console.WriteLine($"MaxMin1: {cont}");
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void MaxMin2(int[] vet, out int ma, out int me)
        {
            int cont = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                cont++;
                if (vet[i] < me)
                    me = vet[i];
                else
                {
                    cont++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.WriteLine($"MaxMin2: {cont}");
        }

        // T(n) = 3n/2 - 2
        public void MaxMin3(int[] vet, out int ma, out int me)
        {
            int cont = 0;
            if (vet[0] < vet[1])
            {
                cont++;
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                cont++;
                me = vet[1];
                ma = vet[0];
            }
            for (int i = 2; i < vet.Length; i += 2)
            {
                cont++;
                if (vet[i] < vet[i + 1])
                {
                    cont++;
                    if (vet[i] < me)
                    {
                        me = vet[i];
                        cont++;
                    }
                    if (vet[i + 1] > ma)
                    {
                        ma = vet[i + 1];
                        cont++;
                    } 
                }
                else
                {
                    if (vet[i + 1] < me)
                    {
                        me = vet[i + 1];
                        cont++;
                    }
                    if (vet[i] > ma)
                    {
                        ma = vet[i];
                        cont++;
                    }
                }
            }
            Console.WriteLine($"MaxMin3: {cont}");
        }
    }
}
