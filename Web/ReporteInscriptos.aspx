<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/BasePaginaMaestra.Master" CodeFile="ReporteInscriptos.aspx.cs" Inherits="Web.ReporteInscriptos" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContentBase">
	
	<rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
		<LocalReport ReportPath="../UI.Desktop/ReporteCursos.rdlc">
			<DataSources>
				<rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DS_Cursos" />
			</DataSources>
		</LocalReport>
	</rsweb:ReportViewer>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Web.AcademiaDataSetTableAdapters.SP_CursosTableAdapter" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
	
</asp:Content>