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
        Me.btnExmlToXml = New System.Windows.Forms.Button()
        Me.btnXmlToExml = New System.Windows.Forms.Button()
        Me.dlgXmlToExml = New System.Windows.Forms.OpenFileDialog()
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
        'btnExmlToXml
        '
        Me.btnExmlToXml.Location = New System.Drawing.Point(12, 12)
        Me.btnExmlToXml.Name = "btnExmlToXml"
        Me.btnExmlToXml.Size = New System.Drawing.Size(100, 23)
        Me.btnExmlToXml.TabIndex = 0
        Me.btnExmlToXml.Text = "exml -> xml"
        Me.btnExmlToXml.UseVisualStyleBackColor = True
        '
        'btnXmlToExml
        '
        Me.btnXmlToExml.Location = New System.Drawing.Point(125, 12)
        Me.btnXmlToExml.Name = "btnXmlToExml"
        Me.btnXmlToExml.Size = New System.Drawing.Size(100, 23)
        Me.btnXmlToExml.TabIndex = 1
        Me.btnXmlToExml.Text = "xml -> exml"
        Me.btnXmlToExml.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 44)
        Me.Controls.Add(Me.btnXmlToExml)
        Me.Controls.Add(Me.btnExmlToXml)
        Me.Name = "Form1"
        Me.Text = "exml Converter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dlgExmlToXml As OpenFileDialog
    Friend WithEvents btnExmlToXml As Button
    Friend WithEvents btnXmlToExml As Button
    Friend WithEvents dlgXmlToExml As OpenFileDialog
End Class
