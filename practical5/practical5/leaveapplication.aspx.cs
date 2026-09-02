using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical5
{
    public partial class leaveapplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    lblDate.Text = Session["LeaveDate"].ToString();
                }
                if (Request.Cookies["EmployeeName"] != null)
                {
                    txtEmpName.Text = Request.Cookies["EmployeeName"].Value;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(chkRemember.Checked)
            {
                Response.Cookies["EmployeeName"].Value = txtEmpName.Text;
                Response.Cookies["EmployeeName"].Expires = DateTime.Now.AddDays(30);
            }

            lblData.Text = "Employee Name: " + txtEmpName.Text +
                "<br />Date: " + lblDate.Text +
                "<br />Leave Type: " + ddlLeaveType.SelectedItem.Text +
                "<br />Leave Reason: " + txtReason.Text;
        }
    }
}