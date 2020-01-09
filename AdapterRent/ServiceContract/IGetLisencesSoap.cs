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
     
        [XRoadService("GetListOfRntObject", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестро по предоставлению залов, помещений и т.д.")]
        ListOfRntObject[] GetListOfRntObject(int year);

        
    }
 
}
