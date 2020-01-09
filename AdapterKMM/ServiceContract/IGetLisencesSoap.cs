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

        [XRoadService("GetListOfEvtObj", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестро проведений культурно-массовых мероприятий и т.д.")]
        ListOfEvtObj[] GetListOfEvtObj(int year);

        
    }

     
}
