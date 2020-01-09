
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

         ListOfRntObjectRoom[] IGetLisencesSoap.GetListOfRentObject(int year)
        {
            try
            {
                var q = from l in db.ListOfRentsHistory
                        join lf in db.ListOfRents on l.ListOfRentsId equals lf.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            RentObj = lf.NameRus,
                            StartDate = l.StartDate,
                            EndDate = l.EndDate,
                            Cost = l.Cost
                        };
                ListOfRntObjectRoom[] lst = new ListOfRntObjectRoom[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfRntObjectRoom { RentObj = item.RentObj, StartDate = item.StartDate, EndDate = item.EndDate, Cost = item.Cost };
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
