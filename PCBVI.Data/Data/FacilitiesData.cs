using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
                            select x;

                if (facilitiesId != 0)
                {
                    query = query.Where(x => x.FacilitiesId == facilitiesId);
                }

                if (processId != 0)
                {
                    query = query.Where(x => x.ProcessId == processId);
                }

                return query.ToList();
            }
        }

       public Facility CheckSerialNo(int serialNo)
       {
           using (var context = DbContextFactory.Create())
           {
               var query = from x in context.Facilities
                           where x.FacilitiesSerialNo == serialNo
                           select x;

               var list = query.ToList();

               return list.FirstOrDefault();
           }
       }
    }
}
