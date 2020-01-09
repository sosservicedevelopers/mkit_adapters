
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
        ListOfCinemaOrg[] IGetLisencesSoap.GetListOfCinemaOrg(int year)
        {
            try
            {
                var q = from l in db.ListOfCinematography
                        join raion in db.DictDistrict on l.DictDistrictId equals raion.Id
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
                            Address = l.LegalAddress,
                            DictDistrict = raion.NameRus,
                            RegistrationDate = l.RegistrationDate
                        };
                ListOfCinemaOrg[] lst = new ListOfCinemaOrg[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfCinemaOrg { Name = item.Name, Address = item.Address, DictDistrict = item.DictDistrict, DictFinSource = item.DictFinSource, DictLegalForm = item.DictLegalForm, Director = item.Director, INN = item.INN, RegistrationDate = item.RegistrationDate };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

        ListOfCinemaDocs[] IGetLisencesSoap.GetListOfCinemaDocs(int year)
        {
            try
            {
                var q = from l in db.ListOfCinematographyCertificates
                            //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select l;


                ListOfCinemaDocs[] lst = new ListOfCinemaDocs[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfCinemaDocs { Name = item.NameRus, RegistrationDate = item.RegistrationDate };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }


        ListOfCinemaCert[] IGetLisencesSoap.GetListOfCinemaCert(int year)
        {
            try
            {
                var q = from l in db.ListOfCinematographyCertificates
                        join lf in db.DictCountry on l.DictCountryId equals lf.Id
                        join loc in db.DictCinemaRegiser on l.DictCinemaRegiserId equals loc.Id
                        join ini in db.DictCinemaDuration on l.DictCinemaAgeRestrictionsId equals ini.Id
                        join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            Country = lf.Name,
                            Years = l.Years,
                            Regiser = loc.LastName + " " + loc.FirstName,
                            Duration = ini.Name,
                            AgeRestrictions = age.Name,
                            RegistrationDate = l.RegistrationDate
                        };
                ListOfCinemaCert[] lst = new ListOfCinemaCert[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfCinemaCert { Name = item.Name, AgeRestrictions = item.AgeRestrictions, Country = item.Country, Duration = item.Duration, RegistrationDate = item.RegistrationDate, Regiser = item.Regiser, Years = item.Years };
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
