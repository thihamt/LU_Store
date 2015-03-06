using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_V1.Controller
{
    public class DepartmentDetailController
    {
        public void getDepartmentDetail()
        {
            //get collectionpoint name
            //entities :
            //  {department_detail, collection_point }
            //for what:
            //  {To get collection point name for a single department//}
            //expected type:
            //  {collection_point}
            //if needed to combine types :
            //  {department_detail + collection_point}
            //combined result:
            //  { }

            //get representative name
            //entities :
            //  {department_detail, employee }
            //for what:
            //  {To get employee name(type=representative) for a single department//}
            //expected type:
            //  {employee}
            //if needed to combine types :
            //  {department_detail + employee}
            //combined result:
            //  { }
        }
        public void getAllCollectionPoint()
        {
            //entities :
            //  {collection_point }
            //for what:
            //  {To get all collection point name}
            //expected type:
            //  {collection_point}
            //if needed to combine types :
            //  {}
            //combined result:
            //  { }
        }
        public void getEmployee(string emp_type)
        {
            if (emp_type == "representative")
            {
                //get representaive name
              
                //entities :
                //  {employee}
                //for what:
                //  {To get all employee name(type=representative)}
                //expected type:
                //  {employee}
                //if needed to combine types :
                //  {}
                //combined result:
                //  {}
            }
        }
        public void getAllEmployee()
        {
            //get all employee name
            //entities :
            //  {employee}
            //for what:
            //  {To get all employee name}
            //expected type:
            //  {employee}
            //if needed to combine types :
            //  {}
            //combined result:
            //  {}
        }
        public void save(string forwhat)
        {
            if (forwhat == "collection point")
            {
                // update colleciton point
                //entities :
                //  {department_detail}
                //for what:
                //  {To update collecion point for single department}
                //expected type:
                //  {department_detail}
                //if needed to combine types :
                //  {}
                //combined result:
                //  {}
            }
            if (forwhat == "representative")
            {
                // update representative
                //entities :
                //  {department_detail}
                //for what:
                //  {To update representative for single department}
                //expected type:
                //  {employee}
                //if needed to combine types :
                //  {}
                //combined result:
                //  {}
            }
            if (forwhat == "deputy")
            {
                // update employee delegation
                //entities :
                //  {employeee_delegation}
                //for what:
                //  {To update whom_to_delegate  }
                //expected type:
                //  {employee_delegation}
                //if needed to combine types :
                //  {}
                //combined result:
                //  {}
            }
        }
    }
}