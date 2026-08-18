using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class regform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode =
                System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void ValidateDepartment(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid =
                CSE.Checked ||
                IT.Checked ||
                CE.Checked ||
                ICT.Checked;
        }

        protected void ValidateSkills(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid =
                Java.Checked ||
                Python.Checked ||
                C.Checked;
        }

        protected void ValidateTerms(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid = CheckBox1.Checked;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "";

            Page.Validate();

            if (!Page.IsValid)
            {
                ResultLabel.ForeColor =
                    System.Drawing.Color.Red;

                ResultLabel.Text =
                    "Please correct the validation errors.";

                return;
            }

            string name = TextBox1.Text.Trim();
            string email = TextBox2.Text.Trim();
            string contact = TextBox3.Text.Trim();
            string college = TextBox4.Text.Trim();
            string eventName = EventDropDown.SelectedValue;
            string address = TextArea1.Text.Trim();

            string department = "";

            if (CSE.Checked)
                department = "CSE";
            else if (IT.Checked)
                department = "IT";
            else if (CE.Checked)
                department = "CE";
            else if (ICT.Checked)
                department = "ICT";

            string skills = "";

            if (Java.Checked)
                skills += "Java, ";

            if (Python.Checked)
                skills += "Python, ";

            if (C.Checked)
                skills += "C, ";

            if (skills.EndsWith(", "))
            {
                skills = skills.Substring(
                    0,
                    skills.Length - 2
                );
            }

            ResultLabel.ForeColor =
                System.Drawing.Color.Green;

            ResultLabel.Text =
                "Registration Successful!<br/><br/>" +
                "<b>Name:</b> " +
                Server.HtmlEncode(name) +
                "<br/>" +
                "<b>Email:</b> " +
                Server.HtmlEncode(email) +
                "<br/>" +
                "<b>Contact No:</b> " +
                Server.HtmlEncode(contact) +
                "<br/>" +
                "<b>College:</b> " +
                Server.HtmlEncode(college) +
                "<br/>" +
                "<b>Event:</b> " +
                Server.HtmlEncode(eventName) +
                "<br/>" +
                "<b>Department:</b> " +
                Server.HtmlEncode(department) +
                "<br/>" +
                "<b>Skills:</b> " +
                Server.HtmlEncode(skills) +
                "<br/>" +
                "<b>Address:</b> " +
                Server.HtmlEncode(address);
        }
    }
}