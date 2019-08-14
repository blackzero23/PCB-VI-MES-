using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class EmployeeData :EntityData<Employee>
    {
        /// <summary>
        ///  //회원이 맞으면 true 아니면 false
        /// </summary>
        public Employee IsCorrectEmployee(string id, string password)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Employees
                    where x.Code.Equals(id) /*&& x.Password.Equals(password)*/
                    select x;

                return query.FirstOrDefault();
            }
        }

        public List<Employee> SeachEmployeeInfo(string employee, string department)
        {
            using(PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Employees
                            where x.Department.Equals(department) &&                  x.Name.Equals(employee)
                            select x;

                //나중에 NULL 체크해서 넣어야됨 

                return query.ToList();
            }
        }
    }
}
