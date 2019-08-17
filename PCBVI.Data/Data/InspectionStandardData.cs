using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class InspectionStandardData : EntityData<InspectionStandard>
    {
        public List<InspectionStandard> Search(int InspectionStandardTypeId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from InspectionStandard in context.InspectionStandards
                            where InspectionStandard.InspectionStandardTypeId == InspectionStandardTypeId
                            select InspectionStandard;


                return query.ToList();
            }
        }

    }
}
