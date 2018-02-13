<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MainForm.Master" CodeBehind="Forwarding.aspx.vb" Inherits="IT_TicketingApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    
   
    <style type="text/css">
        .style3
        {
            width: 762px;
        }
        .style4
        {
            width: 100px;
        }
         .style8
        {
        }
        .style9
        {
            width: 85px;
        }
        .style10
        {
            width: 71px;
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
        .style13
        {
            width: 71px;
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
        .style21
        {
            height: 23px;
        }
        .style22
        {
            width: 143px;
            height: 21px;
        }
        .style23
        {
            width: 85px;
            height: 21px;
        }
    </style>
    
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <table class="style3" width ="300px">
        <tr>
            <td align="Center" class="style29" colspan="4" style="font-size: 12px">
            
                
            </td>
        </tr>
        <tr>
            <td align="center"  style="font-size: 14px; font-family: calibri;" colspan="4">
                <div align="center">
                <table width ="1000px"> 
                    <tr>
                        <td class="style4">Ticket No:</td>
                        <td class="style10" align="left">
                                <asp:Label ID="lblTicketNo" runat="server" Text="Label" 
                                Font-Names="Agency FB" Font-Size="20pt" 
                                    ForeColor="Black" Font-Bold="True"></asp:Label>
                        </td>
                        <td align="left" width="200px">Duration:</td>
                        <td align="left"  colspan="3">
                            <asp:Label ID="lblDuration" runat="server" Font-Bold="True" 
                                Font-Names="Agency FB" Font-Size="20pt" ForeColor="Black" Text="00:00:00"></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="style22" style="font-family: calibri">Complaint Date:</td>
                        <td class="style13" align="left" style="font-family: calibri">
                            <asp:Label ID="lblComplainDate" runat="server" Text="label" 
                                Font-Names="Calibri" Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                        </td>
                        <td align="left" class="style23" style="font-family: calibri">User:</td>
                        <td align="left" class="style17" style="font-family: calibri">
                            <asp:Label ID="lblusername" runat="server" Text="Label" Font-Bold="False" 
                                Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Black"></asp:Label>
                        </td>
                        <td align="left" class="style16" style="font-family: calibri"></td> 
                        <td align="left" class="style17">
                            </td>
                        
                    </tr>
                    <tr>
                        <td class="style4" style="font-family: calibri">Response Date</td>
                        <td class="style10" align="left" style="font-family: calibri">
                            <asp:Label ID="lblResponceDate" runat="server" Font-Bold="False" 
                                Font-Names="Calibri" Font-Size="10pt" ForeColor="Black" Text="00:00"></asp:Label>
                        </td>
                        <td align="left" class="style9" style="font-family: calibri">Status:</td>
                        <td align="left" class="style8" style="font-family: calibri">
                            <asp:Label ID="lblStatusName" runat="server" Text="Label" Font-Names="Segoe UI" 
                                Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                        </td>
                        <td align="left" class="style11" style="font-family: calibri">&nbsp;</td> 
                        <td align="left">
                            &nbsp;</td>
                        
                    </tr>
                    <tr>
                        <td class="style12" style="font-family: calibri">Priority:</td>
                        <td class="style13" align="left" style="font-family: calibri">
                            <asp:Label ID="lblPriority" runat="server" Text="Label" Font-Names="Calibri" 
                                Font-Size="10pt" ForeColor="Black" Font-Bold="False"></asp:Label>
                        </td>
                        <td align="left" style="font-family: calibri">Support Engineer Remarks:</td>
                        <td align="left" class="style15" style="font-family: calibri">
                                <asp:Label ID="lblOwnerName" runat="server" Font-Bold="False" 
                                    Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Black" Text="Label" 
                                    Width="250px"  BorderColor="Black"></asp:Label>
                                                                
                        </td>
                        <td align="left" class="style16" style="font-family: calibri"></td> 
                        <td align="left" class="style17">
                            </td>
                        
                    </tr>
                    <tr>
                        <td  style="font-family: calibri" >User Remarks:</td>
                        <td  align="left" style="font-family: calibri">
                                <asp:Label ID="lblUserRemarks" runat="server" Font-Bold="False" 
                                    Font-Names="Calibri" Font-Size="10pt" ForeColor="Black" Text="Label" 
                                    Width="250px" ></asp:Label>
                                                                
                        </td>
                        <td align="left"  style="font-family: calibri" >&nbsp;</td>
                        <td align="left"  colspan="2" style="font-family: calibri" class="style21">
                                &nbsp;</td>
                        <td align="left" class="style21" >
                            </td>
                        
                    </tr>
                </table>

                </div>
               </td>
        </tr>
        <tr>
            <td align="right" class="style31" style="font-size: 14px" colspan="4">
               <div style="  width: 1000px" align="center">
                <table  width ="100%" >
                        <tr>
                            <td align="right" style="font-family: calibri;"  >
                                <asp:Label ID="lblStatusDrop" runat="server" Text="Status:"></asp:Label>
                            </td>
                            <td align="left" style="font-family: calibri">

                                <telerik:RadComboBox ID="RadComFStatus" Runat="server" AutoPostBack = "True" OnSelectedIndexChanged ="RadComFStatus_SelectedIndexChanged" 
                                    Skin="Web20" SkinID="web20">
                                </telerik:RadComboBox>

                                <asp:RequiredFieldValidator runat="server" 
                             ID="RequiredFieldValidator2" ValidationGroup="ValidationProduct"
                             ControlToValidate="RadComFStatus" ErrorMessage="*"
                             InitialValue="Please-Select" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                            </td>
                            <td align="left" style="font-family: calibri;" >
                                <asp:Label ID="lblAssignto" runat="server" Text="Assign to:" 
                                    Font-Names="Calibri"></asp:Label>
                            </td>
                            <td align="left" style="font-family: calibri" >
                                <telerik:RadComboBox ID="RadComboAssignTo" Runat="server" 
                                    AutoPostBack = "True" OnSelectedIndexChanged = "RadComboAssignTo_SelectedIndexChanged"
                                    style="margin-left: 0px" Skin="Web20">
                                </telerik:RadComboBox>
                            </td>
                            <td align="left" >
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" style="font-family: calibri;"   >
                                <asp:Label ID="lblOwner" runat="server" Text="Support Engineer Remarks:" 
                                    Font-Names="Calibri"></asp:Label>
                            </td>
                            <td align="left" class="style45" style="font-family: calibri"  >
                                <telerik:RadTextBox ID="RadTextOwner" Runat="server" EnableTheming="True" 
                    Skin="Web20" TextMode="MultiLine" Width="250px" SkinID="web20">
                                </telerik:RadTextBox>
                                                                
                            </td>
                            </td>
                            <td align="left" style="font-family: calibri;" >
                                <asp:Label ID="lblScheduleTime" runat="server" Text="Schedule Time:"></asp:Label>
                            </td>
                            <td align="left" style="font-family: calibri" >
                                <telerik:RadComboBox ID="RadScheduleTime" Runat="server">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator runat="server" 
                             ID="RequiredFieldValidator1" ValidationGroup="ValidationProduct"
                             ControlToValidate="RadScheduleTime" ErrorMessage="*"
                             InitialValue="Please-Select" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Text="min"></asp:Label>
                            </td>
                            <td align="left" class="style35">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" style="font-family: calibri;" >
                                <asp:Label ID="lblUser" runat="server" Text="User Feed Back:" 
                                    Font-Names="Calibri"></asp:Label>
                            </td>
                            <td align="left" class="style45" style="font-family: calibri" >
                                <telerik:RadTextBox ID="RadTextUser" Runat="server" TextMode="MultiLine" 
                    Width="250px" Skin="Web20">
                                </telerik:RadTextBox>
                            </td>
                            <td align="left" style="font-family: calibri;" >
                                &nbsp;</td>
                            <td align="left" class="style39" style="font-family: calibri">
                                <asp:Label ID="lblStatus" runat="server" Font-Names="Calibri"></asp:Label>
                            </td>
                            <td align="left" class="style35">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" class="style44" style="font-family: calibri" >
                                &nbsp;</td>
                            <td align="left" class="style45" style="font-family: calibri" >
                                <telerik:RadButton ID="RadBtnFUpdate" runat="server" Text="Update" Width="60px" 
                    Skin="Web20" OnClick="RadBtnFUpdate_Click" ValidationGroup="ValidationProduct" 
                                    Font-Names="Calibri">
                                </telerik:RadButton>
                            </td>
                            <td align="right" class="style40" style="font-family: calibri">
                                &nbsp;</td>
                            <td align="left" class="style39" style="font-family: calibri">
                                &nbsp;</td>
                            <td align="left" class="style35">
                                &nbsp;</td>
                        </tr>
                        </table>
               </div>
            </td>
        </tr>
        <tr>
            <td style="font-family: calibri">
                 <a>History </a>
            </td>
        </tr>
        <tr>
            
            <td>
                <div width ="100%">
               
              <telerik:RadGrid ID="RadGridHistory" runat="server" Width ="100%" 
                    GridLines="None" AllowPaging="True" AllowSorting="True" Skin="Web20" 
                    Font-Names="Calibri" >
                     
                  <ClientSettings>
                      <Selecting AllowRowSelect="True" />
                  </ClientSettings>
<MasterTableView>
<CommandItemSettings ExportToPdfText="Export to Pdf"></CommandItemSettings>

</MasterTableView>

<HeaderContextMenu EnableImageSprites="True" CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
            
            </div>
            </td>
        </tr>
    </table>
</asp:Content>
