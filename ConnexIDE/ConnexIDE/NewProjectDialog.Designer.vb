<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProjectDialog
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Installed languages")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Get templates online (Coming soon)")
        Me.trvLngs = New System.Windows.Forms.TreeView()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'trvLngs
        '
        Me.trvLngs.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.trvLngs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trvLngs.Dock = System.Windows.Forms.DockStyle.Left
        Me.trvLngs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trvLngs.Location = New System.Drawing.Point(0, 0)
        Me.trvLngs.Name = "trvLngs"
        TreeNode1.Name = "nodeInst"
        TreeNode1.Text = "Installed languages"
        TreeNode2.ForeColor = System.Drawing.Color.Gray
        TreeNode2.Name = "nodeOnline"
        TreeNode2.NodeFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode2.Text = "Get templates online (Coming soon)"
        Me.trvLngs.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.trvLngs.Size = New System.Drawing.Size(224, 390)
        Me.trvLngs.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(224, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 32)
        Me.Panel1.TabIndex = 2
        '
        'NewProjectDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.trvLngs)
        Me.IsMdiContainer = True
        Me.Name = "NewProjectDialog"
        Me.Text = "Create a new project"
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'SetWindowTheme(trvLngs.Handle, "explorer", Nothing)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents trvLngs As System.Windows.Forms.TreeView
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents TreeNode1 As System.Windows.Forms.TreeNode
    Friend WithEvents TreeNode2 As System.Windows.Forms.TreeNode
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
