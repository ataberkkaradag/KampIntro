using InterfaceAbstract.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAbstract.Abstract
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
