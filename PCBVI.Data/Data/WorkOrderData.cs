using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class WorkOrderData :EntityData<WorkOrder>
    {
        public List<WorkOrder> Search(int itemId, int rotationId, DateTime fromDate, DateTime ToDate)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.WorkOrders
                    where x.ItemId == itemId && x.RotationGroupId == rotationId
                                             && (x.OrderDate >= fromDate || x.OrderDate <= ToDate)
                    select x;

                
                return query.ToList();
            }
        }

        public List<WorkOrder> ToDayWorkOrderList()
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkOrders
                            where x.OrderDate == DateTime.Today
                            select x;

                return query.ToList();
            }
        }
    }
}
