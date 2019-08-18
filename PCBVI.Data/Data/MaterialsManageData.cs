using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class MaterialsManageData : EntityData<MaterialsManage>
    {
        public List<MaterialsManage> Search(int lotId, int processId, int workPlaceId)
        {
           using(var context = DbContextFactory.Create())
            {
                var query = from x in context.MaterialsManages
                            where x.LotId == lotId && x.ProcessId == processId && x.MaterialStateId == workPlaceId
                            select x;

                return query.ToList();
            }
        }
    }
}
