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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnObterPagina
        '
        Me.btnObterPagina.Location = New System.Drawing.Point(14, 269)
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
        Me.txtDados.Size = New System.Drawing.Size(601, 252)
        Me.txtDados.TabIndex = 1
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrl.Location = New System.Drawing.Point(138, 271)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(476, 20)
        Me.txtUrl.TabIndex = 2
        Me.txtUrl.Text = "http://brvix5valedb020.valenet.valeglobal.net:8023/bi_prd/modulos/validate/defaul" &
    "t_remedy.asp"
        '
        'dgvDados
        '
        Me.dgvDados.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(13, 320)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(601, 138)
        Me.dgvDados.TabIndex = 3
        '
        'btnImagem1
        '
        Me.btnImagem1.Location = New System.Drawing.Point(12, 465)
        Me.btnImagem1.Name = "btnImagem1"
        Me.btnImagem1.Size = New System.Drawing.Size(98, 23)
        Me.btnImagem1.TabIndex = 4
        Me.btnImagem1.Text = "Obter Imagem"
        Me.btnImagem1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(116, 465)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 37)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnImagem2
        '
        Me.btnImagem2.Location = New System.Drawing.Point(14, 508)
        Me.btnImagem2.Name = "btnImagem2"
        Me.btnImagem2.Size = New System.Drawing.Size(97, 23)
        Me.btnImagem2.TabIndex = 6
        Me.btnImagem2.Text = "Obter Imagem"
        Me.btnImagem2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(116, 508)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(498, 35)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnLinks
        '
        Me.btnLinks.Location = New System.Drawing.Point(14, 291)
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
        Me.txtLinks.Location = New System.Drawing.Point(138, 291)
        Me.txtLinks.Name = "txtLinks"
        Me.txtLinks.Size = New System.Drawing.Size(476, 20)
        Me.txtLinks.TabIndex = 9
        Me.txtLinks.Text = "http://brvix5valedb020.valenet.valeglobal.net:8023/bi_prd/modulos/validate/defaul" &
    "t_remedy.asp"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 647)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Dispara Acesso via Proxy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 576)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 559)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Proxy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 606)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "User"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 622)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 606)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Pass"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(249, 622)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 20)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(249, 576)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 20)
        Me.TextBox4.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 559)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Porta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(630, 673)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Text = "Usando HttpWebRequest"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
