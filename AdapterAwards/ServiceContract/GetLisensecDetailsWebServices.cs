
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

        ListOfStateAward[] IGetLisencesSoap.GetListOfStateAward(int year)
        {
            try
            {
                var q = from l in db.ListOfStateAwards
                        join dist in db.DictStateAwardsType on l.DictStateAwardsTypeId equals dist.Id
                        join loc in db.DictAwardsPosition on l.DictAwardsPositionId equals loc.Id
                        join fin in db.DictAwardsReason on l.DictAwardsReasonId equals fin.Id
                        //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.LastNameDirector + " " + l.FirstNameDirector,
                            DictStateAwardsType = dist.NameRus,
                            DictAwardsPosition = loc.NameRus,
                            DictAwardsReason = fin.NameRus,
                            Director = l.LastNameDirector + " " + l.FirstNameDirector,
                            RegistrationDate = l.RegistrationDate
                        };
                ListOfStateAward[] lst = new ListOfStateAward[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfStateAward { Name = item.Name, DictAwardsPosition = item.DictAwardsPosition, DictAwardsReason = item.DictAwardsReason, DictStateAwardsType = item.DictStateAwardsType, RegistrationDate = item.RegistrationDate };
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
