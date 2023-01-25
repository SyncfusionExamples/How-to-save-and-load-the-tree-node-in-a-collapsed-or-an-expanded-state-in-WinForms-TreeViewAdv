Imports Microsoft.VisualBasic
Imports System
Namespace TreeSearch
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim treeNodeAdv1 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv2 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv3 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv4 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv5 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv6 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv7 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv8 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv9 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv10 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv11 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv12 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv13 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv14 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv15 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.grid = New System.Windows.Forms.GroupBox()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grid.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' treeViewAdv1
			' 
			Me.treeViewAdv1.BackColor = System.Drawing.Color.White
			Me.treeViewAdv1.BeforeTouchSize = New System.Drawing.Size(214, 304)
			Me.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.treeViewAdv1.BorderColor = System.Drawing.Color.LightGray
			Me.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.CanSelectDisabledNode = False
			Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' 
			' 
			Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.HelpTextControl.Name = "helpText"
			Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv1.HelpTextControl.TabIndex = 0
			Me.treeViewAdv1.HelpTextControl.Text = "help text"
			Me.treeViewAdv1.Location = New System.Drawing.Point(3, 19)
			Me.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.treeViewAdv1.Name = "treeViewAdv1"
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv1.EnsureDefaultOptionedChild = True
			treeNodeAdv1.Expanded = True
			treeNodeAdv1.MultiLine = True
			treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv2.EnsureDefaultOptionedChild = True
			treeNodeAdv2.Expanded = True
			treeNodeAdv2.MultiLine = True
			treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv3.EnsureDefaultOptionedChild = True
			treeNodeAdv3.MultiLine = True
			treeNodeAdv3.Optioned = True
			treeNodeAdv3.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv3.ShowLine = True
			treeNodeAdv3.Text = "Sample"
			treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv4.EnsureDefaultOptionedChild = True
			treeNodeAdv4.MultiLine = True
			treeNodeAdv4.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv4.ShowLine = True
			treeNodeAdv4.Text = "admin"
			treeNodeAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv3, treeNodeAdv4})
			treeNodeAdv2.Optioned = True
			treeNodeAdv2.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv2.ShowLine = True
			treeNodeAdv2.Text = "Admin"
			treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv5.EnsureDefaultOptionedChild = True
			treeNodeAdv5.Expanded = True
			treeNodeAdv5.MultiLine = True
			treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv6.EnsureDefaultOptionedChild = True
			treeNodeAdv6.MultiLine = True
			treeNodeAdv6.Optioned = True
			treeNodeAdv6.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv6.ShowLine = True
			treeNodeAdv6.Text = "Plugin"
			treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv7.EnsureDefaultOptionedChild = True
			treeNodeAdv7.MultiLine = True
			treeNodeAdv7.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv7.ShowLine = True
			treeNodeAdv7.Text = "Themes"
			treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv8.EnsureDefaultOptionedChild = True
			treeNodeAdv8.MultiLine = True
			treeNodeAdv8.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv8.ShowLine = True
			treeNodeAdv8.Text = "Upgrade"
			treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv9.EnsureDefaultOptionedChild = True
			treeNodeAdv9.MultiLine = True
			treeNodeAdv9.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv9.ShowLine = True
			treeNodeAdv9.Text = "Upload"
			treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv10.EnsureDefaultOptionedChild = True
			treeNodeAdv10.MultiLine = True
			treeNodeAdv10.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv10.ShowLine = True
			treeNodeAdv10.Text = "Index"
			treeNodeAdv5.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv6, treeNodeAdv7, treeNodeAdv8, treeNodeAdv9, treeNodeAdv10})
			treeNodeAdv5.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv5.ShowLine = True
			treeNodeAdv5.Text = "Content"
			treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv11.EnsureDefaultOptionedChild = True
			treeNodeAdv11.MultiLine = True
			treeNodeAdv11.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv11.ShowLine = True
			treeNodeAdv11.Text = "Include"
			treeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv2, treeNodeAdv5, treeNodeAdv11})
			treeNodeAdv1.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv1.ShowLine = True
			treeNodeAdv1.Text = "Samples"
			treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv12.EnsureDefaultOptionedChild = True
			treeNodeAdv12.Expanded = True
			treeNodeAdv12.MultiLine = True
			treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv13.EnsureDefaultOptionedChild = True
			treeNodeAdv13.MultiLine = True
			treeNodeAdv13.Optioned = True
			treeNodeAdv13.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv13.ShowLine = True
			treeNodeAdv13.Text = "Node5"
			treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv14.EnsureDefaultOptionedChild = True
			treeNodeAdv14.Expanded = True
			treeNodeAdv14.MultiLine = True
			treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv15.EnsureDefaultOptionedChild = True
			treeNodeAdv15.MultiLine = True
			treeNodeAdv15.Optioned = True
			treeNodeAdv15.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv15.ShowLine = True
			treeNodeAdv15.Text = "Node7"
			treeNodeAdv14.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv15})
			treeNodeAdv14.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv14.ShowLine = True
			treeNodeAdv14.Text = "Node6"
			treeNodeAdv12.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv13, treeNodeAdv14})
			treeNodeAdv12.PlusMinusSize = New System.Drawing.Size(9, 9)
			treeNodeAdv12.ShowLine = True
			treeNodeAdv12.Text = "Node4"
			Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv1, treeNodeAdv12})
			Me.treeViewAdv1.SelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))))
			Me.treeViewAdv1.ShowFocusRect = False
			Me.treeViewAdv1.Size = New System.Drawing.Size(214, 304)
			Me.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro
			Me.treeViewAdv1.TabIndex = 0
			Me.treeViewAdv1.Text = "treeViewAdv1"
			' 
			' 
			' 
			Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
			Me.treeViewAdv1.ToolTipControl.TabIndex = 1
			Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
			' 
			' grid
			' 
			Me.grid.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.grid.Controls.Add(Me.treeViewAdv1)
			Me.grid.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.grid.Location = New System.Drawing.Point(38, 25)
			Me.grid.Name = "grid"
			Me.grid.Size = New System.Drawing.Size(220, 326)
			Me.grid.TabIndex = 6
			Me.grid.TabStop = False
			Me.grid.Text = "TreeViewAdv"
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv1.BeforeTouchSize = New System.Drawing.Size(101, 26)
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.IsBackStageButton = False
			Me.buttonAdv1.Location = New System.Drawing.Point(60, 43)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(101, 26)
			Me.buttonAdv1.TabIndex = 7
			Me.buttonAdv1.Text = "Save Tree State"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.buttonAdv2)
			Me.groupBox1.Controls.Add(Me.buttonAdv1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(304, 25)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(220, 155)
			Me.groupBox1.TabIndex = 8
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Choose Action"
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
			Me.buttonAdv2.BeforeTouchSize = New System.Drawing.Size(101, 26)
			Me.buttonAdv2.ForeColor = System.Drawing.Color.White
			Me.buttonAdv2.IsBackStageButton = False
			Me.buttonAdv2.Location = New System.Drawing.Point(60, 96)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(101, 26)
			Me.buttonAdv2.TabIndex = 8
			Me.buttonAdv2.Text = "Load Tree State"
			Me.buttonAdv2.UseVisualStyle = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.CaptionBarColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.CaptionButtonColor = System.Drawing.Color.White
			Me.CaptionForeColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(562, 377)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.grid)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TreeViewAdv"
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grid.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private grid As System.Windows.Forms.GroupBox
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
	End Class
End Namespace

