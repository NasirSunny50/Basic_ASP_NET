<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="HelloWorldWebApp.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Name:
                    </td>
                        
                    <td>
                        <asp:TextBox ID="textBox_name" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Email:
                    </td>
                        
                    <td>
                        <asp:TextBox ID="textBox_email" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Roll:
                    </td>
                        
                    <td>
                        <asp:TextBox ID="textBox_roll" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        
                    </td>
                 
                    <td>
                        <asp:Button ID="button_save" runat="server" Text="Save" OnClick="button_save_Click" />
                 
                        <asp:Button ID="button_retrieve" runat="server" Text="Retreive" OnClick="button_retrieve_Click" />
                     </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
