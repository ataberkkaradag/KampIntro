using System;
using System.Collections.Generic;

string[] isimler = new string[] { "Ataberk", "Ahmet", "Ali", "Ayşe" };

Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);

List<string> isimler2=new List<string> { "Ataberk","Ahmet","Ali","Ayşe"};

Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("ilker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);
