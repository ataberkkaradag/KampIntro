using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
     class Basic
    {
        public void topla(int a,int b)
        {
            int sonuc = a + b;
            Console.WriteLine( sonuc);
        }
        public void cikar(int a, int b)
        {
            int sonuc = a - b;
            Console.WriteLine(sonuc);
        }
        public void carp(int a, int b)
        {
            int sonuc = a * b;
            Console.WriteLine(sonuc);
        }
        public void bol(float a, float b)
        {
            float sonuc = a / b;
            Console.WriteLine(sonuc);
        }

    }
}
