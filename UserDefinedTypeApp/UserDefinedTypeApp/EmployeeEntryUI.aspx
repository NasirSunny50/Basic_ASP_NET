<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeEntryUI.aspx.cs" Inherits="UserDefinedTypeApp.EmployeeEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h1>Employee Information</h1>
                <tr>
                    <td>ID</td>
                    <td><asp:TextBox ID="TextBox_id" runat="server"></asp:TextBox></td>   
                </tr>

                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox></td>   
                </tr>

                <tr>
                    <td>Email</td>
                    <td><asp:TextBox ID="TextBox_email" runat="server"></asp:TextBox></td>   
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="Button_save" runat="server" Text="SAVE" OnClick="Button_save_Click" style="height: 26px" />
                        <asp:Button ID="Button_retrive" runat="server" Text="RETRIVE" OnClick="Button_retrive_Click" />
                        <asp:Button ID="Button_clear" runat="server" Text="CLEAR" OnClick="Button_clear_Click" />
                    </td>
                                          
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
