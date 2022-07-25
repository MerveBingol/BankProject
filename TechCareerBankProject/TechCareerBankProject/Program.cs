using System;

namespace TechCareerBankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Gise gise = new Gise();
            Numerator numerator = new Numerator();

            Console.WriteLine("TechCareer Bankamıza hoşgeldiniiz..");
            Console.WriteLine("Lütfen TC No Giriniz: ");
            musteri.TcNo = Console.ReadLine();

           numerator.SiraAl(musteri.TcNo);
           musteri.SiraAl += numerator.SiraAl;

            gise.GiseNoAl(musteri.MusteriSiraNo);
            musteri.SiraKontrol(musteri.MusteriSiraNo,gise.GiseNo);
            musteri.SiraGeldi += gise.GiseyeGit;
            
             //musteri.MusteriSiraNoIlerle( gise.GiseNo);
            

        
            Console.ReadKey();
        }

       
    }
}
