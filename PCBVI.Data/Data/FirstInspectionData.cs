using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class FirstInspectionData : EntityData<FirstInspection>
    {
        public List<FirstInspection> Search(string outCompanName, int itemId, DateTime fromDate, DateTime toDate)
        {
            using(PCBVIEntities context = DbContextFactory.Create())
            {
                var _toDateAdd = toDate.AddDays(1);

                var query = from x in context.FirstInspections
                    where x.EnterDate >= fromDate.Date && x.EnterDate < _toDateAdd.Date
                    select x;

                if(string.IsNullOrWhiteSpace(outCompanName) == false)
                {
                    query = query.Where(x => x.OCompanyName.Contains(outCompanName));
                }

                if(itemId != 0)
                {
                    query = query.Where(x => x.ItemId == itemId);
                }
                

                return query.ToList();
            }
        }
    }
}
