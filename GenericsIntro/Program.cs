using GenericsIntro;



MyList<string> isimler=new MyList<string>();

isimler.Add("Ataberk");
Console.WriteLine(isimler.Length);
isimler.Add("Ali");
Console.WriteLine(isimler.Length);
isimler.Add("Ahmet");
Console.WriteLine(isimler.Length);
isimler.Add("Ayşe");
Console.WriteLine(isimler.Length);

foreach (var item in isimler.Items)
{
    Console.WriteLine(item);
}