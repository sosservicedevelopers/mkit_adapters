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


        [XRoadService("GetListOfMonuments", AddedInVersion = 1)]
        [XRoadTitle("RU", "Сервис для получения получения списков памятников по годам")]
        ListOfMonument[] GetListOfMonuments(int year);
    }
}
