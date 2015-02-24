﻿Imports System.Windows.Forms

Public Class ResolveTicket

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        'Check that all of the info has been entered

        If txtTicketResolution.Text = "" Then
            MessageBox.Show("Please enter a resolution")
            Return
        End If

        Dim ticketToResolve As Ticket = CType(Tag, Ticket)
        ticketToResolve.Resolution = txtTicketResolution.Text
        ticketToResolve.DateResolved = dtpResolveDate.Value
        Me.Tag = ticketToResolve


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ResolveTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Suggested resolve date is now
        dtpResolveDate.Value = Date.Now
        'Display ticket information for the user
        'Tag is a property of every form
        'It can store any object. It is often used to send
        'an object from one form to another
        lblTicketInfo.Text = Tag.ToString
        'Clear the text box
        txtTicketResolution.Text = ""

    End Sub
End Class
