<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mi primer página</title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_Usuario" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txt_Usuario" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_Password" runat="server" Enabled="True" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="Btn_Aceptar" runat="server" OnClick="Btn_Aceptar_Click" Text="Ingresar" />
    </form>
</body>
</html>