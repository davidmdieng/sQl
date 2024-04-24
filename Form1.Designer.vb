<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btncall = New Button()
        btnVariables = New Button()
        btndat_type = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Button1 = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        lblLastName = New Label()
        txtboxLastName = New TextBox()
        textGender = New TextBox()
        lblGender = New Label()
        lstOccupation = New ListBox()
        lblOccupuation = New Label()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btncall
        ' 
        btncall.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btncall.Location = New Point(68, 65)
        btncall.Name = "btncall"
        btncall.Size = New Size(309, 136)
        btncall.TabIndex = 0
        btncall.Text = "Press Here"
        btncall.UseVisualStyleBackColor = False
        ' 
        ' btnVariables
        ' 
        btnVariables.Location = New Point(471, 65)
        btnVariables.Name = "btnVariables"
        btnVariables.Size = New Size(275, 136)
        btnVariables.TabIndex = 1
        btnVariables.Text = "Variable Demonstration"
        btnVariables.UseVisualStyleBackColor = True
        ' 
        ' btndat_type
        ' 
        btndat_type.Location = New Point(68, 281)
        btndat_type.Name = "btndat_type"
        btndat_type.Size = New Size(309, 131)
        btndat_type.TabIndex = 2
        btndat_type.Text = "Data Type"
        btndat_type.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(429, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(359, 184)
        Button1.TabIndex = 3
        Button1.Text = "Go"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(935, 32)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(258, 31)
        txtFirstName.TabIndex = 4
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(836, 35)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(102, 25)
        lblFirstName.TabIndex = 5
        lblFirstName.Text = "First Name "
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(836, 92)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 25)
        lblLastName.TabIndex = 6
        lblLastName.Text = "Last Name"
        ' 
        ' txtboxLastName
        ' 
        txtboxLastName.Location = New Point(935, 89)
        txtboxLastName.Name = "txtboxLastName"
        txtboxLastName.Size = New Size(258, 31)
        txtboxLastName.TabIndex = 7
        ' 
        ' textGender
        ' 
        textGender.Location = New Point(935, 151)
        textGender.Name = "textGender"
        textGender.Size = New Size(129, 31)
        textGender.TabIndex = 8
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(836, 154)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 9
        lblGender.Text = "Gender"
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 25
        lstOccupation.Items.AddRange(New Object() {"""Doctor""", """Pilot""", """Soccer Player"""})
        lstOccupation.Location = New Point(1367, 89)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(180, 129)
        lstOccupation.TabIndex = 10
        ' 
        ' lblOccupuation
        ' 
        lblOccupuation.AutoSize = True
        lblOccupuation.Location = New Point(1403, 51)
        lblOccupuation.Name = "lblOccupuation"
        lblOccupuation.Size = New Size(103, 25)
        lblOccupuation.TabIndex = 11
        lblOccupuation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1677, 782)
        Controls.Add(lblOccupuation)
        Controls.Add(lstOccupation)
        Controls.Add(lblGender)
        Controls.Add(textGender)
        Controls.Add(txtboxLastName)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(Button1)
        Controls.Add(btndat_type)
        Controls.Add(btnVariables)
        Controls.Add(btncall)
        Name = "Form1"
        Text = "Form1"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btncall As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btndat_type As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents textGender As TextBox
    Friend WithEvents txtboxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupuation As Label

End Class
