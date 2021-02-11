using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "a";

            Urun urun2 = new Urun();
            urun2.Adi = "b";

            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

            sepet.Ekle2("aa","a",13);
            
        }
    }
}
