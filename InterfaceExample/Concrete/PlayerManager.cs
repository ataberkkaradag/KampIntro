using InterfaceExample.Abstract;
using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckPlayerService(player))
            {
                Console.WriteLine("Oyuncu Eklendi " + player.Ad + " " + player.Soyad);
            }
            else
            {
                Console.WriteLine("Kayıtlı olmayan oyuncu eklenemez");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi " + player.Ad + " " + player.Soyad);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi " + player.Ad + " " + player.Soyad);
        }
    }
}
