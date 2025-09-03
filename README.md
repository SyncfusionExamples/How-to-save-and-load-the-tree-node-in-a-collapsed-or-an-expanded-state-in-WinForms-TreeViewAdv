# How to save and load the tree node in a collapsed or an expanded state in WinForms TreeViewAdv?

In [WinForms TreeViewAdv](https://www.syncfusion.com/winforms-ui-controls/treeview) does not have support for saving its TreeNodeAdvCollection in an expanded or a collapsed state. This requirement can be achieved by the following steps.​

1. Save the Expanded or Collapsed state of each of its TreeNodeAdvCollection to a Dictionary.
2. Reload the saved state based on user requirement.

**C#**

```csharp
//Initializes the collection
Dictionary<string, bool> dic = new Dictionary<string, bool>();

//Saves the Tree State
dic = SaveTreeState(this.treeViewAdv1);

//Loads the Tree state
this.RestoreTreeState(this.treeViewAdv1, dic);

//Saves TreeViewAdv
public Dictionary<string, bool> SaveTreeState(TreeViewAdv tree)
{
    Dictionary<string, bool> nodeStates = new Dictionary<string, bool>();  
    foreach (TreeNodeAdv node in Collect(tree.Nodes))
    {
        nodeStates.Add(node.Text,node.Expanded);
    }
    return nodeStates;
}

//Loads TreeViewAdv
private void RestoreTreeState(TreeViewAdv tree, Dictionary<string, bool> treeState)
{
    foreach (TreeNodeAdv node in Collect(tree.Nodes))
    {
        if (treeState.Keys.Count != 0 && treeState[node.Text])
            node.Expand();
        else
            node.Expanded = false;
    }
}

//Iterates through all the nodes in TreeViewAdv
IEnumerable<TreeNodeAdv> Collect(TreeNodeAdvCollection nodes)
{
    foreach(TreeNodeAdv node in nodes)
    {
        yield return node;
        foreach (TreeNodeAdv child in Collect(node.Nodes))
        yield return child;
    }
}
```

**VB.Net**

```vbnet
'Initializes the collection
Private dic As New Dictionary(Of String, Boolean)()

'Saves the Tree State
dic = SaveTreeState(Me.treeViewAdv1)

'Loads the Tree state
Me.RestoreTreeState(Me.treeViewAdv1, dic)

'Saves TreeViewAdv.
Public Function SaveTreeState(ByVal tree As TreeViewAdv) As Dictionary(Of String, Boolean)
  Dim nodeStates As New Dictionary(Of String, Boolean)()
  For Each node As TreeNodeAdv In Collect(tree.Nodes)
       nodeStates.Add(node.Text, node.Expanded)
  Next node
  Return nodeStates
End Function

'Loads TreeViewAdv
Private Sub RestoreTreeState(ByVal tree As TreeViewAdv, ByVal treeState As Dictionary(Of String, Boolean))
    For Each node As TreeNodeAdv In Collect(tree.Nodes)
        If treeState.Keys.Count <> 0 AndAlso treeState(node.Text) Then
 node.Expand()
        Else
 node.Expanded = False
        End If
    Next node
End Sub

'Iterates through all the nodes in TreeViewAdv
Private Function Collect(ByVal nodes As TreeNodeAdvCollection) As IEnumerable(Of TreeNodeAdv)
   For Each node As TreeNodeAdv In nodes
       Return node
       For Each child As TreeNodeAdv In Collect(node.Nodes)
           Return child
       Next child
  Next node
End Function
```
