using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class LastInspectionData : EntityData<LastInspection>
    {
        //public List<LastInspection> Search(string companyname, int EmployeeId, 
        //    int itemId, int workPlaceId, DateTime productionFrom, DateTime productionTo
        //    , DateTime InspectionFrom, DateTime InspectionTo)
        //{
        //    using(PCBVIEntities context = DbContextFactory.Create())
        //    {
        //        var query = 
        //    }
        //}
        public List<LastInspection> Search(string companyname, int employeeId, DateTime productionFrom, DateTime productionTo, int itemId, DateTime inspectionFrom, DateTime inspectionTo, int workPlaceId)
        {
           using(var context = DbContextFactory.Create())
            {
                //데이터 베이스 수정해야됨.
                var query = from x in context.LastInspections
                            where x.OCompanyName.Equals(companyname)
                            && (x.ProductionDate >= productionFrom || x.ProductionDate <= productionTo)
                            && x.ItemId == itemId
                            select x;

                return query.ToList();
            }
        }
    }
}
