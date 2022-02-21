using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplyManager
    {
        public void Basvuruyap(ICreditManager creditManager ,ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void ÖnBilgilendirmeYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
