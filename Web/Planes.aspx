<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/BasePaginaMaestra.Master" CodeBehind="Planes.aspx.cs" Inherits="Web.Planes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentBase" runat="server">
		<asp:GridView ID="grdPlanes" runat="server" CssClass="table" DataSourceID="odsPlanes" OnRowCommand="grdPlanes_RowCommand" ShowFooter="True" OnSelectedIndexChanged="grdPlanes_SelectedIndexChanged" AutoGenerateColumns="False">
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="PlanEspecialidad" HeaderText="Especialidad" SortExpression="PlanEspecialidad" />
				<asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
			</Columns>
		</asp:GridView>
		<asp:ObjectDataSource ID="odsPlanes" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic">
		</asp:ObjectDataSource>
</asp:Content>