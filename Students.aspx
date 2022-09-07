<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="aspdatabind.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%--<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 500px;
        }
    </style>
</head>--%>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" cellspacing="5" class="auto-style1">
                <tr>
                    <td colspan="2" style="text-align:center;">Employee Record Managment</td>
                </tr>
                <tr>
                    <td class="auto-style2">Employee Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="433px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Employee Gender</td>
                    <td>
                        <asp:RadioButton ID="radiobutton1" runat="server" Text="Male" GroupName="Gender" Width="116px"></asp:Radiobutton>
                        <asp:Radiobutton ID="radiobutton2" runat="server" Text="Female" GroupName="Gender" Width="116px"></asp:Radiobutton>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">Employee Age</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="433px"></asp:TextBox>
                    </td>
                </tr>
               <%-- <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>--%>
                <%--<tr>
                    <td class="auto-style2">Country</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="442px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" >
                        </asp:DropDownList>
                    </td>
                </tr>--%>
                <tr>
                    <td class="auto-style2">State</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="442px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="442px" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" BackColor="#33CC33" BorderColor="#FF66FF" BorderStyle="Groove" Height="44px" OnClick="Button1_Click" Text="Create" Width="176px" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" BackColor="Aqua" BorderColor="#FF66FF" BorderStyle="Ridge" Height="44px" OnClick="Button2_Click" Text="Update" Width="167px" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" BackColor="Red" BorderStyle="Groove" Height="46px" OnClick="Button3_Click" Text="Delete" Width="167px" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" BackColor="#FFFF99" BorderColor="#FF0066" BorderStyle="Groove" Height="44px" Text="Search" Width="167px" OnClick="Button4_Click" />
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:GridView ID="GridView1" runat="server" Width="1095px" BackColor="#99FF66" BorderColor="#FF66FF" BorderStyle="Solid" BorderWidth="2px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        </asp:GridView>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
