<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DirListBox1
        '
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(12, 61)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(247, 297)
        Me.DirListBox1.TabIndex = 0
        '
        'DriveListBox1
        '
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(12, 22)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(485, 23)
        Me.DriveListBox1.TabIndex = 1
        '
        'FileListBox1
        '
        Me.FileListBox1.FormattingEnabled = True
        Me.FileListBox1.Location = New System.Drawing.Point(276, 61)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.Size = New System.Drawing.Size(221, 260)
        Me.FileListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Закрыть"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 370)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileListBox1)
        Me.Controls.Add(Me.DriveListBox1)
        Me.Controls.Add(Me.DirListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirListBox1 As Compatibility.VB6.DirListBox
    Friend WithEvents DriveListBox1 As Compatibility.VB6.DriveListBox
    Friend WithEvents FileListBox1 As Compatibility.VB6.FileListBox
    Friend WithEvents Button1 As Button
End Class
