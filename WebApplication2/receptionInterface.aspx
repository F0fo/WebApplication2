<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="receptionInterface.aspx.cs" Inherits="WebApplication2.receptionInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged"></asp:DropDownList>
        
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"> </asp:Button>
            />seatCount
        <asp:TextBox ID="B1" runat="server"></asp:TextBox>ID

    <asp:TextBox ID="B2" runat="server"></asp:TextBox></form>
      <div>
  </div>

</body>
</html>
