
using Methods;

    
string UrunAdi = "elma";
double fiyati = 15;
string aciklama = "Amasya elması";

        Product product1=new Product();
product1.Adi = "elma";
product1.Fiyati = 3;
product1.Aciklama = "Amasya Elmasi";

Product product2 = new Product();

product2.Adi = "karpuz";
product2.Fiyati = 50;
product2.Aciklama = "Diyarbakır karpuzu";



Product[] products= new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Adi);
    Console.WriteLine(product.Fiyati);
    Console.WriteLine(product.Aciklama);
    Console.WriteLine("-----------------------");
}


//Methods

SepetManager sepetmanager = new SepetManager();

sepetmanager.Ekle(product1);
sepetmanager.Ekle(product2);

foreach (Product product in products)
{
    sepetmanager.Ekle(product);
}

sepetmanager.Ekle2("Armut","Yeşil Armut",12);

int number1 =10 ;
int number2 = 20;

 static int topla(int number1 , int number2)
{
    number1 = 30;
    int result=number1+number2;
    return result;

}


Console.WriteLine(topla(number1, number2) ); 
Console.WriteLine(number1);

Console.WriteLine("------------------------------------");
static int topla2(ref int number1, int number2)
{
    number1 = 30;
    int result=number1 + number2;
    return result;  

}


Console.WriteLine( topla2(ref number1, number2));
Console.WriteLine(number1);
Console.WriteLine("------------------------------------");


static int topla3(out int number1,int number2)
{
    number1 = 30;
    int result = number1 + number2;
    return result;
}

Console.WriteLine(topla3(out number1,number2));

static int topla4(params int[] numbers) {
    return numbers.Sum();
}

Console.WriteLine(topla4(1,2,3,4,5,6,7,8));

