<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regform.aspx.cs" Inherits="Practical4.regform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>

    <script type="text/javascript">

        function ValidateDepartmentClient(sender, args) {
            var radios = document.querySelectorAll(
                'input[type="radio"][name*="Department"]'
            );

            args.IsValid = false;

            for (var i = 0; i < radios.length; i++) {
                if (radios[i].checked) {
                    args.IsValid = true;
                    break;
                }
            }
        }

        function ValidateSkillsClient(sender, args) {
            var checkboxes = document.querySelectorAll(
                'input[type="checkbox"][id*="Java"], ' +
                'input[type="checkbox"][id*="Python"], ' +
                'input[type="checkbox"][id*="C"]'
            );

            args.IsValid = false;

            for (var i = 0; i < checkboxes.length; i++) {
                if (checkboxes[i].checked) {
                    args.IsValid = true;
                    break;
                }
            }
        }

        function ValidateTermsClient(sender, args) {
            var checkbox = document.getElementById(
                '<%= CheckBox1.ClientID %>'
            );

            args.IsValid = checkbox != null && checkbox.checked;
        }

    </script>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Online Event Registration</h2>
        <br />

        <asp:Label
            ID="Label1"
            runat="server"
            Text="Name:">
        </asp:Label>

        <asp:TextBox
            ID="TextBox1"
            runat="server">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            runat="server"
            ControlToValidate="TextBox1"
            ErrorMessage="Name is required."
            Text="Name is required."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="NameValidator"
            runat="server"
            ControlToValidate="TextBox1"
            ValidationExpression="^[A-Za-z ]+$"
            ErrorMessage="Name should contain only letters and spaces."
            Text="Name should contain only letters and spaces."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RegularExpressionValidator>

        <br /><br />

        <asp:Label
            ID="Label2"
            runat="server"
            Text="Email Id:">
        </asp:Label>

        <asp:TextBox
            ID="TextBox2"
            runat="server">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator2"
            runat="server"
            ControlToValidate="TextBox2"
            ErrorMessage="Email is required."
            Text="Email is required."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="EmailValidator"
            runat="server"
            ControlToValidate="TextBox2"
            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ErrorMessage="Enter a valid email address."
            Text="Enter a valid email address."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RegularExpressionValidator>

        <br /><br />

        <asp:Label
            ID="Label3"
            runat="server"
            Text="Contact No:">
        </asp:Label>

        <asp:TextBox
            ID="TextBox3"
            runat="server"
            MaxLength="10">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator3"
            runat="server"
            ControlToValidate="TextBox3"
            ErrorMessage="Contact number is required."
            Text="Contact number is required."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="ContactValidator"
            runat="server"
            ControlToValidate="TextBox3"
            ValidationExpression="^[0-9]{10}$"
            ErrorMessage="Contact number must contain exactly 10 digits."
            Text="Contact number must contain exactly 10 digits."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RegularExpressionValidator>

        <br /><br />

        <asp:Label
            ID="Label4"
            runat="server"
            Text="College:">
        </asp:Label>

        <asp:TextBox
            ID="TextBox4"
            runat="server">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator4"
            runat="server"
            ControlToValidate="TextBox4"
            ErrorMessage="College name is required."
            Text="College name is required."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <br /><br />

        <asp:Label
            ID="Label8"
            runat="server"
            Text="Event:">
        </asp:Label>

        <asp:DropDownList
            ID="EventDropDown"
            runat="server">

            <asp:ListItem
                Text=" -- Select Event -- "
                Value="">
            </asp:ListItem>

            <asp:ListItem
                Text="Technical Fest"
                Value="Technical Fest">
            </asp:ListItem>

            <asp:ListItem
                Text="Coding Competition"
                Value="Coding Competition">
            </asp:ListItem>

            <asp:ListItem
                Text="Web Development Workshop"
                Value="Web Development Workshop">
            </asp:ListItem>

            <asp:ListItem
                Text="Project Exhibition"
                Value="Project Exhibition">
            </asp:ListItem>

        </asp:DropDownList>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator5"
            runat="server"
            ControlToValidate="EventDropDown"
            InitialValue=""
            ErrorMessage="Please select an event."
            Text="Please select an event."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <br /><br />

        <asp:Label
            ID="Label5"
            runat="server"
            Text="Department:">
        </asp:Label>

        <br />

        <asp:RadioButton
            ID="CSE"
            runat="server"
            Text="CSE"
            GroupName="Department" />

        <asp:RadioButton
            ID="IT"
            runat="server"
            Text="IT"
            GroupName="Department" />

        <asp:RadioButton
            ID="CE"
            runat="server"
            Text="CE"
            GroupName="Department" />

        <asp:RadioButton
            ID="ICT"
            runat="server"
            Text="ICT"
            GroupName="Department" />

        <asp:CustomValidator
            ID="DepartmentValidator"
            runat="server"
            ErrorMessage="Please select a department."
            Text="Please select a department."
            ForeColor="Red"
            Display="Dynamic"
            ClientValidationFunction="ValidateDepartmentClient"
            OnServerValidate="ValidateDepartment">
        </asp:CustomValidator>

        <br /><br />

        <asp:Label
            ID="Label6"
            runat="server"
            Text="Skills:">
        </asp:Label>

        <br />

        <asp:CheckBox
            ID="Java"
            runat="server"
            Text="Java" />

        <asp:CheckBox
            ID="Python"
            runat="server"
            Text="Python" />

        <asp:CheckBox
            ID="C"
            runat="server"
            Text="C" />

        <asp:CustomValidator
            ID="SkillsValidator"
            runat="server"
            ErrorMessage="Please select at least one skill."
            Text="Please select at least one skill."
            ForeColor="Red"
            Display="Dynamic"
            ClientValidationFunction="ValidateSkillsClient"
            OnServerValidate="ValidateSkills">
        </asp:CustomValidator>

        <br /><br />

        <asp:Label
            ID="Label9"
            runat="server"
            Text="Address:">
        </asp:Label>

        <br />

        <asp:TextBox
            ID="TextArea1"
            runat="server"
            TextMode="MultiLine"
            Rows="4"
            Columns="40">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator6"
            runat="server"
            ControlToValidate="TextArea1"
            ErrorMessage="Address is required."
            Text="Address is required."
            ForeColor="Red"
            Display="Dynamic">
        </asp:RequiredFieldValidator>

        <br /><br />

        <asp:Label
            ID="Label7"
            runat="server"
            Text="Terms:">
        </asp:Label>

        <br />

        <asp:CheckBox
            ID="CheckBox1"
            runat="server"
            Text="I accept the Terms and Conditions" />

        <asp:CustomValidator
            ID="TermsValidator"
            runat="server"
            ErrorMessage="Please accept the Terms and Conditions."
            Text="Please accept the Terms and Conditions."
            ForeColor="Red"
            Display="Dynamic"
            ClientValidationFunction="ValidateTermsClient"
            OnServerValidate="ValidateTerms">
        </asp:CustomValidator>

        <br /><br />

        <asp:Button
            ID="Button1"
            runat="server"
            Text="Submit"
            CausesValidation="true"
            OnClick="Button1_Click" />

        <br /><br />

        <asp:Label
            ID="ResultLabel"
            runat="server">
        </asp:Label>

    </form>
</body>
</html>
