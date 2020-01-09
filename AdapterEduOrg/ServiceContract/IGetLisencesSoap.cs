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


        [XRoadService("GetListOfEduOrg", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр учебных организаций")]
        ListOfEduOrg[] GetListOfEduOrg(int year);

    }
}
