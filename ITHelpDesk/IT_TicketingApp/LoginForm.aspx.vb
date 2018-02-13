Imports System.IO

Public Class LoginForm
    Inherits Global.System.Web.UI.Page
    Dim objMain As New MainServiceMethod
    Dim objSub As New ItTicketing_Methods
    'Dim objAuth As New LdapAuthentication
    Dim adAuth As LDAP.WebServiceSoapClient = New LDAP.WebServiceSoapClient
    Private objServ As LoginService.Service1SoapClient = New LoginService.Service1SoapClient()
    Public Shared User As LDAP.AuthUser = New LDAP.AuthUser()

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Try
            Me.WriteToFile("Login: " & "Event:btnSubmit")
            With User
                .UserName = "Portal_01"
                .Password = "Mppl@2017"
            End With

            'Me.tbLoginName.Enabled = False
            'Me.tbPassword.Enabled = False
            'btnSubmit.Enabled = False
            ''


            ' Dim DTLDAP As DataTable = adAuth.
            Dim dt As DataTable = objMain.AuthenticateUser(tbLoginName.Text.Trim, tbPassword.Text.Trim)

            If dt.Rows.Count > 0 Then
                Me.WriteToFile("Login: " & "1")
                Session("FullUserName") = dt.Rows(0)("Name").ToString
                Session("UserID") = dt.Rows(0)("UserID").ToString
                Session("RoleID") = dt.Rows(0)("RoleID").ToString
                Session("CityName") = dt.Rows(0)("CityName").ToString
                Dim IsADAuthenticate = dt.Rows(0)("IsADAuthenticate").ToString

                If IsADAuthenticate = 1 Then
                    If adAuth.Ldap_Authentication(User, tbLoginName.Text.Trim, tbPassword.Text.Trim) Then
                        Me.WriteToFile("Login: " & "2")
                        'Dim ar = objServ.GetMainControl(Session("RoleID"))
                        Dim ar = objMain.GetMainControl(Session("RoleID"))
                        Me.WriteToFile("Login: " & "3")
                        If ar.Count > 0 Then
                            For i = 0 To ar.Count - 1
                                Dim str() As String
                                str = ar(i).Split(":")

                                If str(2) = "ITHelpdesk" Then
                                    Me.WriteToFile("Login: " & "Event:ITHelpdesk")
                                    Response.Redirect("Home.aspx", False)
                                Else
                                    lblStatus.Text = "You are Anonymous User"
                                    btnSubmit.Enabled = True
                                End If
                            Next

                        Else
                            lblStatus.Text = "You are Anonymous User"
                            btnSubmit.Enabled = True
                        End If
                    Else
                        lblStatus.Text = "You are Not Authenticate from Domain"
                        lblStatus.Visible = True
                        btnSubmit.Enabled = True
                        Exit Sub
                    End If

                ElseIf IsADAuthenticate = 0 Then

                    Dim ar = objMain.GetMainControl(Session("RoleID"))
                    If ar.Count > 0 Then
                        For i = 0 To ar.Count - 1
                            Dim str() As String
                            str = ar(i).Split(":")

                            If str(2) = "ITHelpdesk" Then
                                Response.Redirect("Home.aspx", False)
                            Else
                                lblStatus.Text = "You are Anonymous User"
                                btnSubmit.Enabled = True
                            End If
                        Next

                    Else
                        lblStatus.Text = "You are Anonymous User"
                        btnSubmit.Enabled = True

                    End If

                End If

            Else
                lblStatus.Text = "InValid! User name and password Incorrect"
                lblStatus.Visible = True
                btnSubmit.Enabled = True
                Exit Sub
            End If

            lblStatus.Visible = True


            'Else

            'lblNotify.Text = "Invalid User Name or Password"
            'lblNotify.Visible = True
            'Me.txtUsername.Enabled = True
            'Me.txtPassword.Enabled = True
            'End If

        Catch ex As Exception
            Me.WriteToFile("Login: " & ex.Message)
            Me.tbLoginName.Enabled = True
            Me.tbPassword.Enabled = True
            btnSubmit.Enabled = True
            lblStatus.Text = "User name and password Incorrect"
            Me.tbLoginName.Enabled = True
            Me.tbLoginName.Enabled = True
        End Try
    End Sub

    Private Sub WriteToFile(ByVal text As String)
        Dim path As String = My.Settings.Logfile
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using
    End Sub

   
End Class