<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОткрытьВторуюФормуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗакрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьВторуюФормуToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьВторуюФормуToolStripMenuItem1, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьВторуюФормуToolStripMenuItem, Me.ЗакрытьToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(242, 80)
        '
        'ОткрытьВторуюФормуToolStripMenuItem
        '
        Me.ОткрытьВторуюФормуToolStripMenuItem.Name = "ОткрытьВторуюФормуToolStripMenuItem"
        Me.ОткрытьВторуюФормуToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.ОткрытьВторуюФормуToolStripMenuItem.Text = "Открыть вторую форму"
        '
        'ЗакрытьToolStripMenuItem
        '
        Me.ЗакрытьToolStripMenuItem.Name = "ЗакрытьToolStripMenuItem"
        Me.ЗакрытьToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.ЗакрытьToolStripMenuItem.Text = "Закрыть"
        '
        'ОткрытьВторуюФормуToolStripMenuItem1
        '
        Me.ОткрытьВторуюФормуToolStripMenuItem1.Name = "ОткрытьВторуюФормуToolStripMenuItem1"
        Me.ОткрытьВторуюФормуToolStripMenuItem1.Size = New System.Drawing.Size(186, 24)
        Me.ОткрытьВторуюФормуToolStripMenuItem1.Text = "Открыть вторую форму"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 276)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ОткрытьВторуюФормуToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ОткрытьВторуюФормуToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗакрытьToolStripMenuItem As ToolStripMenuItem
End Class
