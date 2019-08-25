using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ProductionHistoryData : EntityData<ProductionHistory>
    {
        //조회 서치
        public List<ProductionHistory> Search(int processId, DateTime fromDate, DateTime toDate)
        {
            using (var context = DbContextFactory.Create())
            {
                DateTime _toDate = toDate.AddDays(1);

                var query = from x in context.ProductionHistories
                            where x.ProductionDate >= fromDate.Date && x.ProductionDate < _toDate.Date
                            select new
                            {
                                ProductionHistory = x,
                                processName = x.Process.Name,
                                itemName = x.Item.Name
                            };


                if (processId != 0)
                {
                    query = query.Where(x => x.ProductionHistory.ProcessId == processId);
                }

                foreach (var x in query)
                {
                    x.ProductionHistory.ProcessName = x.processName;
                    x.ProductionHistory.ItemName = x.itemName;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.ProductionHistory);
            }
        }
        //중복 체크
        public ProductionHistory DuplicateCheck(DateTime workOrderDate, int facilitiesId, int processId, int itemId)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.ProductionHistories
                            where x.ProductionDate == workOrderDate.Date && x.ProcessId == processId
                            && x.ItemId == itemId && x.FacilitiesId == facilitiesId
                            select x;

                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }

        //해당 이력의 일수, 설비, 공정, 품목에 해당하는 리스트를 가져온다.
        public List<ProductionHistory> GetWorkList(DateTime workOrderDate, int facilitiesId, int processId, int itemId)
        {
            {
                using (var context = DbContextFactory.Create())
                {
                    var query = from x in context.ProductionHistories
                                where x.ProductionDate == workOrderDate.Date && x.ProcessId == processId
                                && x.ItemId == itemId && x.FacilitiesId == facilitiesId
                                select x;

                    var list = query.ToList();

                    return list;
                }
            }
        }
    }
}
