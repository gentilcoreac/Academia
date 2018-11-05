<%@ Page Language="C#" MasterPageFile="~/LoginPaginaMaestra.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LoginContent" Runat="server">

               <h2>Login</h2>
            <h5>Bienvenido al sistema de gestión académico</h5>

    	<table style="width:100%;">
 
 
			<tr>
				<td>&nbsp;</td>
				<td class="form-signin" style="width: 66px">
			        <asp:Label for="lblUsuario"  text-align="right" runat="server" Text="Usuario"></asp:Label>
				</td>
				<td>
			        <asp:TextBox ID="txtUsuario"  CssClass="form-control" runat="server" TabIndex="1"></asp:TextBox>
				</td>
			</tr>

			<tr>
				<td>&nbsp;</td>
				<td class="form-signin" style="width: 66px">
			<asp:Label ID="lblClave"    runat="server" Text="Clave"></asp:Label>
				</td>
				<td>
			<asp:TextBox ID="txtClave"  CssClass="form-control" runat="server" TextMode="Password" TabIndex="2"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td class="form-signin" style="width: 66px">&nbsp;</td>
				<td>
			<asp:Button ID="btnIngresar" CssClass="btn btn-primary" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" TabIndex="3" />
				</td>
			</tr>
		</table>
</asp:Content>



