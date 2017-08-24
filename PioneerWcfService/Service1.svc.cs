using PioneerTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PioneerConsultancy.DAL;

namespace PioneerWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int TakeProjectDetail(ProjectModel myProject)
        {
            EmployeeDataAccessLayer employee = new EmployeeDataAccessLayer();

              //return employee.TakeEmployeeName(myEmployee);
              
                var result = employee.TakeProjectDetail(myProject);
            return result;


        }

        //public int TakeEmployeeName(EmployeeModel myEmployee)
        //{
        //    EmployeeDataAccessLayer employee = new EmployeeDataAccessLayer();

        //    //return employee.TakeEmployeeName(myEmployee);
        //    int result = employee.TakeEmployeeName(myEmployee);
        //    return 1;
        //}
    }
}