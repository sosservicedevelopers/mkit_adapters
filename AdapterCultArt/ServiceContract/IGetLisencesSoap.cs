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

        [XRoadService("GetListOfProtMonum", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр объектов произведений культуры и искусства")]
        ListOfProtMonum[] GetListOfObjCult(int year);



    }
}
