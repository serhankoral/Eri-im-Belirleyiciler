using System;

namespace Erişim_Belirleyiciler
{
    internal class Program
    {
        /*
         * Erişim kontrollerinde genelde 3(private,public ve internal) tip kullanılır 
         * kalıtım öğrenildikten sonra 2(protected ve internal protected) tane daha eklenir. 
         * private sadece ilgili class içerisinden ulaşım sağlanır başka bir yerden yada programdan ulaşım sağlanmaz
         * public başka bir programdan yada başka bir class dan ulaşım sağlanır
         * internal sadece class in yer aldığı programın her yerinden ulaşıma izin verir dış erişimi yasaklar
        */
        static void Main(string[] args)
        {
            kisiler kisi=new kisiler();
            kisi.word = "Serhan KORAL";
            Console.WriteLine(kisi.word);
            kisi.writing("Serhna","Koral",18);
        }
    }
}
