using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerBankProject
{
   public class Numerator
    {
        int SiraNumarasi = 0;
        public void SiraAl(string tcNo)
        {
            if (tcNo == null)
            {
                Console.WriteLine(" TC No girmediniz");
               
            }
            SiraNumarasi++;
            Console.WriteLine("Sıra Numaranız: " + SiraNumarasi);

        }







    }
}
