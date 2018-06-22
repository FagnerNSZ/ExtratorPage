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
        strArquivo = wc.RequestImagemWeb("http://brvix5valedb020.valenet.valeglobal.net:8023/bi_prd/modulos/validate/default_remedy.asp", "maco1b.gif")
        PictureBox1.Image = Image.FromFile(strArquivo)
    End Sub
    Private Sub btnImagem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem2.Click
        Dim strArquivo As String
        Dim wc As New Web
        strArquivo = wc.RequestImagemWeb("http://brvix5valedb020.valenet.valeglobal.net:8023/bi_prd/modulos/validate/default_remedy.asp", "dvdnet2.gif")
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



            Dim request As WebRequest = WebRequest.Create("http://brvix5valedb020.valenet.valeglobal.net:8023/bi_prd/modulos/validate/default_remedy.asp")
            'http://brvix5valecac003.valenet.valeglobal.net

            Dim wp As WebProxy = New WebProxy(TextBox1.Text.ToString(), Convert.ToInt32(TextBox4.Text))

            wp.Credentials = New NetworkCredential(TextBox2.Text.ToString(), TextBox3.Text.ToString())
            request.Proxy = wp

            ' Set the Method property of the request to POST.
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.
            Dim postData As String = "Isso é um teste de post em um de uma string em um Web server."
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length
            ' Get the request stream.
            Dim dataStream As Stream = request.GetRequestStream()
            ' Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.
            dataStream.Close()
            ' Get the response.
            Dim response As WebResponse = request.GetResponse()
            ' Display the status.
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            ' Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.
            Dim reader As New StreamReader(dataStream)
            ' Read the content.
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.
            Console.WriteLine(responseFromServer)
            ' Clean up the streams.
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Erro" + ex.ToString())


        End Try
    End Sub
End Class
