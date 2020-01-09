
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

        ListOfEduOrg[] IGetLisencesSoap.GetListOfEduOrg(int year)
        {
            try
            {
                var q = from l in db.ListOfEduInstituts
                        join it in db.DictEduInstType on l.DictEduInstTypeId equals it.Id
                        join loc in db.DictLegalForm on l.DictLegalFormId equals loc.Id
                        join fin in db.DictFinSource on l.DictFinSourceId equals fin.Id
                        //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            DictLegalForm = loc.NameRus,
                            INN = l.Inn,
                            Director = l.LastNameDirector + " " + l.FirstNameDirector,
                            DictFinSource = fin.NameRus,
                            DictEduInstType = it.NameRus,
                            LegalDocuments = l.LegalDocuments,
                            RegistrationDate = l.RegistrationDate
                        };
                ListOfEduOrg[] lst = new ListOfEduOrg[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfEduOrg { Name = item.Name, DictEduInstType = item.DictEduInstType, LegalDocuments = item.LegalDocuments, DictFinSource = item.DictFinSource, DictLegalForm = item.DictLegalForm, Director = item.Director, INN = item.INN, RegistrationDate = item.RegistrationDate };
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
