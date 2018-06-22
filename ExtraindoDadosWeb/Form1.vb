Imports System
Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text

Public Class Form1
    Private Sub btnObterPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObterPagina.Click
        Try
            Dim wc As New Web
            txtDados.Text = wc.RequestDadosWeb(txtUrl.Text.Trim)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnImagem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem1.Click
        Dim strArquivo As String
        Dim wc As New Web
        strArquivo = wc.RequestImagemWeb(TextBoxUrl.Text.ToString(), "maco1b.gif")
        PictureBox1.Image = Image.FromFile(strArquivo)
    End Sub
    Private Sub btnImagem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem2.Click
        Dim strArquivo As String
        Dim wc As New Web
        strArquivo = wc.RequestImagemWeb(TextBoxUrl.Text.ToString(), "dvdnet2.gif")
        PictureBox2.Image = Image.FromFile(strArquivo)
    End Sub

    Private Sub btnLinks_Click(sender As System.Object, e As System.EventArgs) Handles btnLinks.Click
        Dim wc As New Web
        dgvDados.DataSource = wc.ExtrairLinks(txtLinks.Text.Trim)
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try



            Dim request As WebRequest = WebRequest.Create(TextBoxUrl.Text.ToString())

            Dim wp As WebProxy = New WebProxy(TextBoxProxy.Text.ToString(), Convert.ToInt32(TextBoxPorta.Text))

            wp.Credentials = New NetworkCredential(TextBox2.Text.ToString(), TextBoxPass.Text.ToString())
            request.Proxy = wp
            request.Method = "POST"
            Dim postData As String = "Isso é um teste de post em um de uma string em um Web server."
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Erro" + ex.ToString())


        End Try
    End Sub
End Class
