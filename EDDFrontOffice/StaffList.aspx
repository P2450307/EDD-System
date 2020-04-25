<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ListBox ID="lstStaffList" runat="server" DataValueField="Address" Height="320px" Width="359px">
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="49px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="64px" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
