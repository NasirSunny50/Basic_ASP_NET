<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="HelloWorldWebApp.CalculatorUI" %>

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
                        First Number:
                    </td>
                        
                    <td>
                        <asp:TextBox ID="textBox_firstNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Second Number:
                    </td>
                        
                    <td>
                        <asp:TextBox ID="textBox_secondNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Result:
                    </td>
                        
                    <td>
                        <asp:Label ID="label_result" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        
                    </td>
                 
                    <td>
                        <asp:Button ID="button_add" runat="server" Text="ADD" OnClick="button_add_Click" />
                 
                        <asp:Button ID="button_sub" runat="server" Text="SUB" OnClick="button_sub_Click1" />
                 
                        <asp:Button ID="button_mul" runat="server" Text="MUL" OnClick="button_mul_Click1" />
                 
                        <asp:Button ID="button_div" runat="server" Text="DIV" OnClick="button_div_Click1" />
                     </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
