using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class MaterialsManageData : EntityData<MaterialsManage>
    {
        public List<MaterialsManage> Search(int lotId, int processId, int materialStateId)
        {
           using(var context = DbContextFactory.Create())
            {
                var query = from x in context.MaterialsManages
                            select x;

                if(lotId != 0)
                {
                    query = query.Where(x => x.LotId == lotId);
                }
                if(processId != 0)
                {
                    query = query.Where(x => x.ProcessId == processId);
                }
                if(materialStateId != 0)
                {
                    query = query.Where(x => x.MaterialStateId == materialStateId);
                }

                return query.ToList();
            }
        }
    }
}
