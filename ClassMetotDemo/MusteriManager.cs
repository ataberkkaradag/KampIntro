using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {


        public void Ekle(string Ad)
        {
            Console.WriteLine("Musteri: " + Ad + " Eklendi");
        }
        public void Sil(string Ad)
        {
            Console.WriteLine("Musteri: " + Ad + " Silindi");
        }
        public void Listele( string Ad)
        {
            Console.WriteLine("Musteriler: " + Ad );
        }



    }
}
