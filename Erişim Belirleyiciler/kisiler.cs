using System;
using System.Collections.Generic;
using System.Text;

namespace Erişim_Belirleyiciler
{
    internal class kisiler
    {
        private string name;
        private string surname;
        private int age;
        public string word;

        public void writing(string ad, string soyad, int yas)
        {
            word = ad + " " + soyad +" "+yas + " yaşındadır";
            Console.WriteLine(word);
        }
    }
}
