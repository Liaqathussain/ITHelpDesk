Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblComplainDate.Text = Date.Now.ToShortDateString
        lblPriority.Text = Session("Priority")
        lblRequestType.Text = Session("ReqType")
        lblStatusName.Text = "Open"
        lblTicketNo.Text = Session("TicketNo")
        Dim time As DateTime = DateTime.Now.TimeOfDay.ToString
        lblDuration.Text = Format(time, "hh:mm:ss")
        lblStatus.Text = "Thank you for using Help Desk"
    End Sub

End Class