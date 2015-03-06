using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_V1.Controller
{
    public class ApproveRequisitionController
    {
        public void getRequistionDetail()
        {
            //selected pending requisition
            //entities :
            //  {requisition_detail, item }
            //for what:
            //  {To get requisition details for a single Requisiiitoin//}
            //expected type:
            //  {requisition_detail}
            //if needed to combine types :
            //  {requistion_detail + item}
            //combined result:
            //  { }
        }
        public void approveRequisition(string status)
        {
            //entities :
            //  {requisition_detail, requisition }
            //for what:
            //  {To update status }
            //expected type:
            //  {requisition_detail or requisition ?}
            //if needed to combine types :
            //  {}
            //combined result:
            //  { }

            if (status == "approve") 
            {
                //approve requisition status or requisition detail status?
            }
            if (status == "reject")
            {
                //reject requisition status or requisition detail status?
            }
        }
    }
}