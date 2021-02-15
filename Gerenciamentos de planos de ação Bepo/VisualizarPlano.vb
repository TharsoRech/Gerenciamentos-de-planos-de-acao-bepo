Imports System.IO
Imports MetroFramework
Imports SelectPdf

Public Class VisualizarPlano
    Public Title As String = ""
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            SaveFileDialog1.Filter = "PDF (.pdf)|*.pdf;"
            SaveFileDialog1.FileName = Title
            If SaveFileDialog1.ShowDialog <> DialogResult.Cancel Then
                exporttopdf(IO.Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName) & ".pdf")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub exporttopdf(ByVal filename As String)
        Try

            Dim converter As New HtmlToPdf()

            converter.Options.MaxPageLoadTime = 120
            converter.Options.PdfPageSize = PdfPageSize.A4
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait
            converter.Options.MarginLeft = 10
            converter.Options.MarginRight = 10
            converter.Options.MarginTop = 20
            converter.Options.MarginBottom = 20


            Dim doc As SelectPdf.PdfDocument = converter.ConvertHtmlString(WebBrowser1.DocumentText, "")

            Dim stream As New MemoryStream()
            doc.Save(filename)
            Process.Start(filename)
            Dim pdfBytes = stream.ToArray()
            stream.Close()
            doc.Close()
            ' ConvertHTMLToPDF(WebBrowser1.DocumentText, "teste.pdf")
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error na conversão do pdf verifique com administrador do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim antigohtml As String = WebBrowser1.DocumentText
            WebBrowser1.DocumentText = WebBrowser1.DocumentText & " <div style=""position:absolute; bottom:0; widht:100; ""><h3>Report gerado em:" & DateAndTime.Now.ToString & Space(2) & "pelo usuário:" & Form1.currentuser.user & "</h3><img src = ""\\vmsmd37\PlanosDeAção\bepo.png""  style=""width:200px;height:100px;""></div>"
            While WebBrowser1.ReadyState = WebBrowserReadyState.Loading
                Application.DoEvents()
            End While
            WebBrowser1.ShowPrintPreviewDialog()
                WebBrowser1.DocumentText = antigohtml
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VisualizarPlano_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class