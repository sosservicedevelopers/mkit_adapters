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

    
        [XRoadService("GetListOfMedias", AddedInVersion = 1)]
        [XRoadTitle("RU", "Сервис для получения выданных разрешений СМИ по пин")]
        ListOfMedias GetListOfMedias(AddRequest request);
    }
     
}
