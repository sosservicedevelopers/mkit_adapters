
using AdapterLibrary;
using AdapterMonListOfTourizm.DataContract;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdapterMonListOfTourizm.ServiceContract
{
    public class GetListOfTourizmDetailsWebServices : IGetLisencesSoap/*, IDisposable*/
    {
        aismkitdbContext db = new aismkitdbContext();

        ListOfEvtObj[] IGetLisencesSoap.GetListOfEvtObj(int year)
        {
            try
            {
                var q = from l in db.ListOfEvents
                        join lf in db.DictTypeOfKmm on l.DictTypeOfKmmid equals lf.Id
                        join loc in db.DictLoc on l.DistLocId equals loc.Id
                        join ini in db.DictInitiatorOfProj on l.DictInitiatorOfProjId equals ini.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            EvtName = lf.Name,
                            Location = loc.Name,
                            EventTopic = l.EventTopic,
                            StartDate = l.StartDateTime,
                            EndDate = l.EndDateTime,
                            Initiator = ini.Name
                        };
                ListOfEvtObj[] lst = new ListOfEvtObj[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfEvtObj { EvtName = item.EvtName, StartDate = item.StartDate, EndDate = item.EndDate, EventTopic = item.EventTopic, Initiator = item.Initiator, Location = item.Location };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
