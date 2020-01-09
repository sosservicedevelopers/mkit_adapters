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
        [XRoadService("GetListProtectedMonum", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр охраняемых объектов культурного наследия")]
        ListOfMonumProt[] GetListProtectedMonum(int year);
    }
}
