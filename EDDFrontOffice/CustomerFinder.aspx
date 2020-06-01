<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerFinder.aspx.cs" Inherits="CustomerFinder" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Submit1 {
            z-index: 1;
            left: 30px;
            top: 425px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 118px; 
                  position: absolute; 
                  height: 20px" Text="Customer ID">
        </asp:Label>
        </p>
        <asp:Label ID="lbluserName" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 145px; 
                  position: absolute; 
                  height: 20px" Text="Username">
        </asp:Label>
        <asp:Label ID="lblemailAddress" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 170px; 
                  position: absolute; 
                  height: 20px" Text="Email Address">
        </asp:Label>
        <asp:Label ID="lbldateOfBirth" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 195px; 
                  position: absolute; 
                  height: 20px" Text="Date Of Birth">
        </asp:Label>
        <asp:Label ID="lblhasPlaceOrder" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 220px; 
                  position: absolute; 
                  height: 20px" Text="Order Placed">
        </asp:Label>


        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 120px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtuserName" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 145px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtemailAddress" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 170px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtdateOfBirth" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 195px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txthasPlaceOrder" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 220px; 
             position: absolute">
        </asp:TextBox>
        
        <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 250px; 
             position: absolute; height: 26px;" Text="Cancel" OnClick="BtnCancel_Click" />
        <asp:Button ID="BtnSubmit" runat="server" style="z-index: 1; 
             left: 100px; 
             top: 250px; 
             position: absolute; height: 26px;" Text="Submit" OnClick="BtnSubmit_Click" />
        <asp:Button ID="BtnFind" runat="server" style="z-index: 1; 
             left: 300px; 
             top: 120px; 
             position: absolute; height: 26px;" Text="Find" OnClick="BtnFind_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; 
            left: 20px; 
            top: 300px; 
            position: absolute">
        </asp:Label>
    </form>
</body>
</html>
