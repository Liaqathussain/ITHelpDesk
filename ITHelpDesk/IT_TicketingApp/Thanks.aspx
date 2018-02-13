<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MainForm.Master" CodeBehind="Thanks.aspx.vb" Inherits="IT_TicketingApp.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style10
        {
            width: 71px;
        }
        .style9
        {
            width: 85px;
        }
        .style11
        {
            width: 83px;
        }
        .style12
        {
            width: 100px;
            height: 21px;
        }
        .style14
        {
            width: 85px;
            height: 21px;
        }
        .style15
        {
            width: 133px;
            height: 21px;
        }
        .style16
        {
            width: 83px;
            height: 21px;
        }
        .style17
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <table style="width:1000px">
            <tr>
                <td class="style4" style="font-family: calibri;">
                    Ticket No:</td>
                <td class="style10" align="left" 
                            style="font-family: calibri;">
                    <asp:Label ID="lblTicketNo" runat="server" Text="Label" 
                                Font-Names="Agency FB" Font-Size="20pt" 
                                    ForeColor="Black" Font-Bold="True"></asp:Label>
                </td>
                <td align="left" Width="250px" 
                            style="font-family: calibri;">
                    Creation Time:</td>
                <td align="left" Width="250px" colspan="3" 
                            style="font-family: calibri;">
                    <asp:Label ID="lblDuration" runat="server" Font-Bold="True" 
                                Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4" style="font-family: calibri">
                    Complaint Date:</td>
                <td class="style10" align="left" style="font-family: calibri">
                    <asp:Label ID="lblComplainDate" runat="server" Text="label" 
                                Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                </td>
                <td align="left" class="style9" style="font-family: calibri">
                    Request Type</td>
                <td align="left" class="style8" style="font-family: calibri">
                    <asp:Label ID="lblRequestType" runat="server" Text="Label" Font-Bold="False" 
                                Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Black"></asp:Label>
                </td>
                <td align="left" class="style11">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" style="font-family: calibri">
                    Priority:</td>
                <td class="style10" align="left" style="font-family: calibri">
                    <asp:Label ID="lblPriority" runat="server" Text="Label" Font-Names="Segoe UI" 
                                Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                </td>
                <td align="left" class="style9" style="font-family: calibri">
                    Status Name:</td>
                <td align="left" class="style8" style="font-family: calibri">
                    <asp:Label ID="lblStatusName" runat="server" Text="Label" Font-Names="Segoe UI" 
                                Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                </td>
                <td align="left" class="style11">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style12" style="font-family: calibri">
                    &nbsp;</td>
                <td  Width="250px" align="left" style="font-family: calibri">
                    &nbsp;</td>
                <td align="left" class="style14" style="font-family: calibri">
                    &nbsp;</td>
                <td align="left" class="style15" style="font-family: calibri">
                    &nbsp;</td>
                <td align="left" class="style16">
                </td>
                <td align="left" class="style17">
                </td>
            </tr>
            </table>
        <asp:Label ID="lblStatus" runat="server" Text="Status" Font-Size="25pt"></asp:Label>
    </div>
</asp:Content>
