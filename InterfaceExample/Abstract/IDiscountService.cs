
using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Abstract
{
    public interface IDiscountService
    {
        void Add(Discounts discount);
        void Update(Discounts discount);
        void Delete(Discounts discount);
    }
}
