using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerBankProject
{
   public class Musteri
    { 
       
       // int sayac = 0;
       
       
        public string TcNo { get; set; }
        public int  MusteriSiraNo { get; set; }
     
        public event MusteriSiraHandler SiraAl;
        public event MusteriHandler SiraGeldi;
       
        public void SiraKontrol(int siraNo, int giseNo)
        {
            if (MusteriSiraNo == 0)
            {
                SiraAl(TcNo);
              
            }
            SiraGeldi(MusteriSiraNo, giseNo);
            Console.WriteLine($"Yeşil ışık yandı { MusteriSiraNo}" + "nolu müşteri lütfen "
            + $"{giseNo}" + " nolu gişeye gidiniz");



        }
 
        //public void MusteriSiraNoIlerle(string giseNo)
        //{
        //    if (sayac == MusteriSiraNo)
        //    {
        //        return;
        //    }
        //    if (SiraGeldi == null)
        //    {
        //        SiraGeldi(MusteriSiraNo, giseNo);
        //        Console.WriteLine($"Yeşil ışık yandı { MusteriSiraNo}" + "nolu müşteri lütfen "
        //        + $"{giseNo}" + " nolu gişeye gidiniz");
        //    }
        //    sayac++;

        //}

    }
}
