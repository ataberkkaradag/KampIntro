using ClassMetotDemo;




Musteri musteri1 = new Musteri {Ad="ataberk",Soyad="karadağ",Yas=20,Cinsiyet='E',TelNo="1241241241",Id=1 };
Musteri musteri2 = new Musteri { Ad = "ayşe", Soyad = "kara", Yas = 21, Cinsiyet = 'K', TelNo = "1221141241", Id = 2 };

MusteriManager musterimanager= new MusteriManager();

Musteri[] musteriler =new Musteri[] { musteri1, musteri2 };


musterimanager.Ekle(musteri1.Ad);
musterimanager.Sil(musteri2.Ad);


foreach (Musteri m in musteriler)
{
    musterimanager.Listele(m.Ad);
}       

