using System;
using System.Collections.Generic;
using System.Linq;
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
                var query = from x in context.WorkLogs
                            where x.ItemId == itemId && x.RotationGroupId == rotationId
                            && (x.WorkDate >= fromDate || x.WorkDate <= toDate)
                            select new
                            {
                                WorkLog = x,
                                EmployeeName = x.WorkOrder.WorkerName,
                                Processname = x.Process.Name,
                                FaciliesName = x.Facility.Name,
                                RotaionGroupname = x.RotationGroup.Name
                            };


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
        /// 해당 작업지시 가지고 있으면 true. 없으면 false.
        /// </summary>       
        public bool HasWorkOrderId(int workOrderId)
        {
            using(var context = DbContextFactory.Create())
            {
                var qurey = from x in context.WorkOrders
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
    }
}
