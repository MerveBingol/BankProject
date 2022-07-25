using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerBankProject
{
    public class Gise
    {
        int giseSirasi = 0;
        public int GiseNo { get; set; }
        public void GiseNoAl(int SiraNo)
        {
            
            if (GiseNo==0)
            {
                ++giseSirasi;
                Console.WriteLine("Gişe numaranız : " + giseSirasi);
                GiseNo = giseSirasi;
            }
            giseSirasi++;
         
        }
        
        public void GiseyeGit(int siraNo, int giseNo)
        {
            if (GiseNo==giseNo)
            {
                return;

            }
           


        }
       



    }
}
