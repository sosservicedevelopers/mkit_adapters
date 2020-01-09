
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

        ListOfMonument[] IGetLisencesSoap.GetListOfMonuments(int year)
        {
            try
            {
                var q = from l in db.ListOfMonuments
                        join lf in db.DictMonumentType on l.DictMonumentTypeId equals lf.Id
                        join d in db.DictDistrict on l.DictDistrictId equals d.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            DatingOfMonument = l.DatingOfMonument,
                            District = d.NameRus,
                            LegalAddress = l.LegalAddress,
                            MonumentType = lf.NameRus
                        };
                ListOfMonument[] lst = new ListOfMonument[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfMonument { DatingOfMonument = item.DatingOfMonument, District = item.District, LegalAddress = item.LegalAddress, MonumentType = item.MonumentType, Name = item.Name };
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
