<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ControlButton = New System.Windows.Forms.Button()
        Me.TipText = New System.Windows.Forms.Label()
        Me.TimeTrackBar = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer_Minute = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Second = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TimeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlButton
        '
        Me.ControlButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ControlButton.Location = New System.Drawing.Point(78, 191)
        Me.ControlButton.MaximumSize = New System.Drawing.Size(100, 40)
        Me.ControlButton.Name = "ControlButton"
        Me.ControlButton.Size = New System.Drawing.Size(100, 30)
        Me.ControlButton.TabIndex = 0
        Me.ControlButton.Text = "定时"
        Me.ControlButton.UseVisualStyleBackColor = True
        '
        'TipText
        '
        Me.TipText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TipText.AutoSize = True
        Me.TipText.Location = New System.Drawing.Point(83, 129)
        Me.TipText.Margin = New System.Windows.Forms.Padding(0)
        Me.TipText.Name = "TipText"
        Me.TipText.Size = New System.Drawing.Size(89, 12)
        Me.TipText.TabIndex = 1
        Me.TipText.Text = "30分钟后将关机"
        '
        'TimeTrackBar
        '
        Me.TimeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimeTrackBar.Location = New System.Drawing.Point(3, 80)
        Me.TimeTrackBar.Margin = New System.Windows.Forms.Padding(3, 80, 3, 3)
        Me.TimeTrackBar.Maximum = 120
        Me.TimeTrackBar.Minimum = 1
        Me.TimeTrackBar.Name = "TimeTrackBar"
        Me.TimeTrackBar.Size = New System.Drawing.Size(250, 45)
        Me.TimeTrackBar.TabIndex = 2
        Me.TimeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TimeTrackBar.Value = 30
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TimeTrackBar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TipText, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ControlButton, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 233)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Timer_Minute
        '
        Me.Timer_Minute.Interval = 60000
        '
        'Timer_Second
        '
        Me.Timer_Second.Interval = 1000
        '
        'MainForm
        '
        Me.AcceptButton = Me.ControlButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "定时关机"
        CType(Me.TimeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlButton As Button
    Friend WithEvents TipText As Label
    Friend WithEvents TimeTrackBar As TrackBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Timer_Minute As Timer
    Friend WithEvents Timer_Second As Timer
End Class
