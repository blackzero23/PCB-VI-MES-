using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ProductionHistoryData : EntityData<ProductionHistory>
    {
        public List<ProductionHistory> Search(int processId, DateTime fromDate, DateTime toDate)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.ProductionHistories
                            where x.ProcessId == processId && (x.ProductionDate >= fromDate || x.ProductionDate <= toDate)
                            select new
                            {
                                ProductionHistory = x,
                                processName = x.Process.Name,
                                itemName = x.Item.Name
                            };

                foreach (var x in query)
                {
                    x.ProductionHistory.ProcessName = x.processName;
                    x.ProductionHistory.ItemName = x.itemName;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.ProductionHistory);
            }
        }
    }
}
