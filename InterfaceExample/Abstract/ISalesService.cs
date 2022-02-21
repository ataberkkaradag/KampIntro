using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Abstract
{
    internal interface ISalesService
    {
        void Sales(Player player, Games game, Discounts discount);
    }
}
