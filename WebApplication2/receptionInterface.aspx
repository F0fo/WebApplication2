<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="receptionInterface.aspx.cs" Inherits="WebApplication2.receptionInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="Button4" Text="Button" OnClick="Button4_Click"></asp:Button>
        <asp:TextBox ID ="T1" runat="server"></asp:TextBox>
        <asp:Label ID ="Label1" runat="server" Text="Label"></asp:Label>
               
        
        <div>
        </div>
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Unnamed3_Click"></asp:Button>
        
        <asp:TextBox ID ="T2" runat="server"></asp:TextBox>

        
        
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Add table" OnClick="Button1_Click"> </asp:Button>seatCount
        <asp:TextBox ID="B1" runat="server" ></asp:TextBox>
        ID <asp:TextBox ID="B2" runat="server"></asp:TextBox>

  <div>
  </div>
        <asp:Button ID="Button2" runat="server" Text="Remove table" OnClick="Unnamed1_Click"></asp:Button>

    <div>
</div>
        <asp:Button ID="Button3" runat="server" Text="Modify table" OnClick="Unnamed2_Click"></asp:Button>
         SeatCount <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CheckBox ID="Available" runat="server"></asp:CheckBox>

    </form>


</body>
</html>
