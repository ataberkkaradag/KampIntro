using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tüketici Kredisi Ödeme Planı Hesaplandı");
        }

        public void Method()
        {
            throw new NotImplementedException();
        }
    }
}
