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


        [XRoadService("GetListOfRntObject", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр по предоставлению в аренду зданий, помещений")]
        ListOfRntObject[] GetListOfRntRoomObject(int year);



        [XRoadService("GetListOfTZY", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр театрально-зрелищных учреждений")]
        ListOfTZY[] GetListOfTZY(int year);

        [XRoadService("GetListOfProtMonum", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестр охраняемых объектов культурного наследия")]
        ListOfProtMonum[] GetListOfProtMonum(int year);

        [XRoadService("GetListOfEvtObj", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестро по предоставлению залов, помещений и т.д.")]
        ListOfEvtObj[] GetListOfEvtObj(int year);

        [XRoadService("GetListOfRntObject", AddedInVersion = 1)]
        [XRoadTitle("RU", "Реестро по предоставлению залов, помещений и т.д.")]
        ListOfRntObject[] GetListOfRntObject(int year);

        
    }

    //public interface IPersonSoapService
    //{
    //    [XRoadService("GetPerson", AddedInVersion = 1)]
    //    [XRoadTitle("RU", "Сервис для выдачи персональных данных по пин")]
    //    PersonModel GetPerson(string pin);
    //}
}
