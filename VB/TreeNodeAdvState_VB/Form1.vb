Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace TreeSearch
	Partial Public Class Form1
		Inherits MetroForm
		#Region "Declaration"
		'To initialize the collection
		Private dic As New Dictionary(Of String, Boolean)()
		#End Region

		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
		End Sub
		#End Region

		#Region "Implementation"
		'To save TreeViewAdv.
		Public Function SaveTreeState(ByVal tree As TreeViewAdv) As Dictionary(Of String, Boolean)
			Dim nodeStates As New Dictionary(Of String, Boolean)()

			For Each node As TreeNodeAdv In Collect(tree.Nodes)
				nodeStates.Add(node.Text, node.Expanded)
			Next node
			Return nodeStates
		End Function

		'To load TreeViewAdv
		Private Sub RestoreTreeState(ByVal tree As TreeViewAdv, ByVal treeState As Dictionary(Of String, Boolean))
			For Each node As TreeNodeAdv In Collect(tree.Nodes)
				If treeState.Keys.Count <> 0 AndAlso treeState(node.Text) Then
					node.Expand()
				Else
					node.Expanded = False
				End If
			Next node
		End Sub

		'To iterate through all the nodes in TreeViewAdv
		Private Iterator Function Collect(ByVal nodes As TreeNodeAdvCollection) As IEnumerable(Of TreeNodeAdv)
			For Each node As TreeNodeAdv In nodes
				Yield node

				For Each child As TreeNodeAdv In Collect(node.Nodes)
					Yield child
				Next child
			Next node
		End Function
#End Region

#Region "Events"
		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			'To save the Tree State
			dic = SaveTreeState(Me.treeViewAdv1)
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			'To load the Tree state
			Me.RestoreTreeState(Me.treeViewAdv1, dic)
		End Sub
		#End Region
	End Class
End Namespace
