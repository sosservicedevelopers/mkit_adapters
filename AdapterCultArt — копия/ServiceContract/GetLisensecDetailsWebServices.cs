
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

        ListOfRntObject[] IGetLisencesSoap.GetListOfRntRoomObject(int year)
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
                ListOfRntObject[] lst = new ListOfRntObject[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfRntObject { RentObj = item.RentObj, StartDate = item.StartDate, EndDate = item.EndDate, Cost = item.Cost };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

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
                            Director= l.LastNameDirector + " " + l.FirstNameDirector,
                            ArtsDirector = l.LastNameOfArtsDirector+" "+l.FirstNameOfArtsDirector,
                            NumEmployees = l.NumEmployees,
                            DictFinSource=loc.NameRus,
                            RegistrationDate = l.ReregistrationDate
                        };
                ListOfTZY[] lst = new ListOfTZY[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfTZY { Name = item.Name, ArtsDirector = item.ArtsDirector, DictFinSource = item.DictFinSource, DictLegalForm = item.DictLegalForm, Director = item.Director, INN=item.INN, NumEmployees=item.NumEmployees, ReregistrationDate=item.RegistrationDate };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }


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
                            Name = l.LastNameDirector+" "+l.FirstNameDirector,
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
                    lst[ind] = new ListOfStateAward { Name = item.Name, DictAwardsPosition = item.DictAwardsPosition, DictAwardsReason = item.DictAwardsReason, DictStateAwardsType = item.DictStateAwardsType, RegistrationDate = item.RegistrationDate};
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

        ListOfProtMonum[] IGetLisencesSoap.GetListOfProtMonum(int year)
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
                            DictDistrict=dist.NameRus,
                            Address = l.LegalAddress,
                            DictFinSource = fin.NameRus,
                            Director = l.LastNameDirector+" "+l.FirstNameDirector,
                            Contacts=l.Contacts,
                            LegalDocs = l.LegalDocs,
                            Ploshad = l.Ploshad,
                            CurrentStatus = l.CurrentStatus
                        };
                ListOfProtMonum[] lst = new ListOfProtMonum[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfProtMonum { Name = item.Name, Address = item.Address, Contacts= item.Contacts, CurrentStatus = item.CurrentStatus, DictDistrict= item.DictDistrict, DictFinSource= item.DictFinSource, Director= item.Director, LegalDocs= item.LegalDocs,Ploshad= item.Ploshad};
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }


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
                    lst[ind] = new ListOfEduOrg { Name = item.Name, DictEduInstType = item.DictEduInstType, LegalDocuments= item.LegalDocuments, DictFinSource = item.DictFinSource, DictLegalForm = item.DictLegalForm, Director = item.Director, INN = item.INN, RegistrationDate = item.RegistrationDate };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

        ListOfCinemaOrg[] IGetLisencesSoap.GetListOfCinemaOrg(int year)
        {
            try
            {
                var q = from l in db.ListOfCinematography
                        join raion in db.DictDistrict on l.DictDistrictId equals raion.Id
                        join loc in db.DictLegalForm on l.DictLegalFormId  equals loc.Id
                        join fin in db.DictFinSource on l.DictFinSourceId equals fin.Id
                        //join age in db.DictCinemaAgeRestrictions on l.DictCinemaAgeRestrictionsId equals age.Id
                        //where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            DictLegalForm = loc.NameRus,
                            INN=l.Inn,
                            Director = l.LastNameDirector + " " + l.FirstNameDirector,
                            DictFinSource = fin.NameRus,
                            Address = l.LegalAddress,
                            DictDistrict=raion.NameRus,
                            RegistrationDate = l.RegistrationDate
                        };
                ListOfCinemaOrg[] lst = new ListOfCinemaOrg[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfCinemaOrg { Name = item.Name, Address = item.Address, DictDistrict= item.DictDistrict,  DictFinSource= item.DictFinSource, DictLegalForm= item.DictLegalForm, Director= item.Director, INN = item.INN, RegistrationDate=item.RegistrationDate};
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
                    lst[ind] = new ListOfCinemaDocs { Name = item.NameRus,  RegistrationDate = item.RegistrationDate};
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
                            Country = lf.Name ,
                            Years = l.Years,
                            Regiser = loc.LastName+" "+loc.FirstName,
                            Duration = ini.Name,
                            AgeRestrictions=age.Name,
                            RegistrationDate=l.RegistrationDate
                        };
                ListOfCinemaCert[] lst = new ListOfCinemaCert[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfCinemaCert {Name=item.Name, AgeRestrictions=item.AgeRestrictions, Country=item.Country, Duration=item.Duration, RegistrationDate=item.RegistrationDate, Regiser=item.Regiser, Years=item.Years };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

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
                            Location=loc.Name,
                            EventTopic=l.EventTopic,
                            StartDate = l.StartDateTime,
                            EndDate = l.EndDateTime,
                            Initiator = ini.Name
                        };
                ListOfEvtObj[] lst = new ListOfEvtObj[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfEvtObj { EvtName = item.EvtName, StartDate = item.StartDate, EndDate = item.EndDate, EventTopic= item.EventTopic, Initiator=item.Initiator, Location=item.Location };
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

        ListOfRntObject[] IGetLisencesSoap.GetListOfRntObject(int year)
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
                ListOfRntObject[] lst = new ListOfRntObject[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfRntObject { RentObj = item.RentObj, StartDate= item.StartDate, EndDate= item.EndDate, Cost= item.Cost};
                    ind++;
                }

                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }

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
        ListOfCinematographys IGetLisencesSoap.GetListOfCinematografy(AddRequest request)
        {
            ListOfCinematographys details = null;              
                try
                {
                    var q = from l in db.ListOfCinematography
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
                    details = new ListOfCinematographys();
                    details.INN = obj.INN;
                    details.DictLegalForm = obj.DictLegalForm;
                    details.NameRus = obj.Name;
                    details.LegalAddress = obj.LegalAdres;
                    details.LastNameDirector = obj.fio;
                    details.Dictrict = obj.raion;
                    details.RegistrationDate = obj.RegistrationDate ?? null;


                    return details;
                }
                catch (Exception exp)
                {
                    exp.GetType();
                    return null;
                }

            }
        ListOfMedias IGetLisencesSoap.GetListOfMedias(AddRequest request)
        {
            ListOfMedias details = null;
            try
            {
                var q = from l in db.ListOfMedia
                        join lf in db.DictLegalForm on l.DictLegalFormId equals lf.Id
                        join mt in db.DictMediaType on l.DictMediaTypeId equals mt.Id
                        join ltr in db.ListOfTeleRadio on l.Id equals ltr.ListOfMediaId
                        join ag in db.DictAgencyPerm on ltr.DictAgencyPermId equals ag.Id
                        join lcm in db.ListOfControlMedia on l.Id equals lcm.ListOfMediaId into gj
                        from subpet in gj.Where(lcm => lcm.WarningDate != null & lcm.WarningRemovalDate == null & lcm.AnulmentDate == null).DefaultIfEmpty()
                        where mt.Id > 2 & l.EliminationDate == null //& gj.AnulmentDate==null & lcm.WarningEndDate!=null
                        select new
                        {
                            Name = l.NameRus,
                            LegalForm = lf.NameRus,
                            INN = l.Inn,
                            RegisterDate = l.RegistrationDate,
                            MediaType = mt.NameRus,
                            PermisionNo = ltr.NumberOfPermission,
                            PermisionDate = ltr.PermissionDate,
                            DepPermGive = ag.NameRus,
                            WarningDate = subpet.WarningDate == null ? null : subpet.WarningDate,
                            WarningEndDate = subpet.WarningEndDate == null ? null : subpet.WarningEndDate
                            //WarningEndDate = subpet.WarningEndDate

                        };
                var obj= q.FirstOrDefault();
                details = new ListOfMedias();
                details.DepPermGive = obj.DepPermGive;
                details.DictLegalForm = obj.DepPermGive;
                details.INN = obj.INN;
                details.MediaType = obj.MediaType;
                details.Name = obj.Name;
                details.PermisionDate = obj.PermisionDate;
                details.PermisionNo = obj.PermisionNo.ToString();
                details.RegistrationDate = obj.RegisterDate;
                details.WarningDate = obj.WarningDate;
               details.WarningEndDate = obj.WarningEndDate;               
            }
            catch (Exception exp)
            {
                return null;
            }
            return details;
        }

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
                            District=d.NameRus,
                            LegalAddress=l.LegalAddress,
                            MonumentType=lf.NameRus
                        };
                ListOfMonument[] lst = new ListOfMonument[q.Count()];
                int ind = 0;
                foreach (var item in q.ToList())
                {
                    lst[ind] = new ListOfMonument { DatingOfMonument = item.DatingOfMonument, District = item.District, LegalAddress = item.LegalAddress, MonumentType = item.MonumentType, Name = item.Name };
                    ind++;
                }
                
                return lst ;
            }
            catch (Exception)
            {
                return null;
            }
        }





        /*
         *    ListOfTourizm IGetLisencesSoap.GetListOfTourizm(AddRequest request)
        {
            ListOfTourizm details = null;
           
            try
            {    
               NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Database=aismkitdb;User Id=postgres; Password=admin;");
                conn.Open();
                //string q = "Select t.INN, dlf.NameRus DictLegalForm, t.NameRus [Name], t.LegalAddress," +
                //    " t.LastNameDirector+' '+t.FirstNameDirector FIO, d.NameRus raion, t.RegistrationDate"+
                //    "  from 'ListOfTourism' t, 'DictDistrict' d," +
                //    " 'DictLegalForm' dlf where t.DictDistrictId=d.Id and  t.DictLegalFormId=dlf.Id";// where inn=@inn and reg_number=@reg_number";
                //string q = "Select t.'INN', dlf.'NameRus' as DictLegalForm,  t.'NameRus' as Name, t.'LegalAddress'," +
                //            " t.'LastNameDirector', t.'FirstNameDirector', d.'NameRus' as raion, t.'RegistrationDate'" +
                //            " from 'ListOfTourism' as t, 'DictDistrict' d, 'DictLegalForm' dlf " +
                //            " where t.'DictDistrictId' = d.'Id'  and t.'DictLegalFormId' = dlf.'Id'";
                string q = "Select t.INN, dlf.NameRus as DictLegalForm,  t.NameRus as Name, t.LegalAddress," +
                          " t.LastNameDirector, t.FirstNameDirector, d.NameRus as raion, t.RegistrationDate" +
                          " from public.ListOfTourism as t, public.DictDistrict as d, public.DictLegalForm as dlf " +
                          " where t.DictDistrictId = d.Id  and t.DictLegalFormId = dlf.Id";
                q = "Select * from [ListOfTourism]";
                NpgsqlCommand command = new NpgsqlCommand(q, conn);

                // Execute the query and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows
                while (dr.Read())
                {
                    details = new ListOfTourizm();
                    details.INN = (string)dr["INN"];
                    details.DictLegalForm = (string)dr["DictLegalForm"];
                    details.NameRus = (string)dr["Name"];
                    details.LegalAddress = (string)dr["LegalAddress"];
                    details.NameDirector = (string)dr["FIO"];
                    details.District = (string)dr["raion"];
                    details.RegistrationDate = ((DateTime?)dr["RegistrationDate"]) ?? null;
                }

                return details;
            }
            catch (Exception exp)
            {
                exp.GetType();
                return null;
            }
        }
 

         */


        /*
         *  public ListOfTourizm GetListOfTourizm(AddRequest request)
        {
            ListOfTourizm details = null;
            string conString = "Server=(localdb)\\mssqllocaldb;Database=AisMKIT;Trusted_Connection=True;MultipleActiveResultSets=true";
            // "DefaultConnection": "Server=212.112.106.181;Port=5432;Database=aismkitdb;User Id=postgres; Password=dbPwdAdmin;"
            //"DefaultConnection": "Server=192.168.161.130;Port=5432;Database=aismkitdb;User Id=postgres; Password=dbPwdAdmin;"
            try
            {
                SqlConnection con = new SqlConnection(conString);
                string q = "Select Top 1 t.INN, dlf.NameRus DictLegalForm, t.NameRus Name, t.LegalAddress," +
                    " t.LastNameDirector+' '+t.FirstNameDirector FIO, d.NameRus raion  from ListOfTourism t, DictDistrict d, DictLegalForm dlf where t.DictDistrictId=d.Id and  t.DictLegalFormId=dlf.Id";// where inn=@inn and reg_number=@reg_number";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                //cmd.Parameters.AddWithValue("inn", request.INN);
                //cmd.Parameters.AddWithValue("reg_number", request.NumberOfLisences);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        details = new ListOfTourizm();
                        details.INN = (string)dr["INN"];
                        details.DictLegalForm = (string)dr["DictLegalForm"];
                        details.NameRus = (string)dr["Name"];
                        details.LegalAddress = (string)dr["LegalAddress"];
                        details.NameDirector = (string)dr["FIO"];
                        details.District = (string)dr["raion"];
                        details.RegistrationDate = ((DateTime?)dr["RegistrationDate"]) ?? null;
                    }
                }

                return details;
            }
            catch (Exception exp)
            {
                exp.GetType();
                return null;
            }
        }
         */
    }
}
