using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                // giriş alma
                Console.Write("Lütfen bir sayı giriniz: ");
                string girdi = Console.ReadLine();

                // giriş sayıya dönüştürme
                double sayi = Convert.ToDouble(girdi);

                //sayının karesi
                Console.WriteLine($"Girdiğiniz sayının karesi: {sayi * sayi}");
                break;
            }
            catch (FormatException)
            {
                //geçersiz mesajı
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}
