
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

  
        ListOfLibOrg[] IGetLisencesSoap.GetListOfLibOrg(int year)
        {
            try
            {
                var q = from l in db.ListOfLibraryIndicators
                            //join it in db.DictEduInstType on l.DictEduInstTypeId equals it.Id
                            //join loc in db.DictLegalForm on l.DictLegalFormId equals loc.Id
                            //join fin in db.DictFinSource on l.DictFinSourceId equals fin.Id
                            //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                            //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.LibraryName,
                            DataSozdania=l.DataSozdania,
                            CountOfBook=l.CountOfBook,
                            CountOfReaders=l.CountOfReaders,
                            CountOfEmp = l.CountOfEmp,
                            Knigovydacha = l.Knigovydacha,
                            CopKyrg = l.CopKyrg,
                            EventsLib = l.EventsLib,
                            DegEducation=l.DegEducation,
                            PravaUstanavDoc=l.PravaUstanavDoc
                        };
                ListOfLibOrg[] lst = new ListOfLibOrg[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfLibOrg { Name = item.Name, PravaUstanavDoc = item.PravaUstanavDoc, CopKyrg = item.CopKyrg, CountOfBook= item.CountOfBook, CountOfEmp= item.CountOfEmp, CountOfReaders= item.CountOfReaders, DataSozdania = item.DataSozdania, DegEducation= item.DegEducation, EventsLib=item.EventsLib, Knigovydacha=item.Knigovydacha};
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
