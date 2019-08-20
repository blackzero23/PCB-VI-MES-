using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class FacilitiesPowerData : EntityData<FacilitiesPower>
    {
        public FacilitiesPower SearchDateInfo(DateTime workOrderDate, int processId, int facilitiesId)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.FacilitiesPowers
                            where x.WorkDate.Date == workOrderDate.Date && x.ProcessId == processId
                            && x.FacilitiesId == facilitiesId
                            select x;

                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }
    }
}
