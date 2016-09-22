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
        Me.dlgExmlToXml = New System.Windows.Forms.OpenFileDialog()
        Me.btnExmlToXmlNew = New System.Windows.Forms.Button()
        Me.btnXmlToExmlNew = New System.Windows.Forms.Button()
        Me.dlgXmlToExml = New System.Windows.Forms.OpenFileDialog()
        Me.btnXmlToExmlOld = New System.Windows.Forms.Button()
        Me.btnExmlToXmlOld = New System.Windows.Forms.Button()
        Me.grpOldMethod = New System.Windows.Forms.GroupBox()
        Me.grpNewMethod = New System.Windows.Forms.GroupBox()
        Me.grpOldMethod.SuspendLayout()
        Me.grpNewMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgExmlToXml
        '
        Me.dlgExmlToXml.AddExtension = False
        Me.dlgExmlToXml.FileName = "ExmlFile"
        Me.dlgExmlToXml.Filter = "EXML Files|*.exml|All Files|*.*"
        Me.dlgExmlToXml.Multiselect = True
        Me.dlgExmlToXml.RestoreDirectory = True
        Me.dlgExmlToXml.Title = "Choose exml File"
        '
        'btnExmlToXmlNew
        '
        Me.btnExmlToXmlNew.Location = New System.Drawing.Point(6, 19)
        Me.btnExmlToXmlNew.Name = "btnExmlToXmlNew"
        Me.btnExmlToXmlNew.Size = New System.Drawing.Size(100, 23)
        Me.btnExmlToXmlNew.TabIndex = 0
        Me.btnExmlToXmlNew.Text = "exml -> xml"
        Me.btnExmlToXmlNew.UseVisualStyleBackColor = True
        '
        'btnXmlToExmlNew
        '
        Me.btnXmlToExmlNew.Location = New System.Drawing.Point(112, 19)
        Me.btnXmlToExmlNew.Name = "btnXmlToExmlNew"
        Me.btnXmlToExmlNew.Size = New System.Drawing.Size(100, 23)
        Me.btnXmlToExmlNew.TabIndex = 1
        Me.btnXmlToExmlNew.Text = "xml -> exml"
        Me.btnXmlToExmlNew.UseVisualStyleBackColor = True
        '
        'dlgXmlToExml
        '
        Me.dlgXmlToExml.AddExtension = False
        Me.dlgXmlToExml.FileName = "XMLFile"
        Me.dlgXmlToExml.Filter = "XML Files|*.xml|All Files|*.*"
        Me.dlgXmlToExml.Multiselect = True
        Me.dlgXmlToExml.RestoreDirectory = True
        Me.dlgXmlToExml.Title = "Choose XML File"
        '
        'btnXmlToExmlOld
        '
        Me.btnXmlToExmlOld.Location = New System.Drawing.Point(112, 19)
        Me.btnXmlToExmlOld.Name = "btnXmlToExmlOld"
        Me.btnXmlToExmlOld.Size = New System.Drawing.Size(100, 23)
        Me.btnXmlToExmlOld.TabIndex = 3
        Me.btnXmlToExmlOld.Text = "xml -> exml"
        Me.btnXmlToExmlOld.UseVisualStyleBackColor = True
        '
        'btnExmlToXmlOld
        '
        Me.btnExmlToXmlOld.Location = New System.Drawing.Point(6, 19)
        Me.btnExmlToXmlOld.Name = "btnExmlToXmlOld"
        Me.btnExmlToXmlOld.Size = New System.Drawing.Size(100, 23)
        Me.btnExmlToXmlOld.TabIndex = 2
        Me.btnExmlToXmlOld.Text = "exml -> xml"
        Me.btnExmlToXmlOld.UseVisualStyleBackColor = True
        '
        'grpOldMethod
        '
        Me.grpOldMethod.Controls.Add(Me.btnExmlToXmlOld)
        Me.grpOldMethod.Controls.Add(Me.btnXmlToExmlOld)
        Me.grpOldMethod.Location = New System.Drawing.Point(12, 70)
        Me.grpOldMethod.Name = "grpOldMethod"
        Me.grpOldMethod.Size = New System.Drawing.Size(222, 53)
        Me.grpOldMethod.TabIndex = 4
        Me.grpOldMethod.TabStop = False
        Me.grpOldMethod.Text = "Old Method"
        '
        'grpNewMethod
        '
        Me.grpNewMethod.Controls.Add(Me.btnXmlToExmlNew)
        Me.grpNewMethod.Controls.Add(Me.btnExmlToXmlNew)
        Me.grpNewMethod.Location = New System.Drawing.Point(12, 12)
        Me.grpNewMethod.Name = "grpNewMethod"
        Me.grpNewMethod.Size = New System.Drawing.Size(222, 52)
        Me.grpNewMethod.TabIndex = 5
        Me.grpNewMethod.TabStop = False
        Me.grpNewMethod.Text = "New Method"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 135)
        Me.Controls.Add(Me.grpNewMethod)
        Me.Controls.Add(Me.grpOldMethod)
        Me.Name = "Form1"
        Me.Text = "exml Converter"
        Me.grpOldMethod.ResumeLayout(False)
        Me.grpNewMethod.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dlgExmlToXml As OpenFileDialog
    Friend WithEvents btnExmlToXmlNew As Button
    Friend WithEvents btnXmlToExmlNew As Button
    Friend WithEvents dlgXmlToExml As OpenFileDialog
    Friend WithEvents btnXmlToExmlOld As Button
    Friend WithEvents btnExmlToXmlOld As Button
    Friend WithEvents grpOldMethod As GroupBox
    Friend WithEvents grpNewMethod As GroupBox
End Class
