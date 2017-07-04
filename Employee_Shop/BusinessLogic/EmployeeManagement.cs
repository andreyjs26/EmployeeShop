using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeManagement
    {

       private EmployeeShopEntities employee = new EmployeeShopEntities();

       public void InsertEmployee(Object obj)
       {
           if (obj != null) {

               employee.tbl_Employee.Add(obj);
           
           }       
       }

       public void DeleteEmployee(int id)
       {
           var obj = employee.tbl_Employee.Find(id);

           employee.tbl_Employee.Remove(obj);
       
       }

       public Object RetrieveSpecificEmployee(int id)
       {
           var obj = employee.tbl_Employee.Find(id);

           return obj;
       }

       public List<Object> RetrieveListEmployee()
       {
           var result = employee.tbl_Employee.FindAll();
           return result;
       }


    }
}
