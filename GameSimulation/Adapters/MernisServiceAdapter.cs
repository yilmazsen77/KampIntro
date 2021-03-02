using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Adapters
{
    public class MernisServiceAdapter : IPersonValidation
    {
        public bool IsPerson(Gamer gamer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityNumber), gamer.Name.ToUpper(), gamer.LastName.ToUpper(),
            //    gamer.BirthDate.Year))).Result.Body.TCKimlikNoDogrulaResult;

            return true;
        }
    }
}
