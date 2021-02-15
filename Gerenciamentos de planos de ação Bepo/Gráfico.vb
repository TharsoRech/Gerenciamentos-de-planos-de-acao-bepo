Imports System.IO
Imports MetroFramework
Imports SelectPdf

Public Class Gráfico
    Private Sub Gráfico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ppd As PrintPreviewDialog = New PrintPreviewDialog
            ppd.Document = Chart1.Printing.PrintDocument
            ppd.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub


End Class