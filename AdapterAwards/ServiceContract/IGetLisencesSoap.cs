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

        [XRoadService("GetListOfStateAward", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр государственных и ведомственных наград")]
        ListOfStateAward[] GetListOfStateAward(int year);

    }
}
