using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj20240805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            int m;
            int[] n;
            n = new int[100];
            int ac;
            Random r;
            r = new Random();

            
            ac = 0;
            for (int i = 0; i < 100; i++)
            {
                n[i] = r.Next(98) + 2;
                ac += n[i];
                Console.WriteLine(n[i]);
            }
            Console.WriteLine(ac);
            media = (double)ac / 100;
            Console.WriteLine(media);

            m = 0;
            for (int i = 0; i < 100; i++)
            {
                if (n[i]>media)
                {
                    m++;
                }
            }
            Console.WriteLine(m);

        }
    }
}
