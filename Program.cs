using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nm.d9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] pazymis = {

                4,  // maziausis pazymis
                8,
                9,  // didziausis pazymis
                7,
                5,



            };

            int max = 1;
            int min = 4;



            for (int i = 1; i < pazymis.Length; i++)
            {

                Console.WriteLine(pazymis[i]);
                if (pazymis[i] > max)
                {

                    max = pazymis[i];
                }

                if (pazymis[i] < min)
                {
                    min = pazymis[i];

                }
            }
            Console.WriteLine("Max:  " + max);
            Console.WriteLine("Min:  " + min);
        }
    }
}
