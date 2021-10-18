using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentagon_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pn = n(3n - 1)/2
            bool loop = true;
            int result = 0;
            int i = 1;
            while (loop)
            {

                int x = i * ((3 * i) - 1) / 2;
                i++;
                for (int j = i - 1; j > 0; j--)
                {
                    int y = j * ((3 * j) - 1) / 2;
                    if (IsPentagon(x - y) && IsPentagon(x + y))
                    {
                        result = (x - y);
                        Console.WriteLine(result.ToString());
                        loop = false;
                        break;
                    }
                }




            }
            Console.ReadLine();
        }

        public static bool IsPentagon(int num)
        {
            double isthatpent = (Math.Sqrt(24 * num + 1) + 1) / 6;
            //  (math.sqrt(24*x + 1) + 1)/6 = Bir x sayısı eğer pentagon ise belirtilen işlem daima doğal sayı çıkar
            return isthatpent == (int)isthatpent;

        }
    }
}
