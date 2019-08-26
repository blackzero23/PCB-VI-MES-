using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
                DateTime addDateTiem = workOrderDate.AddDays(1);

                var query = from x in context.FacilitiesPowers
                            where (x.WorkDate >= workOrderDate.Date && x.WorkDate < addDateTiem.Date)
                                  && x.ProcessId == processId
                            && x.FacilitiesId == facilitiesId
                            select x;

                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }

        /// <summary>
        /// 검색창 조회
        /// </summary>
        public List<FacilitiesPower> Search(int processId, int facilitiesId, DateTime fromDate, DateTime toDate)
        {
            using (var context = DbContextFactory.Create())
            {
                var _toDate = toDate.Add(new System.TimeSpan(1, 0, 0, 0));
                

                var query = from x in context.FacilitiesPowers
                            where x.WorkDate >= fromDate.Date && x.WorkDate <= _toDate
                            select x;

                if(processId != 0)
                {
                    query = query.Where(x => x.ProcessId == processId);
                }

                if(facilitiesId != 0)
                {
                    query = query.Where(x => x.FacilitiesId == facilitiesId);
                }
             

                return query.ToList();
            }
        }

        public List<FacilitiesPower> TodayFacilitiesList()
        {
            var today = DateTime.Today;
            var answer = today.AddDays(-7);
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.FacilitiesPowers
                    where x.WorkDate <= answer || x.WorkDate >= today
                    select x;

                return query.ToList();
            }
        }
    }
}
