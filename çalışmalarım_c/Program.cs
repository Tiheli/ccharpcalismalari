using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çalışmalarım_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // readline ile kullanıcıdan değer alma
            Console.WriteLine("kullanıcı ismi giriniz: ");

            string isim = Console.ReadLine();

            Console.WriteLine("kullanıcı soyismi giriniz: ");
  
            string soyisim = Console.ReadLine();
            Console.WriteLine("kullanıcı ismi: " + isim);
            Console.WriteLine("kullanıcı soysimi: " + soyisim);

            Console.ReadLine();
        }
    }
}
