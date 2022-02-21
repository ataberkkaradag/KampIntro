string adı = "Ataberk";
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Ataberk Karadag";
kurs1.IzlenmeOranı = 70;


Kurs kurs2 = new Kurs();
kurs2.KursAdi = "JS";
kurs2.Egitmen = "Kuzey Tekinoglu";
kurs2.IzlenmeOranı = 60;

Console.WriteLine(kurs1.KursAdi);
Console.WriteLine(kurs2.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2};


foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi);
}


Product Product1 = new Product();
Product Product2 = new Product();   
Product Product3 = new Product();
Product Product4=new Product {UrunAdı= "ARMUT",UrunAdedi=2,Satıcı="şok"};

Product1.UrunAdı = "elma";
Product1.UrunAdedi = 2;
Product1.Satıcı = "migros";

Product2.UrunAdı = "elma";
Product2.UrunAdedi = 3;
Product2.Satıcı = "migros";

Product3.UrunAdı = "elma";
Product3.UrunAdedi = 4;
Product3.Satıcı = "migros";


Product[] Urunler = new Product[] { Product1, Product2, Product3, Product4 };


foreach (Product product in Urunler)
{
    Console.WriteLine(product.Satıcı);
}

int i = 0;
while (i<Urunler.Length)
{
    Console.WriteLine(Urunler[i].UrunAdı);
    i++;
}


class Kurs
    {
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOranı { get; set; }
}

class Product
{
    public string UrunAdı { get; set; }
    public int UrunAdedi { get; set; }
    public string Satıcı { get; set; }
}