using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class FacilitiesData : EntityData<Facility>
    {
       public List<Facility> Search(int facilitiesId, int processId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Facilities
                            where x.FacilitiesId == facilitiesId && x.ProcessId == processId
                            select x;

                return query.ToList();
            }
        }

    }
}
