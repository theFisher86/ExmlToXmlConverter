Public Class Form1
    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnExmlToXml.Click
        dlgExmlToXml.ShowDialog()
    End Sub

    Private Sub btnXmlToExml_Click(sender As Object, e As EventArgs) Handles btnXmlToExml.Click
        dlgXmlToExml.ShowDialog()
    End Sub

    Private Sub dlgExmlFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgExmlToXml.FileOk
        Dim RawExmlString As String 
        Dim ParsedXML As New XDocument
        RawExmlString = My.Computer.FileSystem.ReadAllText(dlgExmlToXml.FileName)
        ParsedXML = ParseExmlString(RawExmlString)
        ParsedXML.Save(dlgExmlToXml.FileName & ".xml")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgXmlToExml.FileOk
        Dim XMLString As String
        Dim RevertedExml As New XDocument
        XMLString = My.Computer.FileSystem.ReadAllText(dlgXmlToExml.FileName)
        RevertedExml = RevertXmltoExml(XMLString)
        If dlgXmlToExml.FileName.EndsWith(".exml.xml") Then
            Dim NewFileName As String
            NewFileName = dlgXmlToExml.FileName.Remove(dlgXmlToExml.FileName.Length - 4, 4)
            RevertedExml.Save(NewFileName)
        Else
            RevertedExml.Save(dlgXmlToExml.FileName)
        End If
    End Sub

    Public Function ParseExmlString(RawExmlString As String)
        Dim xdoc As New XDocument()
        'Dim ParsedXML As String
        xdoc = XDocument.Parse(RawExmlString)
        For Each element As XElement In xdoc.Descendants
            Debug.Print(element.FirstAttribute)
            If (element.Attribute("template") IsNot Nothing) Then
                If (element.Attribute("name") Is Nothing) Then
                    element.Name = "name_root"
                Else
                    element.Name = "name_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                End If
            Else
                If element.Attribute("name") IsNot Nothing Then
                    element.Name = "name_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                    If (element.Attribute("value") IsNot Nothing) Then
                        element.Value = element.Attribute("value").Value
                        element.Attribute("value").Remove()
                    End If
                End If
            End If
        Next
        'ParsedXML = xdoc.ToString
        'Return ParsedXML
        Return xdoc
    End Function

    Public Function RevertXmltoExml(XMLString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(RevertXmltoExml)
        For Each element As XElement In xdoc.Descendants
            Debug.Print(element.FirstAttribute)
            If (element.Attribute("template") IsNot Nothing) Then
                If (element.Name = "name_root") Then
                    element.Attribute("name") = Nothing
                Else
                    If (element.Name Like "name_*" Then


                        element.Name = "name_" & element.Attribute("name").Value
                        element.Attribute("name").Remove()
                    End If
                    Else
                If element.Attribute("name") IsNot Nothing Then
                    element.Name = "name_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                    If (element.Attribute("value") IsNot Nothing) Then
                        element.Value = element.Attribute("value").Value
                        element.Attribute("value").Remove()
                    End If
                End If
            End If
        Next
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
