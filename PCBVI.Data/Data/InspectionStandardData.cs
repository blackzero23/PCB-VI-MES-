using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class InspectionStandardData : EntityData<InspectionStandard>
    {
        public List<InspectionStandard> Search(int inspectionStandardTypeId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.InspectionStandards
                            select x;

                if (inspectionStandardTypeId != 0)
                {
                    query = query.Where(x => x.InspectionStandardTypeId == inspectionStandardTypeId);
                }


                return query.ToList();
            }
        }

    }
}
