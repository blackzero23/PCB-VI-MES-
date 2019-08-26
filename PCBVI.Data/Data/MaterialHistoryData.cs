using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class MaterialHistoryData : EntityData<MaterialHistory>
    {
        
        public List<MaterialHistory> Search(int lotId)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.MaterialHistories
                            where x.LotId == lotId
                            select x;

                return query.ToList();
            }
        }
    }
}
