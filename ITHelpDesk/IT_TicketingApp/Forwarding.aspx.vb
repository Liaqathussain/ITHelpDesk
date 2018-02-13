Imports Telerik.Web.UI
Imports System.Net.Mail
Imports System.IO
Imports System.Net
Public Class WebForm4
    Inherits System.Web.UI.Page
    Public objBL As New ItTicketing_Methods
    Dim dtFormat, dtToEmail As DataTable

    Dim Smtp_Server As SmtpClient
    Dim Subject, EmailFrom, EmailCC, EmailTo, EmailFormat, ApplciationName, ApplicationOwner, TransactionDate, UserName, UserRemarks, StatusName, ScheduleTime, EmailForVendor As String
    Dim objGP As New clsDBAccess(My.Settings.conEmailServer, DBEngineType.SQL)
    Dim objMain As New MainServiceMethod
    Dim DT As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim UserId As Integer = Session("UserID")
            Dim UserName As String = Session("FullUserName")
            DT = objMain.GetUserDetailsbyUserID(UserId)
            If Not Page.IsPostBack = True Then
                Dim dtStatus = objBL.GetComplainStatus()
                Dim dr As DataRow = dtStatus.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dtStatus.Rows.InsertAt(dr, 0)
                'RadComFStatus.Items.Add(New RadComboBoxItem("Please-Select", dtStatus.Rows.Count))
                For J As Integer = 0 To dtStatus.Rows.Count - 1
                    RadComFStatus.Items.Add(New RadComboBoxItem(dtStatus.Rows(J)("StatusName").ToString, J))
                Next

                'Time Schedule
                Dim dtScheduleTime = objBL.GetScheduleTime()
                Dim dr1 As DataRow = dtScheduleTime.NewRow
                dr1(0) = 0
                dr1(1) = "Please-Select"
                dtScheduleTime.Rows.InsertAt(dr1, 0)
                For J As Integer = 0 To dtScheduleTime.Rows.Count - 1
                    RadScheduleTime.Items.Add(New RadComboBoxItem(dtScheduleTime.Rows(J)("ScheduleTime").ToString, J))
                Next
                

                Dim dtTicketHistory = objBL.GetTicketHistory(Session("TicketNo"))
                If dtTicketHistory.Rows.Count > 0 Then
                    Dim dt1 As New DataTable()
                    dt1.Columns.AddRange(New DataColumn(3) {New DataColumn("Ticket No"), New DataColumn("Complain Date"), New DataColumn("UserName"), New DataColumn("Status Name")})
                    For i As Integer = 0 To dtTicketHistory.Rows.Count - 1
                        dt1.Rows.Add(dtTicketHistory.Rows(i)("TicketNo").ToString, Format(dtTicketHistory.Rows(i)("ComplainDate"), "dd-MMM-yyyy hh:mm:ss"), dtTicketHistory.Rows(i)("UserName").ToString, dtTicketHistory.Rows(i)("StatusName").ToString)
                    Next
                    RadGridHistory.DataSource = dt1
                    RadGridHistory.DataBind()
                End If

                Dim dtAdmin As DataTable = objBL.GetAdminName("Admin")
                If dtAdmin.Rows.Count > 0 Then
                    Session("AdminName") = dtAdmin.Rows(0)("UserName").ToString()
                End If

                Dim dtManager As DataTable = objBL.GetManagerInfo("Manager")
                If dtManager.Rows.Count > 0 Then
                    Session("ManagerEmailID") = dtManager.Rows(0)("EmailID").ToString()
                End If


                If DT.Rows(0)("ModuleID") = 1 Then 'Admin
                    'Assign to
                    Dim dtFarward As DataTable = objBL.GetEngineerName
                    RadComboAssignTo.Items.Add(New RadComboBoxItem("Please-Select", dtFarward.Rows.Count))
                    For J As Integer = 0 To dtFarward.Rows.Count - 1
                        RadComboAssignTo.Items.Add(New RadComboBoxItem(dtFarward.Rows(J)("UserName").ToString, J))
                    Next
                ElseIf DT.Rows(0)("ModuleID") = 3 Then 'Support Engineer
                    'Assign to
                    Dim dtFarward As DataTable = objBL.GetEngineerNameOnly(UserName)
                    'RadComboAssignTo.Items.Add(New RadComboBoxItem("Please-Select", dtFarward.Rows.Count))
                    For J As Integer = 0 To dtFarward.Rows.Count - 1
                        RadComboAssignTo.Items.Add(New RadComboBoxItem(dtFarward.Rows(J)("UserName").ToString, J))
                    Next
                End If

            End If

            Session("ETTR") = Date.Now


            'lblApplicationName.Text = Session("AppName")
            lblTicketNo.Text = Session("TicketNo")
            lblPriority.Text = Session("Priority")
            lblusername.Text = Session("UserName")
            'lblModuleName.Text = Session("ModuleName")
            lblComplainDate.Text = Session("ComplainDate")
            'lblForumName.Text = Session("FormName")
            lblUserRemarks.Text = Session("UserRemarks")
            lblOwnerName.Text = Session("OwnerRemarks")
            'lblNotes.Text = Session("Notes")
            'lblTransDate.Text = Session("TransactionDateTime")
            'lblDeptName.Text = Session("DepartmentName")
            lblStatusName.Text = Session("StatusName").ToString.Trim
            'LinkButton1.Text = Session("Attachment1")

            'lblApplicationName.Text = Session("ApplciationName")
            lblResponceDate.Text = "(hh:mm)" & " " & Session("ResponceDate")

            If Session("StatusName").ToString.Trim <> "Solved" Or Session("StatusName").ToString.Trim <> "Close" Then
                Dim ts As TimeSpan = TimeSpan.FromMinutes(Session("DelayInMinutes")) 'or --> Dim ts As New TimeSpan(0, 0, 0, 227, 0)
                If ts.Ticks > 0 Then
                    Dim mydate As DateTime = New DateTime(ts.Ticks)
                    lblDuration.Text = (mydate.ToString(("HH:mm:ss")))
                End If
                
            End If

            'lblEngineer.Text = Session("SupportEngineer")



            'Users
            If DT.Rows(0)("ModuleID") = 2 Then
               
                RadTextOwner.Visible = False
                lblOwner.Visible = False
                RadTextUser.Visible = False
                'RadAsyncUpload1.Visible = False
                'lblAttachement.Visible = False
                RadComboAssignTo.Visible = False
                RadComFStatus.Visible = False
                RequiredFieldValidator2.Visible = False
                lblStatusDrop.Visible = False

                'LinkBtnUpdate.Visible = False

                lblAssignto.Visible = False
                RadTextUser.Visible = True
                lblUser.Visible = True
                lblOwnerName.Enabled = False
                Session("UserName") = DT.Rows(0)("UserName")

                If Session("StatusName") = "Solved" Then
                    RadBtnFUpdate.Enabled = True
                    RadTextUser.Enabled = True
                Else
                    RadBtnFUpdate.Enabled = False
                    RadTextUser.Enabled = False
                End If

                lblScheduleTime.Visible = False
                RadScheduleTime.Visible = False
                'Engineer Name
            ElseIf DT.Rows(0)("ModuleID") = 3 Then
               
                RadTextOwner.Visible = True
                RadTextUser.Visible = False
                lblUser.Visible = False
                'RadAsyncUpload1.Visible = True
                'lblAttachement.Visible = True
                RadComboAssignTo.Visible = True
                'LinkBtnUpdate.Visible = True

                lblAssignto.Visible = True

                lblUserRemarks.Enabled = False
                Session("UserName") = DT.Rows(0)("UserName")

                lblScheduleTime.Visible = True
                RadScheduleTime.Visible = True

                'Admin
            ElseIf DT.Rows(0)("ModuleID") = 1 Then
                

                RadTextOwner.Visible = True
                RadTextUser.Visible = False
                'RadAsyncUpload1.Visible = True
                'lblAttachement.Visible = True
                RadComboAssignTo.Visible = True
                'LinkBtnUpdate.Visible = True

                lblAssignto.Visible = True
                RadTextUser.Visible = False
                lblUser.Visible = False
                Session("UserName") = DT.Rows(0)("UserName")
            End If


        Catch ex As Exception

        End Try
    End Sub

    
    Protected Sub RadBtnFUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadBtnFUpdate.Click
        Try

            Dim count As Integer = 1
            Dim Attachment(1) As String
            Attachment(0) = ""
            Attachment(1) = ""
            'If RadAsyncUpload1.UploadedFiles.Count > 0 Then
            '    For Each file As UploadedFile In RadAsyncUpload1.UploadedFiles
            '        Dim targetFolder As [String] = Server.MapPath("~/Folder/")
            '        file.SaveAs(Path.Combine(targetFolder, Session("TicketNo") & "-o-" & file.FileName))

            '        If count = 1 Then
            '            Attachment(0) = Session("TicketNo") & "-o-" & file.FileName
            '            Attachment(1) = ""
            '        Else
            '            Attachment(1) = Session("TicketNo") & "-o-" & file.FileName
            '        End If
            '        count = count + 1
            '    Next
            'Else
            '    Attachment(0) = ""
            '    Attachment(1) = ""
            'End If

            Dim UserId As Integer = Session("UserID")
            'View Complaint 
            Dim Flag As Boolean
            'Users
            If DT.Rows(0)("ModuleID") = 2 Then
                Flag = objBL.UpdateUserComplain(Session("TicketNo"), Session("UserRemarks"))

                Dim HisDTstatus As Boolean = objBL.InsertComplainHistory(Session("TicketNo"), Session("UserId"), 6, Session("OwnerRemarks"), Attachment(0), Attachment(1))
                If HisDTstatus = True Then
                    lblStatus.Text = "Updated Successfully"
                Else
                    lblStatus.Text = "History Failed"
                End If
                dtFormat = objBL.GetSearchForEndUser(UserId, Session("TicketNo"))

                If dtFormat.Rows.Count > 0 Then
                    Call EmailFormatingForEndUser()
                    Call ConformationEmail(Subject, EmailFrom, EmailCC, EmailTo, EmailFormat, "User")
                End If
                
                'Support Engineer
            ElseIf DT.Rows(0)("ModuleID") = 3 Then
                If RadComboAssignTo.Text <> "Please-Select" Then
                    If Session("StatusID") = "2" Then 'InProgress
                        Flag = objBL.UpdateComplainInProcess(Session("TicketNo"), Session("StatusID"), Session("OwnerRemarks"), Attachment(0), Attachment(1), RadComboAssignTo.Text.Trim, Session("ScheduleTime"))
                    ElseIf Session("StatusID") = "3" Then 'Pending
                        Flag = objBL.UpdateComplainPending(Session("TicketNo"), Session("StatusID"), Session("OwnerRemarks"), Attachment(0), Attachment(1), RadComboAssignTo.Text.Trim)
                    ElseIf Session("StatusID") = "4" Then 'Solved
                        Flag = objBL.UpdateComplainSolved(Session("TicketNo"), Session("StatusID"), Session("OwnerRemarks"), Attachment(0), Attachment(1), RadComboAssignTo.Text.Trim)
                    End If

                    Dim HisDTstatus As Boolean = objBL.InsertComplainHistory(Session("TicketNo"), Session("UserId"), Session("StatusID"), Session("OwnerRemarks"), Attachment(0), Attachment(1))
                    If HisDTstatus = True Then
                        lblStatus.Text = "Updated Successfully"
                    Else
                        lblStatus.Text = "History Failed"
                    End If
                    dtFormat = objBL.GetForwardEmail(UserId)
                    dtToEmail = objBL.GetEmailTo(Session("TicketNo"))
                    If dtFormat.Rows.Count > 0 Then
                        Call EmailFormatingOwner()
                        If dtToEmail.Rows.Count > 0 Then
                            EmailTo = dtToEmail.Rows(0)("EmailID").ToString
                        End If
                        Call ConformationEmail(Subject, EmailFrom, EmailCC, EmailTo, EmailFormat, "Owner")
                    End If
                Else
                    lblStatus.Text = "Please Select AssignTo"
                End If
                'Admin
            ElseIf DT.Rows(0)("ModuleID") = 1 Then
                Flag = objBL.UpdateComplain(Session("TicketNo"), Session("StatusID"), Session("UserRemarks"), Attachment(0), Attachment(1), Session("AssignTo"))
                Dim HisDTstatus As Boolean = objBL.InsertComplainHistory(Session("TicketNo"), Session("UserId"), Session("StatusID"), Session("UserRemarks"), Attachment(0), Attachment(1))
                If HisDTstatus = True Then
                    lblStatus.Text = "Updated Successfully"
                Else
                    lblStatus.Text = "History Failed"
                End If

                dtFormat = objBL.GetForwardEmail(Session("SupportEngineerUserID"))
                dtToEmail = objBL.GetForwardEmail(Session("UserID"))
                If dtFormat.Rows.Count > 0 Then
                    Call EmailFormatingAdmin()
                    'If dtFormat.Rows.Count > 0 Then
                    '    EmailTo = dtFormat.Rows(0)("EmailFrom").ToString
                    'End If
                    Call ConformationEmail(Subject, EmailFrom, EmailCC, EmailTo, EmailFormat, "Owner")
                End If

                If Flag = False Then
                    lblStatus.Text = "Status: Assign To Fail"
                Else
                    lblStatus.Text = "Status: Assigned To Succeeded"
                End If

            End If
            If Flag = False Then
                lblStatus.Text = "Status: Please Select the required Fields"
            Else
                lblStatus.Text = "Status: Succeeded"
            End If
            '-----------------------------
            Response.Redirect("Home.aspx", False)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ClearVariables()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Protected Sub RadComFStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComFStatus.SelectedIndexChanged
        Try
            Session("StatusID") = RadComFStatus.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

   

    Protected Sub RadTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadTextOwner.TextChanged
        Try
            Session("OwnerRemarks") = RadTextOwner.Text
        Catch ex As Exception

        End Try
    End Sub
    Public Sub EmailFormatingOwner()
        Try
            Subject = dtFormat.Rows(0)("Subject").ToString
            EmailFrom = dtFormat.Rows(0)("EmailFrom").ToString
            EmailTo = dtFormat.Rows(0)("EmailTo").ToString
            EmailCC = dtFormat.Rows(0)("EmailCC").ToString
            If RadComFStatus.Text.Trim = "InProcess" Then
                EmailFormat = dtFormat.Rows(0)("EmailFormatInProcess").ToString
            ElseIf RadComFStatus.Text.Trim = "Pending" Then
                EmailFormat = dtFormat.Rows(0)("EmailFormatPending").ToString
            ElseIf RadComFStatus.Text.Trim = "Solved" Then
                EmailFormat = dtFormat.Rows(0)("EmailFormatSolved").ToString
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub EmailFormatingAdmin()
        Try
            Subject = dtFormat.Rows(0)("Subject").ToString
            EmailFrom = dtToEmail.Rows(0)("EmailFrom").ToString
            EmailTo = dtFormat.Rows(0)("EmailFrom").ToString
            EmailCC = dtFormat.Rows(0)("EmailCC").ToString
            EmailFormat = dtFormat.Rows(0)("EmailFormat3").ToString
        Catch ex As Exception

        End Try
    End Sub
    Public Sub EmailFormatingForEndUser()
        Try
            Subject = dtFormat.Rows(0)("Subject").ToString
            EmailFrom = dtFormat.Rows(0)("EmailFrom").ToString
            EmailTo = dtFormat.Rows(0)("EmailCC").ToString
            EmailCC = Session("ManagerEmailID")
            EmailFormat = dtFormat.Rows(0)("EmailFormatClosed").ToString
        Catch ex As Exception

        End Try
    End Sub
    Public Sub EmailFormatingForVendor()
        Try
            Subject = dtFormat.Rows(0)("Subject").ToString
            EmailFrom = dtFormat.Rows(0)("EmailFrom").ToString
            EmailTo = dtFormat.Rows(0)("EmailTo").ToString
            EmailFormat = dtFormat.Rows(0)("EmailFormat3").ToString

        Catch ex As Exception

        End Try
    End Sub
    Public Function ConformationEmail(ByVal Subject As String, ByVal EmailFrom As String, ByVal EmailCC As String, ByVal Emailto As String, ByVal EmailFormat As String, ByVal UserType As String) As Boolean

        Try
            Dim dt_Server = objGP.SP_Datatable("sp_GetEmailServer")
            Smtp_Server = New SmtpClient
            Dim msg As MailMessage
            Dim dt = objBL.GetEmailData(Session("TicketNo"))
            Dim Priority, DepartmentName, EmailID As String
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    msg = New MailMessage
                    ApplciationName = dt.Rows(i)("AppName").ToString
                    TransactionDate = dt.Rows(i)("TransactionDateTime").ToString
                    StatusName = dt.Rows(i)("StatusName").ToString
                    Session("UserName") = dt.Rows(i)("UserName").ToString
                    Priority = dt.Rows(i)("Priority").ToString
                    EmailID = dt.Rows(i)("EmailID").ToString

                    DepartmentName = Session("DeptName")
                    Dim city As String = Session("CityName")

                    If UserType = "User" Then
                        UserRemarks = dt.Rows(i)("UserRemarks").ToString
                    Else
                        UserRemarks = dt.Rows(i)("OwnerRemarks").ToString
                    End If

                    StatusName = dt.Rows(i)("StatusName").ToString
                    UserName = dt.Rows(i)("UserName").ToString
                    ScheduleTime = dt.Rows(i)("ScheduleTime").ToString

                    Dim SubjectForLog As String = Subject & "-" & Session("TicketNo")
                    msg.From = New MailAddress(EmailFrom) 'EmailFrom

                    msg.To.Add(Emailto)
                    'msg.To.Add("liaqat.hussain@multinet.com.pk") '"nomansh@multinet.com.pk
                    'Multiple Email Address
                    'Dim strArry() As String
                    'Dim count As Integer
                    'strArry = EmailID.Split(",")
                    'For count = 0 To strArry.Length - 1
                    '    msg.CC.Add(strArry(count))
                    'Next
                    msg.CC.Add(EmailCC) 'end user
                    'msg.CC.Add("liaqat.hussain@multinet.com.pk")
                    msg.Subject = Subject & "-" & Session("TicketNo")
                    msg.IsBodyHtml = True
                    msg.Priority = MailPriority.High


                    Dim EmailFormatForAll As String

                    If RadComFStatus.Text.Trim = "InProcess" Then

                        Dim arr() As String = Split(EmailFormat, "!")
                        EmailFormatForAll = arr(0).ToString & Session("UserName") & arr(2).ToString & RadComboAssignTo.Text & arr(4).ToString _
                                             & Session("TicketNo") & arr(6).ToString & RadComboAssignTo.Text & arr(8).ToString & ScheduleTime.Trim & arr(10).ToString
                        msg.Body = EmailFormatForAll

                    ElseIf RadComFStatus.Text.Trim = "Pending" Then

                        Dim arr() As String = Split(EmailFormat, "!")
                        EmailFormatForAll = arr(0).ToString & Session("UserName") & arr(2).ToString & Session("TicketNo") & arr(4).ToString _
                                             & RadTextOwner.Text & arr(6).ToString
                        msg.Body = EmailFormatForAll

                    ElseIf RadComFStatus.Text.Trim = "Solved" Then

                        Dim arr() As String = Split(EmailFormat, "!")
                        EmailFormatForAll = arr(0).ToString & Session("UserName") & arr(2).ToString & Session("TicketNo") & arr(4).ToString

                        msg.Body = EmailFormatForAll

                    Else

                        Dim arr() As String = Split(EmailFormat, "!")
                        EmailFormatForAll = arr(0).ToString & Session("AdminName") & arr(2).ToString & Session("UserName") & arr(4).ToString _
                            & Session("TicketNo") & arr(6).ToString & UserRemarks & arr(8).ToString

                        msg.Body = EmailFormatForAll
                    End If



                    Smtp_Server.Host = dt_Server.Rows(1)(2)
                    Smtp_Server.Send(msg)
                    msg.To.Clear()
                    msg.CC.Clear()
                    Me.WriteToFile("Email Details: " & "Alert:" & SubjectForLog & Emailto)
                Next
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Sub WriteToFile(ByVal text As String)
        Dim path As String = My.Settings.Logfile
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using
    End Sub

    Protected Sub RadTextUser_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadTextUser.TextChanged
        Try
            Session("UserRemarks") = RadTextUser.Text
        Catch ex As Exception

        End Try
    End Sub

    'Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
    '    Try
    '        Dim strRequest As String = Session("Attachment1") '-- if something was passed to the file querystring
    '        If strRequest <> "" Then 'get absolute path of the file
    '            Dim path As String = Server.MapPath("~/Folder/" & Session("Attachment1")) 'get file object as FileInfo
    '            Dim file As System.IO.FileInfo = New System.IO.FileInfo(path) '-- if the file exists on the server
    '            If file.Exists Then 'set appropriate headers
    '                Response.Clear()
    '                Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
    '                Response.AddHeader("Content-Length", file.Length.ToString())
    '                Response.ContentType = "application/octet-stream"
    '                Response.WriteFile(file.FullName)
    '                Response.End() 'if file does not exist
    '            Else
    '                lblStatus.Text = ("This file does not exist.")
    '            End If 'nothing in the URL as HTTP GET
    '        Else
    '            lblStatus.Text = ("Please provide a file to download.")
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub



    Protected Sub RadComboAssignTo_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboAssignTo.SelectedIndexChanged
        Try

            Session("AssignTo") = RadComboAssignTo.Text
            Dim dtFarward As DataTable = objBL.GetEngineerNameOnly(RadComboAssignTo.Text)
            If dtFarward.Rows.Count > 0 Then
                Session("SupportEngineerUserID") = dtFarward.Rows(0)("UserID").ToString
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadGridHistory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadGridHistory.SelectedIndexChanged
        Try

            If IsPostBack = True Then
                For Each item1 As GridDataItem In RadGridHistory.SelectedItems
                    If RadGrid.SelectCommandName = "Select" Then
                        'If (e.CommandName = "Attachement1") Then
                        Dim strRequest As String = Session("Attachment1") '-- if something was passed to the file querystring
                        If strRequest <> "" Then 'get absolute path of the file
                            Dim path As String = Server.MapPath("~/Folder/" & Session("Attachment1")) 'get file object as FileInfo
                            Dim file As System.IO.FileInfo = New System.IO.FileInfo(path) '-- if the file exists on the server
                            If file.Exists Then 'set appropriate headers
                                Response.Clear()
                                Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
                                Response.AddHeader("Content-Length", file.Length.ToString())
                                Response.ContentType = "application/octet-stream"
                                Response.WriteFile(file.FullName)
                                'Dim strNewPath As String = IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + "\Downloads\"
                                'Process.Start("explorer.exe", strNewPath & file.Name)
                                Response.End() 'if file does not exist
                            Else
                                lblStatus.Text = ("This file does not exist.")
                            End If 'nothing in the URL as HTTP GET
                        Else
                            lblStatus.Text = ("Please provide a file to download.")
                        End If

                    End If
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub RadGridHistory_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridHistory.NeedDataSource

    End Sub

    Protected Sub RadScheduleTime_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadScheduleTime.SelectedIndexChanged
        Try
            If RadScheduleTime.Text <> "Please-Select" Then
                Session("ScheduleTime") = RadScheduleTime.Text
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class