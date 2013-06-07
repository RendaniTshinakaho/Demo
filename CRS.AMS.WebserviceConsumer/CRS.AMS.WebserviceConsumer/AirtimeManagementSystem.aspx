<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AirtimeManagementSystem.aspx.cs" Inherits="CRS.AMS.WebserviceConsumer.AirtimeManagementSystem" %>

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
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">System Prefix</td>
                <td>
                    <asp:TextBox ID="txtSystemPrefix" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Company Number</td>
                <td>
                    <asp:TextBox ID="txtCompanyNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Number</td>
                <td>
                    <asp:TextBox ID="txtEmployeeNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">ID Number</td>
                <td>
                    <asp:TextBox ID="txtIDNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Account Number</td>
                <td>
                    <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    <div>
    
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="103px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
