Imports Telerik.Web.UI
Imports System


Public Class WebForm3
    Inherits System.Web.UI.Page
    Public objBL As New ItTicketing_Methods
    Dim objMain As New MainServiceMethod
    Dim FlagOption As String
    Dim DT As DataTable
    Dim DTAsPerCriteria As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim DTGetSearchResult As DataTable
            If Not IsPostBack = True Then
                Dim dtApp = objBL.GetApplicationDetails()
                Dim dtPriority = objBL.GetPriority
                Dim array As Integer() = New Integer(3) {}

                DT = objMain.GetUserDetailsbyUserID(Session("UserID"))
                If DT.Rows.Count > 0 Then
                    Session("UserType") = DT.Rows(0)("ModuleName")
                End If

                'RadCityName.Items.Add(New RadComboBoxItem("Please-Select", dtApp.Rows.Count))
                'For i As Integer = 0 To dtApp.Rows.Count - 1
                '    RadCityName.Items.Add(New RadComboBoxItem(dtApp.Rows(i)("CityName").ToString, i))

                'Next


                'Dim dr1 As DataRow = dtApp.NewRow
                'dr1(0) = 0
                'dr1(1) = "Please-Select"
                'dtApp.Rows.InsertAt(dr1, 0)
                'For J As Integer = 0 To dtApp.Rows.Count - 1
                '    RadCityName.Items.Add(New RadComboBoxItem(dtApp.Rows(J)("CityName").ToString, J))
                'Next


                If DT.Rows(0)("ModuleName") = "Admin" Then
                    DTGetSearchResult = objBL.GetSearchResultAdmin()
                    RadCityName.Visible = True
                ElseIf DT.Rows(0)("ModuleName") = "Owner" Then 'support Engineer
                    DTGetSearchResult = objBL.GetSearchResult()
                    RadCityName.Visible = True
                ElseIf DT.Rows(0)("ModuleName") = "User" Then
                    DTGetSearchResult = objBL.GetSearchResultbyUser(Session("UserID"))
                    RadCityName.Visible = False
                End If
                If DTGetSearchResult.Rows.Count > 0 Then
                    lblStatus.Text = DTGetSearchResult.Rows.Count
                    Dim dt1 As New DataTable()
                    dt1.Columns.AddRange(New DataColumn(19) {New DataColumn("Ticket No"), New DataColumn("Complain Date"), New DataColumn("Department Name"), New DataColumn("Status Name"), New DataColumn("User Name"), _
                                                           New DataColumn("UserID"), New DataColumn("Priority"), New DataColumn("ModuleName"), New DataColumn("UserRemarks"), New DataColumn("OwnerRemarks"), _
                                                             New DataColumn("Notes"), New DataColumn("ModuleID"), New DataColumn("Attachment1"), New DataColumn("Attachment2"), New DataColumn("OwnerAttach1"), New DataColumn("OwnerAttach2"), New DataColumn("TransactionDateTime"), New DataColumn("DelayInMinutes"), New DataColumn("ResponseTime"), New DataColumn("CityName")})
                    For i As Integer = 0 To DTGetSearchResult.Rows.Count - 1
                        dt1.Rows.Add(DTGetSearchResult.Rows(i)("TicketNo").ToString, Format(DTGetSearchResult.Rows(i)("ComplainDate"), "dd-MMM-yyyy hh:mm:ss"), DTGetSearchResult.Rows(i)("DepartmentName").ToString, DTGetSearchResult.Rows(i)("StatusName").ToString, DTGetSearchResult.Rows(i)("UserName").ToString, _
                                    DTGetSearchResult.Rows(i)("UserID").ToString, DTGetSearchResult.Rows(i)("Priority").ToString, DTGetSearchResult.Rows(i)("ModuleName").ToString, DTGetSearchResult.Rows(i)("UserRemarks").ToString, DTGetSearchResult.Rows(i)("OwnerRemarks").ToString, _
                                    DTGetSearchResult.Rows(i)("Notes").ToString, DTGetSearchResult.Rows(i)("ModuleID").ToString, DTGetSearchResult.Rows(i)("Attachment1").ToString, DTGetSearchResult.Rows(i)("Attachment2").ToString, DTGetSearchResult.Rows(i)("OwnerAttach1").ToString, DTGetSearchResult.Rows(i)("OwnerAttach2").ToString, DTGetSearchResult.Rows(i)("TransactionDateTime").ToString, DTGetSearchResult.Rows(i)("DelayInMinutes").ToString, DTGetSearchResult.Rows(i)("ResponseTime").ToString, Session("CityName"))
                    Next
                    RadGridSearch.DataSource = dt1
                    RadGridSearch.DataBind()

                    RadGridSearch.MasterTableView.GetColumn("UserID").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("Priority").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("ModuleName").Visible = False
                    'RadGridSearch.MasterTableView.GetColumn("DepartmentName").Visible = False

                    RadGridSearch.MasterTableView.GetColumn("UserRemarks").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("OwnerRemarks").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("Notes").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("ModuleID").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("Attachment1").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("Attachment2").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("OwnerAttach1").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("OwnerAttach2").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("TransactionDateTime").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("DelayInMinutes").Visible = False
                    RadGridSearch.MasterTableView.GetColumn("ResponseTime").Visible = False
                Else
                    'MsgBox("Unable to get Status", MsgBoxStyle.Critical)
                End If

                Session("Status") = "Open"

            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub RadComAppName_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadCityName.SelectedIndexChanged
        Try
            Session("AppID") = RadCityName.SelectedIndex

        Catch ex As Exception

        End Try
    End Sub


    Protected Sub RadBtnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadBtnSearch.Click
        Try
            If Page.IsPostBack = True Then

                If Session("UserType") = "Owner" Or Session("UserType") = "Admin" Then

                    DTAsPerCriteria = objBL.GetSearchAsPerCriteriaSupportEng(Session("Status"), txtTicktNoSer.Text.Trim, RadCityName.SelectedValue)



                    If DTAsPerCriteria.Rows.Count > 0 Then
                        'ViewState("SignUpID") = SignUpID

                        Dim dt1 As New DataTable()
                        dt1.Columns.AddRange(New DataColumn(22) {New DataColumn("Ticket No"), New DataColumn("App Name"), New DataColumn("Complain Date"), New DataColumn("Department Name"), New DataColumn("Status Name"), New DataColumn("User Name"), _
                                                               New DataColumn("UserID"), New DataColumn("AppID"), New DataColumn("Priority"), New DataColumn("ModuleName"), New DataColumn("UserRemarks"), New DataColumn("OwnerRemarks"), _
                                                                 New DataColumn("Notes"), New DataColumn("ModuleID"), New DataColumn("Attachment1"), New DataColumn("Attachment2"), New DataColumn("OwnerAttach1"), New DataColumn("OwnerAttach2"), New DataColumn("TransactionDateTime"), New DataColumn("Assigned Engineer"), New DataColumn("DelayInMinutes"), New DataColumn("ResponseTime"), New DataColumn("CityName")})
                        For i As Integer = 0 To DTAsPerCriteria.Rows.Count - 1
                            dt1.Rows.Add(DTAsPerCriteria.Rows(i)("TicketNo").ToString, DTAsPerCriteria.Rows(i)("AppName").ToString, Format(DTAsPerCriteria.Rows(i)("ComplainDate"), "dd-MMM-yyyy hh:mm:ss"), DTAsPerCriteria.Rows(i)("DepartmentName").ToString, DTAsPerCriteria.Rows(i)("StatusName").ToString, DTAsPerCriteria.Rows(i)("UserName").ToString, _
                                        DTAsPerCriteria.Rows(i)("UserID").ToString, DTAsPerCriteria.Rows(i)("AppID").ToString, DTAsPerCriteria.Rows(i)("Priority").ToString, DTAsPerCriteria.Rows(i)("ModuleName").ToString, DTAsPerCriteria.Rows(i)("UserRemarks").ToString, DTAsPerCriteria.Rows(i)("OwnerRemarks").ToString, _
                                        DTAsPerCriteria.Rows(i)("Notes").ToString, DTAsPerCriteria.Rows(i)("ModuleID").ToString, DTAsPerCriteria.Rows(i)("Attachment1").ToString, DTAsPerCriteria.Rows(i)("Attachment2").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach1").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach2").ToString, DTAsPerCriteria.Rows(i)("TransactionDateTime").ToString, DTAsPerCriteria.Rows(i)("FarwardToEngineer").ToString, DTAsPerCriteria.Rows(i)("DelayInMinutes").ToString, DTAsPerCriteria.Rows(i)("ResponseTime").ToString, DTAsPerCriteria.Rows(i)("CityName").ToString)
                        Next
                        RadGridSearch.DataSource = dt1
                        RadGridSearch.DataBind()


                        RadGridSearch.MasterTableView.GetColumn("UserID").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("AppID").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Priority").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ModuleName").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("UserRemarks").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerRemarks").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Notes").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ModuleID").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Attachment1").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Attachment2").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerAttach1").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerAttach2").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("TransactionDateTime").Visible = False
                        'RadGridSearch.MasterTableView.GetColumn("FarwardToEngineer").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("DelayInMinutes").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ResponseTime").Visible = False

                        lblStatus.Text = DTAsPerCriteria.Rows.Count
                    Else
                        Call EmptyTable()
                    End If
                    lblStatus.Text = DTAsPerCriteria.Rows.Count
                ElseIf Session("UserType") = "User" Then

                    DTAsPerCriteria = objBL.GetSearchAsPerCriteria(Session("UserID"), Session("Status"), txtTicktNoSer.Text.Trim)


                    If DTAsPerCriteria.Rows.Count > 0 Then
                        'ViewState("SignUpID") = SignUpID

                        Dim dt1 As New DataTable()
                        dt1.Columns.AddRange(New DataColumn(22) {New DataColumn("Ticket No"), New DataColumn("App Name"), New DataColumn("Complain Date"), New DataColumn("Department Name"), New DataColumn("Status Name"), New DataColumn("User Name"), _
                                                               New DataColumn("UserID"), New DataColumn("AppID"), New DataColumn("Priority"), New DataColumn("ModuleName"), New DataColumn("UserRemarks"), New DataColumn("OwnerRemarks"), _
                                                                 New DataColumn("Notes"), New DataColumn("ModuleID"), New DataColumn("Attachment1"), New DataColumn("Attachment2"), New DataColumn("OwnerAttach1"), New DataColumn("OwnerAttach2"), New DataColumn("TransactionDateTime"), New DataColumn("FarwardToEngineer"), New DataColumn("DelayInMinutes"), New DataColumn("ResponseTime"), New DataColumn("CityName")})
                        For i As Integer = 0 To DTAsPerCriteria.Rows.Count - 1
                            dt1.Rows.Add(DTAsPerCriteria.Rows(i)("TicketNo").ToString, DTAsPerCriteria.Rows(i)("AppName").ToString, Format(DTAsPerCriteria.Rows(i)("ComplainDate"), "dd-MMM-yyyy hh:mm:ss"), DTAsPerCriteria.Rows(i)("DepartmentName").ToString, DTAsPerCriteria.Rows(i)("StatusName").ToString, DTAsPerCriteria.Rows(i)("UserName").ToString, _
                                        DTAsPerCriteria.Rows(i)("UserID").ToString, DTAsPerCriteria.Rows(i)("AppID").ToString, DTAsPerCriteria.Rows(i)("Priority").ToString, DTAsPerCriteria.Rows(i)("ModuleName").ToString, DTAsPerCriteria.Rows(i)("UserRemarks").ToString, DTAsPerCriteria.Rows(i)("OwnerRemarks").ToString, _
                                        DTAsPerCriteria.Rows(i)("Notes").ToString, DTAsPerCriteria.Rows(i)("ModuleID").ToString, DTAsPerCriteria.Rows(i)("Attachment1").ToString, DTAsPerCriteria.Rows(i)("Attachment2").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach1").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach2").ToString, DTAsPerCriteria.Rows(i)("TransactionDateTime").ToString, DTAsPerCriteria.Rows(i)("FarwardToEngineer").ToString, DTAsPerCriteria.Rows(i)("DelayInMinutes").ToString, DTAsPerCriteria.Rows(i)("ResponseTime").ToString, DTAsPerCriteria.Rows(i)("CityName").ToString)
                        Next
                        RadGridSearch.DataSource = dt1
                        RadGridSearch.DataBind()


                        RadGridSearch.MasterTableView.GetColumn("UserID").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Priority").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ModuleName").Visible = False
                        'RadGridSearch.MasterTableView.GetColumn("DepartmentName").Visible = False

                        RadGridSearch.MasterTableView.GetColumn("UserRemarks").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerRemarks").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Notes").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ModuleID").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Attachment1").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("Attachment2").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerAttach1").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("OwnerAttach2").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("TransactionDateTime").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("DelayInMinutes").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("ResponseTime").Visible = False
                        RadGridSearch.MasterTableView.GetColumn("FarwardToEngineer").Visible = False



                        lblStatus.Text = DTAsPerCriteria.Rows.Count
                    Else
                        Call EmptyTable()
                    End If
                    lblStatus.Text = DTAsPerCriteria.Rows.Count

                Else

                    Call EmptyTable()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub EmptyTable()
        Try
            Dim dt1 As New DataTable()
            dt1.Columns.AddRange(New DataColumn(21) {New DataColumn("Ticket No"), New DataColumn("App Name"), New DataColumn("Complain Date"), New DataColumn("Department Name"), New DataColumn("Status Name"), New DataColumn("User Name"), _
                                                   New DataColumn("UserID"), New DataColumn("AppID"), New DataColumn("Priority"), New DataColumn("ModuleName"), New DataColumn("UserRemarks"), New DataColumn("OwnerRemarks"), _
                                                     New DataColumn("Notes"), New DataColumn("ModuleID"), New DataColumn("Attachment1"), New DataColumn("Attachment2"), New DataColumn("OwnerAttach1"), New DataColumn("OwnerAttach2"), New DataColumn("TransactionDateTime"), New DataColumn("DelayInMinutes"), New DataColumn("ResponseTime"), New DataColumn("CityName")})
            For i As Integer = 0 To DTAsPerCriteria.Rows.Count - 1
                dt1.Rows.Add(DTAsPerCriteria.Rows(i)("TicketNo").ToString, DTAsPerCriteria.Rows(i)("AppName").ToString, Format(DTAsPerCriteria.Rows(i)("ComplainDate"), "dd-MMM-yyyy hh:mm:ss"), DTAsPerCriteria.Rows(i)("DepartmentName").ToString, DTAsPerCriteria.Rows(i)("StatusName").ToString, DTAsPerCriteria.Rows(i)("UserName").ToString, _
                            DTAsPerCriteria.Rows(i)("UserID").ToString, DTAsPerCriteria.Rows(i)("AppID").ToString, DTAsPerCriteria.Rows(i)("Priority").ToString, DTAsPerCriteria.Rows(i)("ModuleName").ToString, DTAsPerCriteria.Rows(i)("UserRemarks").ToString, DTAsPerCriteria.Rows(i)("OwnerRemarks").ToString, _
                            DTAsPerCriteria.Rows(i)("Notes").ToString, DTAsPerCriteria.Rows(i)("ModuleID").ToString, DTAsPerCriteria.Rows(i)("Attachment1").ToString, DTAsPerCriteria.Rows(i)("Attachment2").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach1").ToString, DTAsPerCriteria.Rows(i)("OwnerAttach2").ToString, DTAsPerCriteria.Rows(i)("TransactionDateTime").ToString, DTAsPerCriteria.Rows(i)("DelayInMinutes").ToString, DTAsPerCriteria.Rows(i)("ResponseTime").ToString, DTAsPerCriteria.Rows(i)("CityName").ToString)
            Next
            RadGridSearch.DataSource = dt1
            RadGridSearch.DataBind()
           

            RadGridSearch.MasterTableView.GetColumn("UserID").Visible = False
            'RadGridSearch.MasterTableView.GetColumn("AppID").Visible = False
            RadGridSearch.MasterTableView.GetColumn("Priority").Visible = False
            RadGridSearch.MasterTableView.GetColumn("ModuleName").Visible = False
            RadGridSearch.MasterTableView.GetColumn("FormName").Visible = False
            RadGridSearch.MasterTableView.GetColumn("UserRemarks").Visible = False
            RadGridSearch.MasterTableView.GetColumn("OwnerRemarks").Visible = False
            RadGridSearch.MasterTableView.GetColumn("Notes").Visible = False
            RadGridSearch.MasterTableView.GetColumn("ModuleID").Visible = False
            'RadGridSearch.MasterTableView.GetColumn("Attachment1").Visible = False
            RadGridSearch.MasterTableView.GetColumn("Attachment2").Visible = False
            RadGridSearch.MasterTableView.GetColumn("OwnerAttach1").Visible = False
            RadGridSearch.MasterTableView.GetColumn("OwnerAttach2").Visible = False
            RadGridSearch.MasterTableView.GetColumn("TransactionDateTime").Visible = False
            RadGridSearch.MasterTableView.GetColumn("DelayInMinutes").Visible = False
            RadGridSearch.MasterTableView.GetColumn("ResponseTime").Visible = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RadGridSearch_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGridSearch.ItemCommand
        Try
            If RadGrid.SelectCommandName = "Select" Then

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub RadGridSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadGridSearch.SelectedIndexChanged
        Try

            For Each item As GridDataItem In RadGridSearch.SelectedItems
                If RadGrid.SelectCommandName = "Select" Then
                    Session("TicketNo") = item("Ticket No").Text
                    'Session("ApplciationName") = item("App Name").Text
                    Session("ComplainDate") = item("Complain Date").Text
                    Session("DepartmentName") = item("Department Name").Text
                    Session("StatusName") = item("Status Name").Text
                    Session("UserName") = item("User Name").Text

                    'Session("AppID") = item("AppID").Text
                    Session("Priority") = item("Priority").Text
                    Session("ModuleName") = item("ModuleName").Text
                    Session("UserRemarks") = item("UserRemarks").Text
                    Session("OwnerRemarks") = item("OwnerRemarks").Text
                    Session("Notes") = item("Notes").Text
                    'Session("TransactionDateTime") = Format(CDate(item("TransactionDateTime").Text), "dd-MMM-yyyy hh:mm:ss")
                    Session("ModuleID") = item("ModuleID").Text
                    Session("Attachment1") = item("Attachment1").Text
                    Session("Attachment2") = item("Attachment2").Text
                    Session("OwnerAttach1") = item("OwnerAttach1").Text
                    Session("OwnerAttach2") = item("OwnerAttach2").Text
                    'Session("SupportEngineer") = item("FarwardToEngineer").Text
                    Session("ResponseTime") = item("ResponseTime").Text
                    If Session("ResponseTime") <> "&nbsp;" Then
                        Dim ts As TimeSpan = TimeSpan.FromMinutes(Session("ResponseTime")) 'or --> Dim ts As New TimeSpan(0, 0, 0, 227, 0)
                        If ts.Ticks > 0 Then
                            Dim mydate As DateTime = New DateTime(ts.Ticks)
                            Session("ResponceDate") = (mydate.ToString(("HH:mm")))
                        End If
                    Else
                        Session("ResponceDate") = "00:00"
                    End If
                   

                    'Session("ResponceDate") = item("ResponseTime").Text
                    Session("DelayInMinutes") = item("DelayInMinutes").Text
                    'Session("ETTR") = item("ETTR").Text
                    Response.Redirect("Forwarding.aspx", False)
                End If
            Next


        Catch ex As Exception

        End Try
    End Sub


    Protected Sub RadGridSearch_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridSearch.NeedDataSource

    End Sub


    Protected Sub Group1_CheckedChanged(sender As Object, e As EventArgs) Handles Op_Open.CheckedChanged, OP_InProcess.CheckedChanged, Op_Open.CheckedChanged, OP_Pending.CheckedChanged, OP_Solved.CheckedChanged
        Try
            If Op_Open.Checked = True Then
                Session("Status") = "Open"
            ElseIf OP_InProcess.Checked Then
                Session("Status") = "InProcess"
            ElseIf OP_Pending.Checked = True Then
                Session("Status") = "Pending"
            ElseIf OP_Close.Checked = True Then
                Session("Status") = "Close"
            ElseIf OP_Solved.Checked = True Then
                Session("Status") = "Solved"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadGridSearch_ItemDataBound(sender As Object, e As Telerik.Web.UI.GridItemEventArgs) Handles RadGridSearch.ItemDataBound
        Try
            If TypeOf e.Item Is GridDataItem Then
                Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
                If Convert.ToBoolean(item("backorder").Text) = True Then
                    item("backorder").BackColor = System.Drawing.Color.Red
                Else
                    item("backorder").BackColor = System.Drawing.Color.Orange
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class