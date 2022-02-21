using System;

class Program
{
    public static void Main(string[] args)
    {
        string kategoriEtiketi = "Kategori";
        Console.WriteLine(kategoriEtiketi);
        int number = 2;
        Console.WriteLine(number);
        double faizOranı = 1.45;
        Console.WriteLine(faizOranı);
        bool logIn = true;
        Console.WriteLine(logIn);

        if (logIn == false)
        {
            Console.WriteLine("Sisteme Giris Yapılmamıs");
        }
        else
        {
            Console.WriteLine("Sisteme Giris Yapılmıs");

        }


        double dolarDun = 7.50;
        double dolarBugun = 13.50;
        string sonuc;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Dolar Düştü");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Dolar Arttı");
        }
        else
        {
            Console.WriteLine("Dolar Sabit Kaldı");
        }

        //ternary

       sonuc= dolarBugun < dolarDun ? "dolar düştü" : "DOLAR ARTTI";
        Console.WriteLine(sonuc);
        //Switch

        switch (dolarDun)
        {
            case 7.50:
                Console.WriteLine("dolar 7 buck");
                break;
            case 8:
                Console.WriteLine("dolar 8 buck");
                break;
            default:
                Console.WriteLine("DOLAR NEYSE NEY ");
                break;
        }
        int i = 0;
        while (true)
        {
           
            Console.WriteLine(i);
            if (i == 6)
            {
                break;
            }

            i++;
        }

    }
}