

string kurs1 = "Kurs1";
string kurs2 = "Kurs2";

//Array

string[] kurslar = new string[] {"kurs1","kurs2","kurs3","kurs4" };

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}


foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}