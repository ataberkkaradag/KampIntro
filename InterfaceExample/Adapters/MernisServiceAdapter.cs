using InterfaceExample.Abstract;
using InterfaceExample.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace InterfaceExample.Adapters
{
     class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckPlayerService(Player player)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                ((player.TcNo), player.Ad, player.Soyad, player.DogumYılı).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}
