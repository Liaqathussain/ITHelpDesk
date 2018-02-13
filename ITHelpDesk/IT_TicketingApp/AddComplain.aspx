<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MainForm.Master" CodeBehind="AddComplain.aspx.vb" Inherits="IT_TicketingApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style11
        {
            width: 200px;
        }
        .style12
        {
            height: 26px;
            width: 200px;
        }
        .style14
        {
            width: 200px;
            height: 23px;
        }
        .style15
        {
        }
        .style16
        {
            height: 26px;
            width: 202px;
        }
        .style17
        {
            width: 202px;
            height: 23px;
        }
        .style19
        {
            width: 202px;
            height: 30px;
        }
        .style20
        {
            width: 200px;
            height: 30px;
        }
        .style21
        {
            width: 311px;
        }
        .style22
        {
            width: 311px;
            height: 30px;
        }
        .style23
        {
            height: 26px;
            width: 311px;
        }
        .style24
        {
            width: 311px;
            height: 23px;
        }
        .style26
        {
            height: 26px;
        }
        .style29
        {
            height: 26px;
            width: 134px;
        }
        .style30
        {
            width: 134px;
            height: 30px;
        }
        .style31
        {
            width: 134px;
            height: 23px;
        }
        .style32
        {
            width: 134px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table  style="width :1000px; height :300px;  font-family: calibri;">
 
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style21">
                            &nbsp;</td>
    <td align="left" class="style32" style="font-family: calibri; font-size: 16px;">
    
                            &nbsp;</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style15" >

                            &nbsp;</td>
    <td align="left" class="style11" style="font-family: calibri">

        &nbsp;</td>
                            

    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style26">
                            </td>
    <td align="left" class="style29" 
            
            
            style="font-family: calibri; font-size: 16px;">
    
                            Issues</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style26" >
                        <telerik:RadComboBox ID="RadIssues" runat="server" Skin="Web20" Width="300px" AutoPostBack = "true" OnSelectedIndexChanged = "RadComApp_SelectedIndexChanged">
                        </telerik:RadComboBox>

                            <asp:RequiredFieldValidator runat="server" 
                             ID="RequiredFieldValidator10" ValidationGroup="ValidationProduct"
                             ControlToValidate="RadIssues" ErrorMessage="*"
                             InitialValue="Please-Select" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        </td>
    <td align="left" class="style12" style="font-family: calibri">

                            </td>
                           

    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style21">
                            &nbsp;</td>
    <td align="left" class="style32" 
            
            
            style="font-family: calibri; font-size: 16px;">
    
                            Request Type</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style15" >
                           

                            <telerik:RadComboBox ID="RadComReqType" runat="server" AutoPostBack = "true"  
                                OnSelectedIndexChanged ="RadComReqType_SelectedIndexChanged" Skin="Web20" 
                                Width="300px">
                            </telerik:RadComboBox>

                            <asp:RequiredFieldValidator runat="server" 
                             ID="RequiredFieldValidator2" ValidationGroup="ValidationProduct"
                             ControlToValidate="RadComReqType" ErrorMessage="*"
                             InitialValue="Please-Select" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        </td>
    <td align="left" class="style11" style="font-family: calibri">

                            &nbsp;</td>
                           

    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style22">
                            </td>
    <td align="left" class="style30" 
            
            
            style="font-family: calibri; font-size: 16px;">
    
                            Priority</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style19" >
                            

                            <telerik:RadComboBox ID="RadComPriority" runat="server" Skin="Web20" 
                                Width="300px">
                            </telerik:RadComboBox>

                            <asp:RequiredFieldValidator runat="server" 
                             ID="RequiredFieldValidator1" ValidationGroup="ValidationProduct"
                             ControlToValidate="RadComPriority" ErrorMessage="*"
                             InitialValue="Please-Select" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        </td>
    <td align="left" class="style20" style="font-family: calibri">
                            </td>
    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style23">
                            &nbsp;</td>
    <td class="style29" align="left" 
            
            
            style="font-family: calibri; font-size: 16px;">
    
                            Attachment</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" 
            class="style16">
                            <telerik:RadAsyncUpload ID="RadAsyncUpload1" runat="server" 
                                MaxFileInputsCount="2" Width="300px" MaxFileSize="1048576" Skin="Web20">
                            </telerik:RadAsyncUpload>
        </td>
    <td class="style12" align="left" style="font-family: calibri">
                            &nbsp;</td>
    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style24">
                            </td>
    <td align="left" class="style31" 
            
            
            style="font-family: calibri; font-size: 16px;">
                            User Remarks</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" 
            class="style17">
                            <telerik:RadTextBox ID="tbUserRemarks" Runat="server" Height="40px" 
                                TextMode="MultiLine" Width="300px" Skin="Web20">
                            </telerik:RadTextBox>
        </td>
    <td class="style14" style="font-family: calibri">
                            </td>
    </tr>
    <tr>
    <td align="left" style="font-family: calibri;" 
            class="style21">
                            &nbsp;</td>
    <td align="right" class="style32" style="font-family: calibri; font-size: 16px;">
                                                        &nbsp;</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style15">
                                                        <telerik:RadButton ID="btnSubmit" runat="server" Skin="Web20" Text="Submit" 
                                                            Width="70px" OnClick="btnSubmit_Click" ValidationGroup="ValidationProduct">
                                                            
                                                        </telerik:RadButton>
                                                        
                                                        <telerik:RadButton ID="btnClear" runat="server" Skin="Web20" Text="Clear" 
                                                            Width="70px">
                                                        </telerik:RadButton>
                                                        
        </td>
    <td align="left" class="style11" style="font-family: calibri">
                                                        &nbsp;</td>
    </tr>
    <tr>
    <td align="right" style="font-family: calibri;" 
            class="style21">
                            &nbsp;</td>
    <td class="style32" style="font-family: calibri; font-size: 16px;">
                            &nbsp;</td>
    <td align="left" style="font-family: calibri; font-size: 16px;" class="style15" 
            colspan="2">
        <asp:Label ID="lblStatus" runat="server" Text="Status:" Font-Size="10pt" 
            Font-Names="Segoe UI" ForeColor="#FF9900" SkinID="web20" Visible="False"></asp:Label>
                                                        
        </td>
    </tr>
    <tr>
    <td align="right" style="font-family: calibri;" 
            class="style21">
                            &nbsp;</td>
    <td class="style32" style="font-family: calibri; font-size: 16px;">
                            &nbsp;</td>
    <td align="left" style="font-family: calibri;" class="style15" 
            colspan="2">
        &nbsp;</td>
    </tr>
   
   
    
   
   
   
    
    </table>
 


</asp:Content>
