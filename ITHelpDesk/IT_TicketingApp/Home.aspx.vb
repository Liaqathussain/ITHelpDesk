Public Class WebForm1
    Inherits System.Web.UI.Page
    Public objBL As New ItTicketing_Methods
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack = True Then
                Dim dtAll As DataTable = objBL.GetTotalComp()
                If dtAll.Rows.Count > 0 Then
                    lblTotalRecords.Text = dtAll.Rows(0)("TotalComplaints").ToString
                End If
                '---------
                Dim dtOpen As DataTable = objBL.GetOpenComp()
                If dtOpen.Rows.Count > 0 Then
                    lblOpen.Text = dtOpen.Rows(0)("OpenComplaints").ToString
                End If


                '------------
                Dim dtInProcess As DataTable = objBL.GetInprocessComp()
                If dtInProcess.Rows.Count > 0 Then
                    lblInprocess.Text = dtInProcess.Rows(0)("InprocessComplaints").ToString
                End If
                '----------------------
                Dim dtPending As DataTable = objBL.GetPending
                If dtPending.Rows.Count > 0 Then
                    lblPending.Text = dtPending.Rows(0)("Pending").ToString
                End If

                '----------------------
                Dim dtSolved As DataTable = objBL.GetSolved
                If dtSolved.Rows.Count > 0 Then
                    lblSolved.Text = dtSolved.Rows(0)("Solved").ToString
                End If

                '--------------
                Dim dtClosed As DataTable = objBL.GetClosed
                If dtClosed.Rows.Count > 0 Then
                    lblClosed.Text = dtClosed.Rows(0)("Closed").ToString
                End If

                '---------Hardware-----------
                Dim dtHardware As DataTable = objBL.GetHardware
                If dtHardware.Rows.Count > 0 Then
                    lblComHardware.Text = dtHardware.Rows(0)("Hardware").ToString
                End If

                'Open
                Dim dtHardwareOpen As DataTable = objBL.GetHardwareOpen
                If dtHardwareOpen.Rows.Count > 0 Then
                    lblHarwareOpen.Text = dtHardwareOpen.Rows(0)("HardwareOpen").ToString
                End If

                'InProcess
                Dim dtHardwareInProcess As DataTable = objBL.GetHardwareInProcess
                If dtHardwareInProcess.Rows.Count > 0 Then
                    lblHarInProc.Text = dtHardwareInProcess.Rows(0)("HardwareInProcess").ToString
                End If

                'Pending
                Dim dtHardwarePending As DataTable = objBL.GetHardwarePending
                If dtHardwarePending.Rows.Count > 0 Then
                    lblHarPending.Text = dtHardwarePending.Rows(0)("HardwarePending").ToString
                End If

                'Solved
                Dim dtHardwareSolved As DataTable = objBL.GetHardwareSolved
                If dtHardwareSolved.Rows.Count > 0 Then
                    lblHardSolved.Text = dtHardwareSolved.Rows(0)("HardwareSolved").ToString
                End If
                'Closed
                Dim dtHardwareClosed As DataTable = objBL.GetHardwareClosed
                If dtHardwareClosed.Rows.Count > 0 Then
                    lblHardClosed.Text = dtHardwareClosed.Rows(0)("HardwareClosed").ToString
                End If


                '---------Software----------------------------------------------------------------------
                Dim dtSoftware As DataTable = objBL.GetComSoftware
                If dtSoftware.Rows.Count > 0 Then
                    lblComSoftware.Text = dtSoftware.Rows(0)("Software").ToString
                End If

                'Open
                Dim dtSoftwareOpen As DataTable = objBL.GetComSoftwareOpen
                If dtSoftwareOpen.Rows.Count > 0 Then
                    lblSoftwareOpen.Text = dtSoftwareOpen.Rows(0)("SoftwareOpen").ToString
                End If

                'InProcess
                Dim dtSoftwareInProcess As DataTable = objBL.GetComSoftwareInProcess
                If dtSoftwareInProcess.Rows.Count > 0 Then
                    lblSoftInProc.Text = dtSoftwareInProcess.Rows(0)("SoftwareInProcess").ToString
                End If

                'Pending
                Dim dtSoftwarePending As DataTable = objBL.GetComSoftwarePending
                If dtSoftwarePending.Rows.Count > 0 Then
                    lblSoftPending.Text = dtSoftwarePending.Rows(0)("SoftwarePending").ToString
                End If

                'Solved
                Dim dtSoftwareSolved As DataTable = objBL.GetComSoftwareSolved
                If dtSoftwareSolved.Rows.Count > 0 Then
                    lblSoftSolved.Text = dtSoftwareSolved.Rows(0)("SoftwareSolved").ToString
                End If

                'Solved
                Dim dtSoftwareClosed As DataTable = objBL.GetComSoftwareClosed
                If dtSoftwareClosed.Rows.Count > 0 Then
                    lblSoftClosed.Text = dtSoftwareClosed.Rows(0)("SoftwareClosed").ToString
                End If



                '---------Network-----------
                Dim dtNetwork As DataTable = objBL.GetNetwork
                If dtNetwork.Rows.Count > 0 Then
                    lblNetwork.Text = dtNetwork.Rows(0)("Network").ToString
                End If

                'Open
                Dim dtNetworkOpen As DataTable = objBL.GetNetworkOpen
                If dtNetworkOpen.Rows.Count > 0 Then
                    lblNetworkOpen.Text = dtNetworkOpen.Rows(0)("NetworkOpen").ToString
                End If

                'InProcess
                Dim dtNetworkInProcess As DataTable = objBL.GetNetworkInProcess
                If dtNetworkInProcess.Rows.Count > 0 Then
                    lblNetInProcess.Text = dtNetworkInProcess.Rows(0)("NetworkInProcess").ToString
                End If


                'Pending
                Dim dtNetworkPending As DataTable = objBL.GetNetworkPending
                If dtNetworkPending.Rows.Count > 0 Then
                    lblNetPending.Text = dtNetworkPending.Rows(0)("NetworkPending").ToString
                End If

                'Solved
                Dim dtNetworkSolved As DataTable = objBL.GetNetworkSolved
                If dtNetworkSolved.Rows.Count > 0 Then
                    lblNetSolved.Text = dtNetworkSolved.Rows(0)("NetworkSolved").ToString
                End If

                'Closed
                Dim dtNetworkClosed As DataTable = objBL.GetNetworkClosed
                If dtNetworkClosed.Rows.Count > 0 Then
                    lblNetClosed.Text = dtNetworkClosed.Rows(0)("NetworkClosed").ToString
                End If


            End If

        Catch ex As Exception

        End Try
    End Sub

End Class