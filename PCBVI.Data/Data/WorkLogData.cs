using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class WorkLogData : EntityData<WorkLog>
    {
        public List<WorkLog> Search(int itemId, int rotationId, DateTime fromDate, DateTime toDate)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                DateTime addTodate = toDate.AddDays(1);

                var query = from x in context.WorkLogs
                            where x.WorkDate >= fromDate.Date && x.WorkDate < addTodate
                            select new
                            {
                                WorkLog = x,
                                EmployeeName = x.WorkOrder.WorkerName,
                                Processname = x.Process.Name,
                                FaciliesName = x.Facility.Name,
                                RotaionGroupname = x.RotationGroup.Name
                            };

                if (itemId != 0)
                {
                    query = query.Where(x => x.WorkLog.ItemId == itemId);
                }

                if (rotationId != 0)
                {
                    query = query.Where(x => x.WorkLog.RotationGroupId == rotationId);
                }


                foreach (var x in query)
                {
                    x.WorkLog.EmployeeName = x.EmployeeName;
                    x.WorkLog.ProcessName = x.Processname;
                    x.WorkLog.FaciliesName = x.FaciliesName;
                    x.WorkLog.RotaionGroupName = x.RotaionGroupname;
                }

                var list = query.ToList();


                return list.ConvertAll(x => x.WorkLog);
            }


            //public string EmployeeName { get; set; }
            //public string ProcessName { get; set; }
            //public string FaciliesName { get; set; }
            //public string RotaionGroupName { get; set; }
        }

        /// <summary>
        /// 작업일보에 해당 작업지시를 가지고 있으면 true. 없으면 false.
        /// </summary>       
        public bool HasWorkOrderId(int workOrderId)
        {
            using(var context = DbContextFactory.Create())
            {
                var qurey = from x in context.WorkLogs
                            where x.WorkOrderId == workOrderId
                            select x;
                var list = qurey.ToList();

                if (list.FirstOrDefault() == null)
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// 작업일지에 등록된 작업지시서ID를 검색 반환.
        /// </summary>      
        public WorkLog SearhWorkDateFirst(int workOrderId)
        {
           using(var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkLogs
                            where x.WorkOrderId == workOrderId
                            select x;
                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }

        /// <summary>
        /// 오늘 해당 작업 일지 목록
        /// </summary>
        
        public List<WorkLog> SetWorkLogList()
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkLogs
                    orderby x.WorkDate descending 
                    select x;

                return query.ToList();
            }
        }

        /// <summary>
        /// 작업이 끝났으면 true 
        /// </summary>
        public bool IsOver(int workOrderId)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkLogs
                    where x.WorkOrderId == workOrderId && x.EndTime == null
                    select x;

                return query.FirstOrDefault() == null;
            }
        }
    }
}
