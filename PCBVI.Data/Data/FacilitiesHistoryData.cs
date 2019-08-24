using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
   public class FacilitiesHistoryData :EntityData<FacilitiesHistory>
    {

        public List<FacilitiesHistory> Search(int facilitiesId, int workPlaceId, int fHistoryDivisionId,
                                DateTime fromDate, DateTime toDate)
        {
            using(PCBVIEntities context = DbContextFactory.Create())
            {
                var _toDate = toDate.AddDays(1);

                var query = from x in context.FacilitiesHistories
                            where x.WorkDate >= fromDate.Date && x.WorkDate < _toDate.Date
                           // orderby x.WorkDate 
                            select x;

                if(facilitiesId != 0)
                {
                    query = query.Where(x => x.FacilitiesId == facilitiesId);
                }

                if(workPlaceId != 0)
                {
                    query = query.Where(x => x.WorkPlaceId == workPlaceId);
                }

                if(fHistoryDivisionId != 0)
                {
                    query = query.Where(x => x.FHistoryDivisionId == fHistoryDivisionId);
                }

                query = query.OrderBy(x => x.WorkDate);

                return query.ToList();
            }
        }
    }
}
