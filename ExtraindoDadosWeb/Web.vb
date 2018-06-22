Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Data

Public Class Web

    Public Function ExtrairLinks(ByVal url As String) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("LinkTexto")
        dt.Columns.Add("LinkUrl")

        Dim wc As New WebClient
        Dim html As String = wc.DownloadString(url)

        Dim links As MatchCollection = Regex.Matches(html, "<a.*?href=""(.*?)"".*?>(.*?)</a>")

        For Each match As Match In links
            Dim dr As DataRow = dt.NewRow
            Dim matchUrl As String = match.Groups(1).Value
            'Ignora todos os links âncoras
            If matchUrl.StartsWith("#") Then
                Continue For
            End If
            'Ignora todas as chamadas javascript
            If matchUrl.ToLower.StartsWith("javascript:") Then
                Continue For
            End If
            'Ignora todos os links de email
            If matchUrl.ToLower.StartsWith("mailto:") Then
                Continue For
            End If
            'Para links internos, constroi a url mapeada para o endereço base
            If Not matchUrl.StartsWith("http://") And Not matchUrl.StartsWith("https://") Then
                matchUrl = MapearUrl(url, matchUrl)
            End If
            'Inclui o link no datatable
            dr("LinkUrl") = matchUrl
            dr("LinkTexto") = match.Groups(2).Value
            dt.Rows.Add(dr)
        Next

        Return dt
    End Function
    Public Function MapearUrl(ByVal enderecoBase As String, ByVal caminhoRelativo As String) As String

        Dim u As New System.Uri(enderecoBase)

        If caminhoRelativo = "./" Then
            caminhoRelativo = "/"
        End If

        If caminhoRelativo.StartsWith("/") Then
            Return u.Scheme + Uri.SchemeDelimiter + u.Authority + caminhoRelativo
        Else
            Dim Caminho_Consulta As String = u.AbsolutePath
            ' Se o enderecoBase contem o nome do arquivo como ..../Something.aspx
            ' ajusta o nome do arquivo
            Caminho_Consulta = Caminho_Consulta.Split("?")(0).TrimEnd("/")
            If Caminho_Consulta.Split("/")(Caminho_Consulta.Split("/").Count - 1).Contains(".") Then
                Caminho_Consulta = Caminho_Consulta.Substring(0, Caminho_Consulta.LastIndexOf("/"))
            End If
            enderecoBase = u.Scheme + Uri.SchemeDelimiter + u.Authority + Caminho_Consulta

            'se o caminhoRelativo contém ../ então
            ' ajusa o enderecoBase

            While caminhoRelativo.StartsWith("../")
                caminhoRelativo = caminhoRelativo.Substring(3)
                If enderecoBase.LastIndexOf("/") > enderecoBase.IndexOf("//" + 2) Then
                    enderecoBase = enderecoBase.Substring(0, enderecoBase.LastIndexOf("/")).TrimEnd("/")
                End If
            End While

            Return enderecoBase + "/" + caminhoRelativo
        End If

    End Function
    Public Function RequestImagemWeb(ByVal pstrURL As String, ByVal imagem As String) As String
        Dim oWebRequest As WebRequest
        Dim oWebResponse As WebResponse

        'conecta com o website
        oWebRequest = HttpWebRequest.Create(pstrURL)
        oWebResponse = oWebRequest.GetResponse()

        'Le a resposta do website e armazena em uma stream
        Dim objStream As Stream
        objStream = oWebResponse.GetResponseStream
        Dim inBuf(100000) As Byte
        Dim bytesToRead As Integer = CInt(inBuf.Length)
        Dim bytesRead As Integer = 0
        While bytesToRead > 0
            Dim n As Integer = objStream.Read(inBuf, bytesRead, bytesToRead)
            If n = 0 Then
                Exit While
            End If
            bytesRead += n
            bytesToRead -= n
        End While
        Dim fstr As New FileStream(imagem, FileMode.OpenOrCreate, FileAccess.Write)
        fstr.Write(inBuf, 0, bytesRead)
        objStream.Close()
        fstr.Close()

        oWebResponse.Close()
        'retorna a imagem
        Return imagem
    End Function

    Public Function GetQuoteLatest(ByVal pstrSymbol As String) As String
        Dim strURL As String
        Dim strBuffer As String
        'cria uma requisição URL para o Yahoo
        strURL = "http://quote.yahoo.com/d/quotes.csv?" & _
                 "s=" & pstrSymbol & _
                 "&d=t" & _
                 "&f=sl1d1t1c1ohgvj1pp2wern"

        strBuffer = RequestDadosWeb(strURL)

        'percore as linhas retornadas 
        Dim strReturn As New System.Text.StringBuilder
        strReturn.Append("" & Environment.NewLine)
        'percorre as linhas obtidas
        For Each strLine As String In strBuffer.Split(ControlChars.Lf)
            If strLine.Length > 0 Then
                strReturn.Append(TransformLatestLine(strLine) & Environment.NewLine)
            End If
        Next
        'retorna
        strReturn.Append("" & Environment.NewLine)

        Return strReturn.ToString
    End Function
    Private Function TransformLatestLine(ByVal pstrLine As String) As String
        Dim arrLine() As String
        Dim strXML As New System.Text.StringBuilder

        arrLine = pstrLine.Split(","c)

        strXML.Append("")
        strXML.Append("" & arrLine(0).Replace(Chr(34), "") & "")
        strXML.Append("" & arrLine(1) & "")
        strXML.Append("" & arrLine(2).Replace(Chr(34), "") & "")
        strXML.Append("" & arrLine(3).Replace(Chr(34), "") & "")
        strXML.Append("" & arrLine(4) & "")
        strXML.Append("" & arrLine(5) & "")
        strXML.Append("" & arrLine(6) & "")
        strXML.Append("" & arrLine(7) & "")
        strXML.Append("" & arrLine(8) & "")
        strXML.Append("" & arrLine(9) & "")
        strXML.Append("" & arrLine(10) & "")
        strXML.Append("" & arrLine(11).Replace(Chr(34), "") & "")
        strXML.Append("" & arrLine(12).Replace(Chr(34), "") & "")
        strXML.Append("" & arrLine(13) & "")
        strXML.Append("" & arrLine(14) & "")
        strXML.Append("" & arrLine(15).Replace(Chr(34), "") & "")
        strXML.Append("")
        Return strXML.ToString
    End Function
    Public Function RequestDadosWeb(ByVal pstrURL As String) As String
        Dim oWebRequest As WebRequest
        Dim oWebResponse As WebResponse = Nothing
        Dim strBuffer As String = ""
        Dim objSR As StreamReader = Nothing
        'conecta com o website
        Try
            oWebRequest = HttpWebRequest.Create(pstrURL)

            oWebRequest.Proxy = New WebProxy("cache.bb.com.br", 8080)
            Dim wp As WebProxy = New WebProxy("cache.bb.com.br", 8080)
            wp.Credentials = New NetworkCredential("f5361091", "5", "cache.bb.com.br")

            oWebResponse = oWebRequest.GetResponse()
            'Le a resposta do web site e armazena em uma stream
            objSR = New StreamReader(oWebResponse.GetResponseStream)
            strBuffer = objSR.ReadToEnd
        Catch ex As Exception
            Throw ex
        Finally
            objSR.Close()
            oWebResponse.Close()
        End Try
        Return strBuffer
    End Function
    Public Function GetPaginaComoString(ByVal address As Uri) As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim resultado As String

        Try
            ' Cria um webrequest
            request = DirectCast(WebRequest.Create(address), HttpWebRequest)

            ' pega o response
            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' pega o response em um stream
            reader = New StreamReader(response.GetResponseStream())

            ' le todo o conteudo e retorna uma string
            resultado = reader.ReadToEnd()
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

        Return resultado

    End Function

    'Resultado: configurar o proxy no HttpWebRequest.

    'HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://site.com.br");
    'req.Proxy = new WebProxy("proxy.uri.com.br", "8080");
    'Simples não? Basta configurar a propriedade Proxy do objeto HttpWebRequest com um objeto WebProxy.

    'O WebProxy permite ainda configurar as credenciais que devem ser utilizadas, é bastante simples:
    'var webproxy = new WebProxy("proxy.uri.com.br", "8080");
    'webProxy.Credentials = new NetworkCredential("usuario","senha","domain");
    'É isso, foi só liberar essa configuração e tudo funcionou perfeitamente.

End Class
