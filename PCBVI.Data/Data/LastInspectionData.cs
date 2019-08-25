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
        public List<LastInspection> Search(string companyName, string workerName, DateTime productionFrom, DateTime productionTo, int itemId,  int workPlaceId)
        {
           using(var context = DbContextFactory.Create())
            {
                //데이터 베이스 수정해야됨.
                var toAddDate = productionTo.AddDays(1);

                var query = from x in context.LastInspections
                            where x.ProductionDate >= productionFrom.Date && x.ProductionDate < toAddDate.Date
                            select x;

                if(string.IsNullOrWhiteSpace(companyName) == false)
                {
                    query = query.Where(x => x.OCompanyName.Contains(companyName));
                }

                if (string.IsNullOrWhiteSpace(workerName) == false)
                {
                    query = query.Where(x => x.WorkerName.Contains(workerName));
                }

                if (itemId != 0)
                {
                    query = query.Where(x => x.ItemId == itemId);
                }

                if (workPlaceId != 0)
                {
                    query = query.Where(x => x.WorkPlaceId == workPlaceId);
                }

                return query.ToList();
            }
        }
    }
}
