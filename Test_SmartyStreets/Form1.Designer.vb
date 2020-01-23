<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdCheckSingleAddress = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCheckSingleAddress
        '
        Me.cmdCheckSingleAddress.Location = New System.Drawing.Point(361, 589)
        Me.cmdCheckSingleAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCheckSingleAddress.Name = "cmdCheckSingleAddress"
        Me.cmdCheckSingleAddress.Size = New System.Drawing.Size(189, 65)
        Me.cmdCheckSingleAddress.TabIndex = 0
        Me.cmdCheckSingleAddress.Text = "Check Single Address"
        Me.cmdCheckSingleAddress.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Street"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(244, 128)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(198, 26)
        Me.txtStreet.TabIndex = 2
        Me.txtStreet.Text = "11155 Roseland Rd."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(244, 175)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(112, 26)
        Me.txtCity.TabIndex = 4
        Me.txtCity.Text = "Sebastian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(244, 222)
        Me.txtState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(112, 26)
        Me.txtState.TabIndex = 6
        Me.txtState.Text = "Florida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Zip"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(244, 270)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(112, 26)
        Me.txtZip.TabIndex = 8
        Me.txtZip.Text = "32958"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.RichTextBox1.Location = New System.Drawing.Point(461, 15)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(496, 555)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(115, 36)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem2, Me.CutToolStripMenuItem1, Me.PasteToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(114, 32)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyToolStripMenuItem2
        '
        Me.CopyToolStripMenuItem2.Name = "CopyToolStripMenuItem2"
        Me.CopyToolStripMenuItem2.Size = New System.Drawing.Size(156, 34)
        Me.CopyToolStripMenuItem2.Text = "Copy"
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(156, 34)
        Me.CutToolStripMenuItem1.Text = "Cut"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(156, 34)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 422)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Process Text Box Content"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 669)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCheckSingleAddress)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCheckSingleAddress As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
