<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            Staff ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            Full Name&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <p>
            Date Of Birth
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            Logged In<asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;</p>
        <p>
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Height="79px" Width="292px"></asp:TextBox>
        </p>
        <p>
            Contact No&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        </p>
    </form>
</body>
</html>
