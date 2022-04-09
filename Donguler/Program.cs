using System;


namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç eğitim kursu";
            string kurs3 = "Java";
            string kurs4 = "Python";

            // Bu tip verileri dizilerde tutarız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç eğitim kursu", 
                "Java",
                "Python",
                "C++",
                "Java React",
                "C#",
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\n");
            foreach (string kurs in kurslar)
            {
                
                Console.WriteLine(kurs);
                
            }

            Console.WriteLine("\nsayfa sonu - footer"); 
        }
    }
}
