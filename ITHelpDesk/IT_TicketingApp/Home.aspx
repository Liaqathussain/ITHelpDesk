<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MainForm.Master" CodeBehind="Home.aspx.vb" Inherits="IT_TicketingApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style15
    {
        width: 119px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:1000px; height:300px; background-image: url('Resources/Black1.jpg'); font-family: calibri;">
       
        <table border="0" style ="width :1000px; height: 375px;">
            <tr>
                <td  
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    &nbsp;</td>
                <td align="center" 
                    
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    Open</td>
                <td style="font-size: 16px; font-family: calibri; font-weight: bold;" 
                    align="center">
                    InProcess</td>
                <td style="font-size: 16px; font-family: calibri; font-weight: bold;" 
                    align="center">
                    Pending</td>
                <td style="font-size: 16px; font-family: calibri; font-weight: bold;" 
                    align="center">
                    Soleved</td>
                <td style="font-size: 16px; font-family: calibri; font-weight: bold;" 
                    align="center">
                    Closed</td>
                <td style="font-size: 16px; font-family: calibri; font-weight: bold;" 
                    align="center">
                    Total</td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    Hardware</td>
                <td align="center">
                    <asp:Label ID="lblHarwareOpen" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                 <td align="center">
                    <asp:Label ID="lblHarInProc" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
               
                <td align="center">
                    <asp:Label ID="lblHarPending" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblHardSolved" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblHardClosed" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblComHardware" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    Software</td>
                <td align="center">
                    <asp:Label ID="lblSoftwareOpen" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                 <td align="center">
                    <asp:Label ID="lblSoftInProc" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
               
                <td align="center">
                    <asp:Label ID="lblSoftPending" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblSoftSolved" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblSoftClosed" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblComSoftware" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    Network</td>
                <td align="center">
                    <asp:Label ID="lblNetworkOpen" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                 <td align="center">
                    <asp:Label ID="lblNetInProcess" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
               
                <td align="center">
                    <asp:Label ID="lblNetPending" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblNetSolved" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblNetClosed" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblNetwork" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 16px; font-family: calibri; font-weight: bold;">
                    Total</td>
                <td align="center">
                    <asp:Label ID="lblOpen" runat="server" Font-Bold="True" Font-Names="Agency FB" 
                        Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                 <td align="center">
                    <asp:Label ID="lblInprocess" runat="server" Font-Bold="True" Font-Names="Agency FB" 
                        Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
               
                <td align="center">
                    <asp:Label ID="lblPending" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblSolved" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblClosed" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="lblTotalRecords" runat="server" Font-Bold="True" 
                        Font-Names="Agency FB" Font-Size="20pt" ForeColor="#FF9900" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 24px; color: #FFFFFF; font-style: italic; font-weight: bold;">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                 <td align="center">
                     &nbsp;</td>
               
                <td align="center">
                    &nbsp;</td>
                <td align="center" style="text-align: center">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left"  
                    
                    style="font-size: 24px; color: #FFFFFF; font-style: italic; font-weight: bold;">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                 <td align="center">
                     &nbsp;</td>
               
                <td align="center">
                    &nbsp;</td>
                <td align="center" style="text-align: center">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
            </tr>
            </table>
       
   </div>
</asp:Content>
