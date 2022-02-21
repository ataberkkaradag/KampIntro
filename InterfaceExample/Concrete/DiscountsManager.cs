using InterfaceExample.Abstract;
using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    public class DiscountsManager : IDiscountService
    {
        public void Add(Discounts discount)
        {
            Console.WriteLine("İndirim Eklendi:"+discount);
        }

        public void Delete(Discounts discount)
        {
            Console.WriteLine("İndirim silindi:"+discount);
        }

        public void Update(Discounts discount)
        {
            Console.WriteLine("İndirim Güncellendi:"+discount);
        }
    }
}
