<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApps))
        Me.ListApps = New System.Windows.Forms.ListBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListApps
        '
        Me.ListApps.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListApps.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListApps.FormattingEnabled = True
        Me.ListApps.ItemHeight = 24
        Me.ListApps.Location = New System.Drawing.Point(44, 94)
        Me.ListApps.Name = "ListApps"
        Me.ListApps.Size = New System.Drawing.Size(419, 316)
        Me.ListApps.TabIndex = 3
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(507, 94)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(106, 46)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(507, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 46)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Orange
        Me.btnUpdate.Location = New System.Drawing.Point(507, 226)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 46)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(507, 298)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 46)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(507, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 46)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 54)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "List of Application"
        '
        'FormApps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.Lab_Task_3.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(675, 505)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.ListApps)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormApps"
        Me.Text = "App Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListApps As ListBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
