<%@ Page Language="C#" MasterPageFile="~/LoginPaginaMaestra.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LoginContent" Runat="server">
    	<table style="width:100%;">
			<tr>
				<td>&nbsp;</td>
				<td class="auto-style1">&nbsp;</td>
				<td>
        	<asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td class="auto-style1">
			<asp:Label for="lblUsuario" runat="server" Text="Usuario"></asp:Label>
				</td>
				<td>
			<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
				</td>
			</tr>

			<tr>
				<td>&nbsp;</td>
				<td class="auto-style1">
			<asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
				</td>
				<td>
			<asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td class="auto-style1">&nbsp;</td>
				<td>
			<asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
				</td>
			</tr>
		</table>
</asp:Content>
<%--<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 125px;
        }
    </style>
</asp:Content>--%>

