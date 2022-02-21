using InterfaceExample.Abstract;
using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine("Oyun Eklendi:"+game);
        }

        public void Delete(Games game)
        {
            Console.WriteLine("Oyun silindi:" + game);
        }

        public void Update(Games game)
        {
            Console.WriteLine("Oyun güncellendi:" + game);
        }
    }
}
