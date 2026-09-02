<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leaveapplication.aspx.cs" Inherits="practical5.leaveapplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Employee Name:
            <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
            <br />
            <br />
            Date:
            <asp:Label ID="lblDate" runat="server"></asp:Label>
            <br />
            <br />
            Leave Type:
            <asp:DropDownList ID="ddlLeaveType" runat="server">
                <asp:ListItem>Select Leave Type</asp:ListItem>
                <asp:ListItem>Casual Leave</asp:ListItem>
                <asp:ListItem>Sick Leave</asp:ListItem>
                <asp:ListItem>Emergency Leave</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Leave Reason:
            <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkRemember" runat="server" Text="Remember my name" />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <br />
            <asp:Label ID="lblData" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
