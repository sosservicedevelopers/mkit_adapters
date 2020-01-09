
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


        ListOfProtMonum[] IGetLisencesSoap.GetListOfObjCult(int year)
        {
            try
            {
                var q = from l in db.ListOfMonumentsProtObjects
                        join dist in db.DictDistrict on l.DictDistrictId equals dist.Id
                        //join loc in db.DictLegalForm on l.DictLegalFormId equals loc.Id
                        join fin in db.DictFinSource on l.DictFinSourceId equals fin.Id
                        //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            DictDistrict = dist.NameRus,
                            Address = l.LegalAddress,
                            DictFinSource = fin.NameRus,
                            Director = l.LastNameDirector + " " + l.FirstNameDirector,
                            Contacts = l.Contacts,
                            LegalDocs = l.LegalDocs,
                            Ploshad = l.Ploshad,
                            CurrentStatus = l.CurrentStatus
                        };
                ListOfProtMonum[] lst = new ListOfProtMonum[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfProtMonum { Name = item.Name, Address = item.Address, Contacts = item.Contacts, CurrentStatus = item.CurrentStatus, DictDistrict = item.DictDistrict, DictFinSource = item.DictFinSource, Director = item.Director, LegalDocs = item.LegalDocs, Ploshad = item.Ploshad };
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
