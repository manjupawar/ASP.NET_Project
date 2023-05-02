<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manjupawar.aspx.cs" Inherits="sample2.manjupawar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td><asp:Label ID="lblname" runat="server" Text="Name :- "></asp:Label></td>
    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
    <td><asp:Label ID="lbladdr" runat="server" Text="Address :- "></asp:Label></td>
    <td><asp:TextBox ID="txtaddr" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
    <td><asp:Label ID="lblmsg" runat="server" Text="lblmsg"></asp:Label></td>
    </tr>

    <tr>
    <td><asp:Button ID="btnsubmit" runat="server" Text="Submit" 
            onclick="btnsubmit_Click"  /></td>
    <td><asp:Button ID="btnshow" runat="server" Text="Show" /></td>
    </tr>

  
    </table>
    </div>
    </form>
</body>
</html>
