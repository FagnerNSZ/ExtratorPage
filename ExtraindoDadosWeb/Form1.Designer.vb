<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnObterPagina = New System.Windows.Forms.Button()
        Me.txtDados = New System.Windows.Forms.TextBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnImagem1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnImagem2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLinks = New System.Windows.Forms.Button()
        Me.txtLinks = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxProxy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.TextBoxPorta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Url = New System.Windows.Forms.Label()
        Me.TextBoxUrl = New System.Windows.Forms.TextBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnObterPagina
        '
        Me.btnObterPagina.Location = New System.Drawing.Point(14, 216)
        Me.btnObterPagina.Name = "btnObterPagina"
        Me.btnObterPagina.Size = New System.Drawing.Size(105, 23)
        Me.btnObterPagina.TabIndex = 0
        Me.btnObterPagina.Text = "Obter Página"
        Me.btnObterPagina.UseVisualStyleBackColor = True
        '
        'txtDados
        '
        Me.txtDados.Location = New System.Drawing.Point(13, 13)
        Me.txtDados.Multiline = True
        Me.txtDados.Name = "txtDados"
        Me.txtDados.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDados.Size = New System.Drawing.Size(601, 186)
        Me.txtDados.TabIndex = 1
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrl.Location = New System.Drawing.Point(138, 218)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(476, 20)
        Me.txtUrl.TabIndex = 2
        '
        'dgvDados
        '
        Me.dgvDados.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(13, 267)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(601, 85)
        Me.dgvDados.TabIndex = 3
        '
        'btnImagem1
        '
        Me.btnImagem1.Location = New System.Drawing.Point(12, 368)
        Me.btnImagem1.Name = "btnImagem1"
        Me.btnImagem1.Size = New System.Drawing.Size(98, 23)
        Me.btnImagem1.TabIndex = 4
        Me.btnImagem1.Text = "Obter Imagem"
        Me.btnImagem1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(116, 368)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 37)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnImagem2
        '
        Me.btnImagem2.Location = New System.Drawing.Point(14, 411)
        Me.btnImagem2.Name = "btnImagem2"
        Me.btnImagem2.Size = New System.Drawing.Size(97, 23)
        Me.btnImagem2.TabIndex = 6
        Me.btnImagem2.Text = "Obter Imagem"
        Me.btnImagem2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(116, 411)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(498, 35)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnLinks
        '
        Me.btnLinks.Location = New System.Drawing.Point(14, 238)
        Me.btnLinks.Name = "btnLinks"
        Me.btnLinks.Size = New System.Drawing.Size(105, 23)
        Me.btnLinks.TabIndex = 8
        Me.btnLinks.Text = "Obter Links"
        Me.btnLinks.UseVisualStyleBackColor = True
        '
        'txtLinks
        '
        Me.txtLinks.BackColor = System.Drawing.SystemColors.Menu
        Me.txtLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLinks.Location = New System.Drawing.Point(138, 238)
        Me.txtLinks.Name = "txtLinks"
        Me.txtLinks.Size = New System.Drawing.Size(476, 20)
        Me.txtLinks.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Dispara Acesso via Proxy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxProxy
        '
        Me.TextBoxProxy.Location = New System.Drawing.Point(410, 473)
        Me.TextBoxProxy.Name = "TextBoxProxy"
        Me.TextBoxProxy.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxProxy.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Proxy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "User"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(28, 523)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 507)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Pass"
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(243, 523)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxPass.TabIndex = 15
        '
        'TextBoxPorta
        '
        Me.TextBoxPorta.Location = New System.Drawing.Point(543, 473)
        Me.TextBoxPorta.Name = "TextBoxPorta"
        Me.TextBoxPorta.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxPorta.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(540, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Porta"
        '
        'Url
        '
        Me.Url.AutoSize = True
        Me.Url.Location = New System.Drawing.Point(21, 455)
        Me.Url.Name = "Url"
        Me.Url.Size = New System.Drawing.Size(20, 13)
        Me.Url.TabIndex = 20
        Me.Url.Text = "Url"
        '
        'TextBoxUrl
        '
        Me.TextBoxUrl.Location = New System.Drawing.Point(24, 473)
        Me.TextBoxUrl.Name = "TextBoxUrl"
        Me.TextBoxUrl.Size = New System.Drawing.Size(365, 20)
        Me.TextBoxUrl.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(630, 555)
        Me.Controls.Add(Me.Url)
        Me.Controls.Add(Me.TextBoxUrl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPorta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxProxy)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLinks)
        Me.Controls.Add(Me.btnLinks)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnImagem2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImagem1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtDados)
        Me.Controls.Add(Me.btnObterPagina)
        Me.Name = "Form1"
        Me.Text = "HttpRequest"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnObterPagina As System.Windows.Forms.Button
    Friend WithEvents txtDados As System.Windows.Forms.TextBox
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents btnImagem1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImagem2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLinks As System.Windows.Forms.Button
    Friend WithEvents txtLinks As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxProxy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxPorta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Url As Label
    Friend WithEvents TextBoxUrl As TextBox
End Class
