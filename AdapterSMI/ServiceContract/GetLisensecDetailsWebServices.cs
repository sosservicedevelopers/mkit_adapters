
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
                var obj = q.FirstOrDefault();
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

    }
}
