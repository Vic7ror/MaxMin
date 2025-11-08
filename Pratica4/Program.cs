using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cre = new int[1000];
            int[] dec = new int[1000];
            int[] alt = new int[1000];
            int ma = 0;
            int me = 0;
            Random r = new Random();

            for (int i = 0; i < cre.Length; i++)
            {
                cre[i] = i + 1;
                dec[i] = 1000 - i;
                alt[i] = r.Next(0,100);
            }

            MaxMin mxm = new MaxMin();
            Console.WriteLine("Vetor Crescente:");
            mxm.MaxMin1(cre, out ma, out me);
            mxm.MaxMin2(cre, out ma, out me);
            mxm.MaxMin3(cre, out ma, out me);
            Console.WriteLine();
            Console.WriteLine("Vetor Decrescente:");
            mxm.MaxMin1(dec, out ma, out me);
            mxm.MaxMin2(dec, out ma, out me);
            mxm.MaxMin3(dec, out ma, out me);
            Console.WriteLine();
            Console.WriteLine("Vetor Aleatório:");
            mxm.MaxMin1(alt, out ma, out me);
            mxm.MaxMin2(alt, out ma, out me);
            mxm.MaxMin3(alt, out ma, out me);


        }
    }
}
