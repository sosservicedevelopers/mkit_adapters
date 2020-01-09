
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
 
       
        ListIndicatorsOfTourizm IGetLisencesSoap.GetListOfTourizmIndicators(int year)
        {
            ListIndicatorsOfTourizm details = null;
            string y = year.ToString();
            
            try
            {
                ListOfTourismIndicator obj = db.ListOfTourismIndicator.Where(x => x.Year == y).FirstOrDefault();
                details = new ListIndicatorsOfTourizm();
                details.AverageMonthSalary = obj.AverageMonthSalary;
                details.Gdp = obj.Gdp;
                details.OutTurist = obj.OutTurist;
                details.SummOfForeignInvest = obj.SummOfForeignInvest;
                details.SummOfInvestFromBudget = obj.SummOfInvestFromBudget;
                details.SummOfPrivateDomesticInvest = obj.SummOfPrivateDomesticInvest;
                details.VolumeOfServicesForExport = obj.VolumeOfServicesForExport;
                details.VolumeOfServicesForImport = obj.VolumeOfServicesForImport;
                details.Year = details.Year;

            }
            catch (Exception ex)
            {
                return null;
            }
            return details;
        }
        
        ListOfTourizm IGetLisencesSoap.GetListOfTourizm(AddRequest request)
        {
            ListOfTourizm details = null;
           
            try
            {
                var q = from l in db.ListOfTourism
                        join lf in db.DictLegalForm on l.DictLegalFormId equals lf.Id
                        join r in db.DictDistrict on l.DictDistrictId equals r.Id
                        select new
                        {
                            INN = l.Inn,
                            DictLegalForm = lf.NameRus,
                            Name = l.NameRus,
                            LegalAdres = l.LegalAddress,
                            fio = l.LastNameDirector + " " + l.FirstNameDirector,
                            raion = r.NameRus,
                            RegistrationDate = l.RegistrationDate
                        };
                var obj = q.FirstOrDefault();
                details = new ListOfTourizm();
                details.INN = obj.INN;
                details.DictLegalForm = obj.DictLegalForm;
                details.NameRus = obj.Name;
                details.LegalAddress = obj.LegalAdres;
                details.NameDirector = obj.fio;
                details.District = obj.raion;
                details.RegistrationDate =  obj.RegistrationDate ?? null;


                return details;
            }
            catch (Exception exp)
            {
                exp.GetType();
                return null;
            }
        }
         }
}
