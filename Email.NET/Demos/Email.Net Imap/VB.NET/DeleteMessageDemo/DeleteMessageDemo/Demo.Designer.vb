Partial Class Demo
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region ""

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.messageList = New System.Windows.Forms.ListBox()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.startAuthorization = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.interactionCombo = New System.Windows.Forms.ComboBox()
        Me.client = New Email.Net.Imap.ImapClient(Me.components)
        Me.delete = New System.Windows.Forms.Button()
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' messageList
        ' 
        Me.messageList.HorizontalScrollbar = True
        Me.messageList.Location = New System.Drawing.Point(290, 27)
        Me.messageList.Name = "messageList"
        Me.messageList.Size = New System.Drawing.Size(281, 173)
        Me.messageList.TabIndex = 8
        AddHandler Me.messageList.SelectedIndexChanged, New System.EventHandler(AddressOf Me.messageList_SelectedIndexChanged)
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(118, 53)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 4
        Me.portNum.Value = New Decimal(New Integer() {993, 0, 0, 0})
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(10, 140)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 13)
        Me.label5.TabIndex = 52
        Me.label5.Text = "Interaction type:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(118, 105)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 6
        Me.passwordBox.Text = ""
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(118, 79)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 5
        Me.loginBox.Text = "mail@someserver.com"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(118, 27)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 3
        Me.hostBox.Text = "imap.someserver.com"
        ' 
        ' startAuthorization
        ' 
        Me.startAuthorization.Location = New System.Drawing.Point(18, 188)
        Me.startAuthorization.Name = "startAuthorization"
        Me.startAuthorization.Size = New System.Drawing.Size(75, 23)
        Me.startAuthorization.TabIndex = 0
        Me.startAuthorization.Text = "Start"
        Me.startAuthorization.UseVisualStyleBackColor = True
        AddHandler Me.startAuthorization.Click, New System.EventHandler(AddressOf Me.startAuthorization_Click)
        ' 
        ' close
        ' 
        Me.close.Location = New System.Drawing.Point(209, 188)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(75, 23)
        Me.close.TabIndex = 2
        Me.close.Text = "Finish"
        Me.close.UseVisualStyleBackColor = True
        AddHandler Me.close.Click, New System.EventHandler(AddressOf Me.close_Click)
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(10, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 50
        Me.label3.Text = "Login:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 49
        Me.label2.Text = "Port:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(10, 113)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 51
        Me.label4.Text = "Password:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 48
        Me.label1.Text = "Host:"
        ' 
        ' interactionCombo
        ' 
        Me.interactionCombo.FormattingEnabled = True
        Me.interactionCombo.Items.AddRange(New Object() {"Plain", "SSLPort", "StartTLs"})
        Me.interactionCombo.Location = New System.Drawing.Point(118, 137)
        Me.interactionCombo.Name = "interactionCombo"
        Me.interactionCombo.Size = New System.Drawing.Size(150, 21)
        Me.interactionCombo.TabIndex = 7
        ' 
        ' client
        ' 
        Me.client.Host = "localhost"
        Me.client.Password = "Password"
        Me.client.Port = CUShort(25)
        Me.client.ProxyPort = CUShort(0)
        Me.client.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.client.ReceiveTimeout = 100000
        Me.client.SendTimeout = 100000
        Me.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.client.Username = "Login"
        ' 
        ' delete
        ' 
        Me.delete.Location = New System.Drawing.Point(108, 188)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 1
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        AddHandler Me.delete.Click, New System.EventHandler(AddressOf Me.delete_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 218)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.messageList)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.loginBox)
        Me.Controls.Add(Me.hostBox)
        Me.Controls.Add(Me.startAuthorization)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.interactionCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET Delete Message Example"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private messageList As System.Windows.Forms.ListBox
    Private portNum As System.Windows.Forms.NumericUpDown
    Private label5 As System.Windows.Forms.Label
    Private passwordBox As System.Windows.Forms.TextBox
    Private loginBox As System.Windows.Forms.TextBox
    Private hostBox As System.Windows.Forms.TextBox
    Private startAuthorization As System.Windows.Forms.Button
    Private close As System.Windows.Forms.Button
    Private label3 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private interactionCombo As System.Windows.Forms.ComboBox
    Private client As Email.Net.Imap.ImapClient
    Private delete As System.Windows.Forms.Button
End Class
