


using InterfaceExample.Adapters;
using InterfaceExample.Concrete;
using InterfaceExample.Entities;

Player player=new Player { Ad="Ataberk",Soyad="Karadağ",TcNo=293214233034,DogumYılı=2000};
Games game=new Games { Id=1,Name="ARMA",Price=40};
Discounts discount = new Discounts { Id = 2, Name = "Kış indirimi" };




SalesManager salesManger = new SalesManager();



PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
playerManager.Add(player);



salesManger.Sales(player, game, discount);