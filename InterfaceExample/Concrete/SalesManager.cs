using InterfaceExample.Abstract;
using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    internal class SalesManager:ISalesService
    {
        public void Sales(Player player, Games game, Discounts discount)
        {
            Console.WriteLine(
                game.Name +
                " adlı oyun " +
                player.Ad +
                " " +
                player.Soyad +
                " kişisine " +
                discount.Name +
                " kampanyası dahilinde " +
                game.Price +
                " fiyatına satılmıştır.");
        }
    }
}
