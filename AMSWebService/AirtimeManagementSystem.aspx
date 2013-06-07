<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirtimeManagementSystem.aspx.cs" Inherits="AirtimeManagementSystem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 232px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">System Prefix</td>
                <td>
                    <asp:TextBox ID="txtSystemPrefix" runat="server" Width="215px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Company Number</td>
                <td>
                    <asp:TextBox ID="txtCompanyNumber" runat="server" height="22px" width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Number</td>
                <td>
                    <asp:TextBox ID="txtEmployeeNumber" runat="server" height="22px" width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">ID Number</td>
                <td>
                    <asp:TextBox ID="txtIdNumber" runat="server" height="22px" width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Account Number</td>
                <td>
                    <asp:TextBox ID="txtAccountNumber" runat="server" height="22px" width="216px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="87px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
