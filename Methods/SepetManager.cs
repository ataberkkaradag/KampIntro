using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi:"+product.Adi);
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyat)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);
        }
        

    }
}
