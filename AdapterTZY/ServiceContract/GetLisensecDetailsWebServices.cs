
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

        ListOfTZY[] IGetLisencesSoap.GetListOfTZY(int year)
        {
            try
            {
                var q = from l in db.ListOfTheatrical
                        join dist in db.DictLegalForm on l.DictLegalFormId equals dist.Id
                        join loc in db.DictFinSource on l.DictFinSourceId equals loc.Id
                        //join fin in db.DictAwardsReason on l.DictAwardsReasonId equals fin.Id
                        //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            DictLegalForm = dist.NameRus,
                            INN = l.Inn,
                            Director = l.LastNameDirector + " " + l.FirstNameDirector,
                            ArtsDirector = l.LastNameOfArtsDirector + " " + l.FirstNameOfArtsDirector,
                            NumEmployees = l.NumEmployees,
                            DictFinSource = loc.NameRus,
                            RegistrationDate = l.ReregistrationDate
                        };
                ListOfTZY[] lst = new ListOfTZY[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfTZY { Name = item.Name, ArtsDirector = item.ArtsDirector, DictFinSource = item.DictFinSource, DictLegalForm = item.DictLegalForm, Director = item.Director, INN = item.INN, NumEmployees = item.NumEmployees, ReregistrationDate = item.RegistrationDate };
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
