Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO
Imports Telerik.Web.UI
Imports System.Net

Public Class ItTicketing_Methods
    Dim objSub As New MainServiceMethod
    Dim objIT As New clsDBAccess(My.Settings.conIT, DBEngineType.SQL)
    Public Function GetApplicationDetails() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetApplicationDetails")
            dt.TableName = "sp_GetApplicationDetails"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetIssueTypes() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetIssueTypes")
            dt.TableName = "sp_GetIssueTypes"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetTotalComp() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetTotalComplaints")
            dt.TableName = "sp_GetTotalComplaints"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetOpenComp() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetOpenComplaints")
            dt.TableName = "sp_GetOpenComplaints"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetInprocessComp() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetInprocessComplaints")
            dt.TableName = "sp_GetInprocessComplaints"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetPending() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetPending")
            dt.TableName = "sp_GetPending"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetSolved() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetSolved")
            dt.TableName = "sp_GetSolved"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetClosed() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetClosed")
            dt.TableName = "sp_GetClosed"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardware() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardware")
            dt.TableName = "sp_GetHardware"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardwareOpen() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardwareOpen")
            dt.TableName = "sp_GetHardwareOpen"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardwareInProcess() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardwareInProcess")
            dt.TableName = "sp_GetHardwareInProcess"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardwarePending() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardwarePending")
            dt.TableName = "sp_GetHardwarePending"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardwareSolved() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardwareSolved")
            dt.TableName = "sp_GetHardwareSolved"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetHardwareClosed() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetHardwareClosed")
            dt.TableName = "sp_GetHardwareClosed"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComSoftware() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftware")
            dt.TableName = "sp_GetComSoftware"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function

    Public Function GetComSoftwareOpen() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftwareOpen")
            dt.TableName = "sp_GetComSoftwareOpen"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComSoftwareInProcess() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftwareInProcess")
            dt.TableName = "sp_GetComSoftwareInProcess"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComSoftwarePending() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftwarePending")
            dt.TableName = "sp_GetComSoftwarePending"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComSoftwareSolved() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftwareSolved")
            dt.TableName = "sp_GetComSoftwareSolved"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComSoftwareClosed() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetComSoftwareClosed")
            dt.TableName = "sp_GetComSoftwareClosed"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetwork() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetwork")
            dt.TableName = "sp_GetNetwork"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetworkOpen() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetworkOpen")
            dt.TableName = "sp_GetNetworkOpen"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetworkInProcess() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetworkInProcess")
            dt.TableName = "sp_GetNetworkInProcess"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetworkPending() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetworkPending")
            dt.TableName = "sp_GetNetworkPending"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetworkSolved() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetworkSolved")
            dt.TableName = "sp_GetNetworkSolved"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetNetworkClosed() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetNetworkClosed")
            dt.TableName = "sp_GetNetworkClosed"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetComplainStatus() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetStatus")
            dt.TableName = "sp_GetStatus"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetScheduleTime() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetScheduleTime")
            dt.TableName = "sp_GetScheduleTime"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetTicketHistory(ByVal TicketNo As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@TicketNo", TicketNo}}
            dt = objIT.SP_Datatable("sp_GetTicketHistory", para)
            dt.TableName = "sp_GetTicketHistory"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetEngineerName() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetEngineerName")
            dt.TableName = "sp_GetEngineerName"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetEngineerNameOnly(ByVal EngineerName As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@EngineerName", EngineerName}}
            dt = objIT.SP_Datatable("sp_GetEngineerNameOnly", para)
            dt.TableName = "sp_GetEngineerNameOnly"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetAdminName(ByVal AdminName As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@AdminName", AdminName}}
            dt = objIT.SP_Datatable("sp_GetAdminName", para)
            dt.TableName = "sp_GetAdminName"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetManagerInfo(ByVal Manager As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@Manager", Manager}}
            dt = objIT.SP_Datatable("sp_GetManagerName", para)
            dt.TableName = "sp_GetManagerName"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetRequestType(ByVal IssueID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@IssueID", IssueID}}
            dt = objIT.SP_Datatable("sp_GetIssues", para)
            dt.TableName = "sp_GetIssues"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    'Used
    Public Function GetSearchResult() As DataTable
        Dim dt As New DataTable
        Try
            'Dim para As String(,) = {{"@AppID1", AppID1}, {"@AppID2", AppID2}, {"@AppID3", AppID3}, {"@AppID4", AppID4}}
            dt = objIT.SP_Datatable("sp_GetSearchResult")
            dt.TableName = "sp_GetSearchResult"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetSearchResultbyUser(ByVal UserID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@UserID", UserID}}
            dt = objIT.SP_Datatable("sp_GetSearchResultByUser", para)
            dt.TableName = "sp_GetSearchResultByUser"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetSearchForEndUser(ByVal UserID As String, ByVal TicketID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@UserID", UserID}, {"@TicketID", TicketID}}
            dt = objIT.SP_Datatable("sp_GetSearhForEndUser", para)
            dt.TableName = "sp_GetSearhForEndUser"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetEmailTo(TicketID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@TicketID", TicketID}}
            dt = objIT.SP_Datatable("sp_GetSupportToEndUser", para)
            dt.TableName = "sp_GetSupportToEndUser"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetSearchResultAdmin() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetSearchResultAdmin")
            dt.TableName = "sp_GetSearchResultAdmin"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function DownloadImages(ByVal filename As String, ByVal targetfolder As String) As Byte()
        Try
            'Dim fs As FileStream = Nothing

            'fs = New FileStream("D:\Liaqat Data D\Project Backup\IT_Ticketing\IT_Ticketing\IT_TicketingApp\Folder\" & filename, FileMode.Open)
            'Dim fi As FileInfo = New FileInfo("D:\Liaqat Data D\Project Backup\IT_Ticketing\IT_Ticketing\IT_TicketingApp\Folder\" & filename)
            'Server Setting

            Dim fs As New System.IO.FileStream(targetfolder & filename, IO.FileMode.Open, IO.FileAccess.Read)
            'fs = New FileStream("D:\BusinessApps\IT_Ticketing\IT_Ticketing\IT_TicketingApp\Folder\" & filename, FileMode.Open)
            Me.WriteToFile(targetfolder & filename)
            Dim fi As FileInfo = New FileInfo(targetfolder & filename)
            Dim temp As Long = fi.Length
            Dim lung As Integer = Convert.ToInt64(temp)
            Me.WriteToFile(temp)
            Dim picture As Byte() = New Byte(lung - 1) {}
            fs.Read(picture, 0, lung)
            fs.Close()

            Return picture

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
    Public Function GetSearchAsPerCriteria(ByVal AppID As Integer, ByVal Status As String, ByVal TicketNo As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@UserID", AppID}, {"@Status", Status}, {"@TicketNo", TicketNo}}
            dt = objIT.SP_Datatable("sp_GetSearchAsPerCriteria", para)
            dt.TableName = "sp_GetSearchAsPerCriteria"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetSearchAsPerCriteriaSupportEng(ByVal Status As String, ByVal TicketNo As String, ByVal CityID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@Status", Status}, {"@TicketNo", TicketNo}, {"@CityID", CityID}}
            dt = objIT.SP_Datatable("sp_GetSearchbySupportEngineer", para)
            dt.TableName = "sp_GetSearchbySupportEngineer"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    'Public Function GetSearchByTicketNo(ByVal TicketNo As String) As DataTable
    '    Dim dt As New DataTable
    '    Try
    '        Dim para As String(,) = {{"@TicketNo", TicketNo}}
    '        dt = objIT.SP_Datatable("sp_GetSearchByTicketNo", para)
    '        dt.TableName = "sp_GetSearchByTicketNo"
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try
    'End Function
    Public Function GetSearchAsPerAppID(ByVal AppID As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@AppID", AppID}}
            dt = objIT.SP_Datatable("sp_GetSearchAsPerAppID", para)
            dt.TableName = "sp_GetSearchAsPerAppID"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetForwardEmail(ByVal AppID As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@UserID", AppID}}
            dt = objIT.SP_Datatable("dbo.sp_GetForwaredEmail", para)
            dt.TableName = "dbo.sp_GetForwaredEmail"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Function GetEmailData(ByVal TicketID As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim para As String(,) = {{"@TicketNo", TicketID}}
            dt = objIT.SP_Datatable("sp_GetSearchAsPerAppID", para)
            dt.TableName = "sp_GetSearchAsPerAppID"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function

    Public Sub GetUserType(ByVal DropDownList As DropDownList)
        Try
            Dim dt = objSub.GetUserType()
            If dt.Rows.Count > 0 Then
                DropDownList.DataTextField = "UserType"
                DropDownList.DataValueField = "UserTpeID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                DropDownList.DataSource = dt
                DropDownList.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetPriority() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetPriority")
            dt.TableName = "sp_GetPriority"
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
    Public Sub GetComplainStatus(ByVal DropDownList As DropDownList)
        Try
            Dim dt = objSub.GetComplainStatus()
            If dt.Rows.Count > 0 Then
                DropDownList.DataTextField = "StatusName"
                DropDownList.DataValueField = "StatusID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                DropDownList.DataSource = dt
                DropDownList.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GetDepartment(ByVal DropDownList As DropDownList)
        Try
            Dim dt = objSub.GetDepartment()
            If dt.Rows.Count > 0 Then
                DropDownList.DataTextField = "DepartmentName"
                DropDownList.DataValueField = "DeptID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                DropDownList.DataSource = dt
                DropDownList.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function UploadFile(ByVal picture() As Byte, ByVal filename As String) As Boolean
        Try
            If objSub.UploadFile(picture, filename) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function RoleBaseLogin(ByVal UserID As String) As DataTable
        Dim dt As New DataTable
        Try

            Dim para As String(,) = {{"@UserID", UserID}}
            dt = objIT.SP_Datatable("sp_GetUserDetailsbyUserID", para)
            dt.TableName = "sp_GetUserDetailsbyUserID"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return dt
    End Function

    Public Function GetTotalComplaints() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetTotalComplaints")
            dt.TableName = "sp_GetTotalComplaints"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return dt
    End Function
    Public Function GetMaxTicketNo() As DataTable
        Dim dt As New DataTable
        Try
            dt = objIT.SP_Datatable("sp_GetMaxTicketNo")
            dt.TableName = "sp_GetMaxTicketNo"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return dt
    End Function
    Public Function GetVendorEmail(ByVal VendorName As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim Para As String(,) = {{"@VendorName", VendorName}}
            dt = objIT.SP_Datatable("sp_GetVendorEmail", Para)
            dt.TableName = "sp_GetVendorEmail"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return dt
    End Function

    Public Function InsertComplainHistory(ByVal TicketNo As String,
                                  ByVal TransactionBy As String, _
                                  ByVal StatusID As String, _
                                  ByVal Remarks As String, _
                                  ByVal Attachment1 As String, _
                                  ByVal Attachment2 As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@TransactionBy", TransactionBy}, _
                                     {"@StatusID", StatusID}, {"@Remarks", Remarks}, {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}}

            If objIT.InsertProc_ComplaintHistory("sp_InsertComplainHistory", Para) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UploadImageFile(ByVal picture() As Byte, ByVal filename As String) As String
        Try

            Dim ms As MemoryStream = New MemoryStream(picture, 0, picture.Length)
            Dim path As String = "D:\test\"
            Dim fi As FileInfo = New FileInfo("D:\test\" & filename)
            If fi.Exists Then
                Return "Already"
            Else
                Dim fs As New FileStream(path + filename, FileMode.Create)
                ms.WriteTo(fs)
                ms.Close()
                fs.Close()
                Return "Upload"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function InsertComplain(ByVal TicketNo As String, _
                                   ByVal AppID As Integer, _
                                   ByVal PriorityID As Integer, _
                                   ByVal StatusID As Integer, _
                                   ByVal UserID As Integer, _
                                   ByVal RequestType As String, _
                                   ByVal UserRemarks As String, _
                                   ByVal Attachment1 As String, _
                                   ByVal Attachment2 As String, _
                                   ByVal TransactionBy As Integer) As Integer
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@AppID", AppID}, {"@PriorityID", PriorityID}, _
                                     {"@StatusID", StatusID}, {"@UserID", UserID}, {"@ReqType", RequestType}, _
                                     {"@UserRemarks", UserRemarks}, _
                                     {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}, _
                                     {"@TransactionBy", TransactionBy}}

            Dim lastComplainID = objIT.InsertProc_GetLastComplainID("sp_InsertComplain", Para)
            Return lastComplainID

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplainInProcess(ByVal TicketNo As String, ByVal StatusID As Integer, ByVal OwnerRemarks As String, ByVal Attachment1 As String, ByVal Attachment2 As String, ByVal ForwardToEngineer As String, ByVal ScheduleTime As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@StatusID", StatusID}, {"@OwnerRemarks", OwnerRemarks}, {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}, {"@ForwardToEngineer", ForwardToEngineer}, {"@ScheduleTime", ScheduleTime}}

            If objIT.executeProcess("sp_UpdateComplainInProcess", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplain(ByVal TicketNo As String, ByVal StatusID As Integer, ByVal OwnerRemarks As String, ByVal Attachment1 As String, ByVal Attachment2 As String, ByVal ForwardToEngineer As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@StatusID", StatusID}, {"@OwnerRemarks", OwnerRemarks}, {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}, {"@ForwardToEngineer", ForwardToEngineer}}

            If objIT.executeProcess("sp_UpdateComplain", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplainPending(ByVal TicketNo As String, ByVal StatusID As Integer, ByVal OwnerRemarks As String, ByVal Attachment1 As String, ByVal Attachment2 As String, ByVal ForwardToEngineer As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@StatusID", StatusID}, {"@OwnerRemarks", OwnerRemarks}, {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}, {"@ForwardToEngineer", ForwardToEngineer}}

            If objIT.executeProcess("sp_UpdateComplainPending", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplainSolved(ByVal TicketNo As String, ByVal StatusID As Integer, ByVal OwnerRemarks As String, ByVal Attachment1 As String, ByVal Attachment2 As String, ByVal ForwardToEngineer As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@StatusID", StatusID}, {"@OwnerRemarks", OwnerRemarks}, {"@Attachment1", Attachment1}, {"@Attachment2", Attachment2}, {"@ForwardToEngineer", ForwardToEngineer}}

            If objIT.executeProcess("sp_UpdateComplainSolved", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateComplainAssignTo(ByVal TicketNo As String, ByVal FarwardToOwner As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@FarwardToOwner", FarwardToOwner}}

            If objIT.executeProcess("sp_UpdateComplainAssignTo", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplainScreens(ByVal TicketNo As String, ByVal Attachement1 As String, ByVal Attachement2 As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@Attachement1", Attachement1}, {"@Attachement2", Attachement2}}

            If objIT.executeProcess("sp_UpdateComplainScreen", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateUserComplain(ByVal TicketNo As String, ByVal UserRemarks As String) As Boolean
        Try

            Dim Para As String(,) = {{"@TicketNo", TicketNo}, {"@UserRemarks", UserRemarks}}

            If objIT.executeProcess("sp_UpdateUserComplain", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateComplainModify(ByVal ComplainID As Integer,
                                  ByVal StatusID As Integer) As Boolean
        Try

            Dim Para As String(,) = {{"@ComplainID", ComplainID}, {"@StatusID", StatusID}}

            If objIT.executeProcess("sp_UpdateComplainModify", Para) Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
