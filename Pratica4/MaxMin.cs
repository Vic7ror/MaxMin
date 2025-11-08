using System;

namespace Pratica4
{
    class MaxMin
    {
        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet, out int ma, out int me)
        {
            if (vet == null) throw new ArgumentNullException(nameof(vet));
            if (vet.Length == 0) throw new ArgumentException("O vetor deve conter pelo menos um elemento.", nameof(vet));

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
            if (vet == null) throw new ArgumentNullException(nameof(vet));
            if (vet.Length == 0) throw new ArgumentException("O vetor deve conter pelo menos um elemento.", nameof(vet));

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

        // T(n) = 3n/2 - 2 (assumindo n par)
        public void MaxMin3(int[] vet, out int ma, out int me)
        {
            if (vet == null) throw new ArgumentNullException(nameof(vet));
            if (vet.Length == 0) throw new ArgumentException("O vetor deve conter pelo menos um elemento.", nameof(vet));

            int cont = 0;

            if (vet.Length == 1)
            {
                ma = me = vet[0];
                Console.WriteLine($"MaxMin3: {cont}");
                return;
            }

            // inicialização com os dois primeiros
            cont++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }

            int i;
            for (i = 2; i + 1 < vet.Length; i += 2)
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
                    cont++;
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

            // se n for ímpar, tratar último elemento isoladamente
            if (i < vet.Length)
            {
                cont++;
                if (vet[i] < me) me = vet[i];
                cont++;
                if (vet[i] > ma) ma = vet[i];
            }

            Console.WriteLine($"MaxMin3: {cont}");
        }
    }
}
