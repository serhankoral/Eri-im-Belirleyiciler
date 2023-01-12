using System;

namespace Erişim_Belirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kisiler kisi=new kisiler();
            kisi.word = "Serhan KORAL";
            Console.WriteLine(kisi.word);
            kisi.writing("Serhna","Koral",18);
        }
    }
}
