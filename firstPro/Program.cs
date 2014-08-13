using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstPro
{
    class Program
    {

          

        static int count = 0;

        public static int MinChanges(int maxPeriod,String[] acgt)
        {
            string s = "";
            for (int n = 0; n < acgt.Length; n++)
            {
                s = s + acgt[n];
            }
            int l = 1;
            while (l <= maxPeriod)
            {
                for (int m = 1;  m <= l; m++)
                {
                    #region MyRegion
                    
                   
                    //for (int i = 0; i < (s.Length - maxPeriod - 1); i++)
                    //{
                    //    if (s[i] != s[i + maxPeriod])
                    //    {



                    //        // acgt[i ] = acgt[i];
                    //       
                    //        // Console.WriteLine(count);
                    //    }

                    //}
                    #endregion
                    for (int j = m; j < (s.Length); j = j + m)
                    {
                        if (s[m] != s[j])
                            count++;
                    }
                }

                l++;

                 }
            

                return count;

            }

        

        static void Main(string[] args)
        {
            String[] str=new String[5];
            int period;
            

            Console.WriteLine("Enter no of string :");
            int no = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=no; i++)
            {
                Console.WriteLine("Enter a string :");
                str[i] = Console.ReadLine();
            }
            //Console.WriteLine(s[2]);

            Console.WriteLine("Enter a max period :");
            period = Convert.ToInt32(Console.ReadLine());

             int replacement= MinChanges( period,str);

            Console.WriteLine("replacement required "+ replacement);
            Console.ReadKey();


        }
    }
}
