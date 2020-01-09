using AdapterMonListOfTourizm.DataContract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRoadLib.Attributes;

namespace AdapterMonListOfTourizm.ServiceContract
{
    public interface IGetLisencesSoap
    {

        [XRoadService("ListOfCinemaOrg", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр киноорганизации")]
        ListOfCinemaOrg[] GetListOfCinemaOrg(int year);


        [XRoadService("GetListOfCinemaDocs", AddedInVersion = 1)]
        [XRoadTitle("RU", "Предоставление информации о перечне документов")]
        ListOfCinemaDocs[] GetListOfCinemaDocs(int year);

        [XRoadService("GetListOfCinemaCert", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр по предоставлению прокатных удостоверений")]
        ListOfCinemaCert[] GetListOfCinemaCert(int year);
    }
}
