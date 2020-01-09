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
 
        [XRoadService("GetListOfRentObject", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр по предоставлению в аренду зданий, помещений")]
        ListOfRntObjectRoom[] GetListOfRentObject(int year);
         
        
    }
     
}
