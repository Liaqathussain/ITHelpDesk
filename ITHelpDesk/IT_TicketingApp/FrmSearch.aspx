<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MainForm.Master" CodeBehind="FrmSearch.aspx.vb" Inherits="IT_TicketingApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .style9
        {
            height: 21px;
        }
        .style15
        {
            width: 117px;
        }
        .style16
        {
            height: 21px;
            width: 117px;
        }
        .style18
        {
            height: 21px;
            width: 129px;
        }
        .style19
        {
            width: 129px;
        }
        .style21
        {
            height: 21px;
            width: 197px;
        }
        .style22
        {
            width: 197px;
        }
        .style23
        {
            width: 107px;
        }
        .style24
        {
            height: 21px;
            width: 107px;
        }
    </style>

    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 10px; border: medium groove #000080; height: 440px; width: 1000px; font-family: calibri; font-size: medium;" 
    align="center">
    <table class="style4">
        <tr>
            <td class="style22" align="left" style="font-size: 14px; font-family: calibri;">
                <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                    Text="Ticket No:"></asp:Label>
&nbsp;<telerik:RadTextBox ID="txtTicktNoSer" Runat="server" Width="100px">
                </telerik:RadTextBox>
            </td>
            <td align="left" class="style23" 
                style="font-family: calibri; font-size: 14px;" >
                
                    <asp:RadioButton ID="Op_Open" AutoPostBack="true"
                                                GroupName="Group1" Text="Open" Value="Open"  runat="server" 
                                                OnCheckedChanged="Group1_CheckedChanged" 
                        Font-Size="12pt" Font-Names="Calibri" />
            </td>
            <td style="font-family: calibri; font-size: 14px;">
              
                     <asp:RadioButton ID="OP_InProcess" AutoPostBack="true"
                                                GroupName="Group1" Text="InProcess" 
                         Value="InProcess"  runat="server" 
                                                OnCheckedChanged="Group1_CheckedChanged" 
                         Font-Size="12pt" />
            </td>
            <td style="font-family: calibri; font-size: 14px;">
              
                    <asp:RadioButton ID="OP_Pending" AutoPostBack="true"
                                                GroupName="Group1" Text="Pending" Value="Pending"  runat="server" 
                                                OnCheckedChanged="Group1_CheckedChanged" 
                        Font-Size="12pt" />
            </td>
            <td style="font-family: calibri; font-size: 14px;">
                
                <asp:RadioButton ID="OP_Close" AutoPostBack="true"
                                                GroupName="Group1" Text="Close" Value="Close"  runat="server" 
                                                OnCheckedChanged="Group1_CheckedChanged" 
                    Font-Size="12pt" />
            </td>
            <td style="font-family: calibri; font-size: 14px;">
                
                 <asp:RadioButton ID="OP_Solved" AutoPostBack="true" 
                                                GroupName="Group1" Text="Solved" 
                     Value="Solved"  runat="server" 
                                                OnCheckedChanged="Group1_CheckedChanged" 
                     Font-Size="12pt" />
            </td>
            <td style="font-family: calibri; font-size: 14px;" >
                <telerik:RadComboBox ID="RadCityName" Runat="server">
                </telerik:RadComboBox>
            </td>
            <td  align="left">
                <telerik:RadButton ID="RadBtnSearch" runat="server" Skin="Web20" Text="Search" 
                    Width="60px">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td  colspan="8">
            <div style="width:990px; height: 380px; overflow: scroll;"  align="center">
                              <telerik:RadGrid ID="RadGridSearch" runat="server" Width ="100%" 
                                    GridLines="None" AllowSorting="True" Skin="Outlook" 
                                  Font-Names="Calibri" >
                     
                                  <ClientSettings>
                                      <Selecting AllowRowSelect="True" />
                                      <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                                  </ClientSettings>
                <MasterTableView AllowMultiColumnSorting="True" GridLines="None">
                <CommandItemSettings ExportToPdfText="Export to Pdf"></CommandItemSettings>

                    <Columns>
                        <telerik:GridButtonColumn CommandName="Select" Text="Select" 
                            UniqueName="TicketNo" HeaderText="Select">
                        </telerik:GridButtonColumn>
                    </Columns>

                </MasterTableView>

                                  <PagerStyle Mode="NextPrev" />

                <HeaderContextMenu EnableImageSprites="True" CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                                </telerik:RadGrid>
            </div>
              
                </td>
        </tr>
        <tr>
            <td class="style21" align="right" style="font-size: 14px">
                Total Count: </td>
            <td class="style24" align="left" style="font-size: 14px">
                <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style18">
                </td>
            <td class="style16">
                </td>
        </tr>
        <tr>
            <td  align="right" class="style22">
                &nbsp;</td>
            <td class="style23" >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td class="style19" >
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="8">
                &nbsp;</td>
        </tr>
    </table>
    </div>
</asp:Content>
