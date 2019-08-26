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
                    where x.LoginId.Equals(id) && x.Password.Equals(password)
                    select x;
               
                return query.FirstOrDefault();
            }
        }

        public Employee CheckLoginId(string id)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.Employees
                            where x.LoginId.Equals(id)
                            select x;

                return query.FirstOrDefault();
            }
        }
        
        public Employee CheckEmployeeCode(string code)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Employees
                            where x.Code.Equals(code)
                            select x;

                return query.FirstOrDefault();
            }
        }


        /// <summary>
        /// 사원 정보 조회 (departmentId, EmployeeNmae)
        /// </summary>
        public List<Employee> SeachEmployeeInfo(int id, string name)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.Employees
                            //where x.DepartmentId == id
                            select new
                            {
                                Employee = x,
                                DepartmentName =x.Department.Name
                            };
                if (id != 0)
                    query = query.Where(x => x.Employee.DepartmentId == id);

                if (string.IsNullOrWhiteSpace(name) == false)
                    query = query.Where(x => x.Employee.Name.Contains(name));

                foreach (var item in query)
                {
                    item.Employee.DepartmentName = item.DepartmentName;
                }
                

                var list = query.ToList();


                return list.ConvertAll(x => x.Employee);
            }
        }
    }
}
