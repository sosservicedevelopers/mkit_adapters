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

        [XRoadService("GetListOfTourizmIndicators", AddedInVersion = 1)]
        [XRoadTitle("RU", "Сервис для получения получения показателя туристического индикатора по году")]
        ListIndicatorsOfTourizm GetListOfTourizmIndicators(int year);


        [XRoadService("GetListOfTourizm", AddedInVersion = 1)]
        [XRoadTitle("RU", "Сервис для получения туристического агенства по пину")]
        ListOfTourizm GetListOfTourizm(AddRequest request);
    }


}
