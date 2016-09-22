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
        Dim file As String
        Debug.Print(dlgExmlToXml.ToString)
        For Each file In dlgExmlToXml.FileNames
            RawExmlString = My.Computer.FileSystem.ReadAllText(dlgExmlToXml.FileName)
            ParsedXML = ParseExmlString(RawExmlString)
            ParsedXML.Save(dlgExmlToXml.FileName & ".xml")
        Next
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgXmlToExml.FileOk
        Dim XMLString As String
        Dim RevertedExml As New XDocument
        Dim file As String
        For Each file In dlgXmlToExml.FileNames
            XMLString = My.Computer.FileSystem.ReadAllText(dlgXmlToExml.FileName)
            RevertedExml = RevertXmltoExml(XMLString)
            If dlgXmlToExml.FileName.EndsWith(".exml.xml") Then
                Dim NewFileName As String
                NewFileName = dlgXmlToExml.FileName.Remove(dlgXmlToExml.FileName.Length - 4, 4)
                RevertedExml.Save(NewFileName)
            Else
                RevertedExml.Save(dlgXmlToExml.FileName)
            End If
        Next
    End Sub

    Public Function ParseExmlStringOLD(RawExmlString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(RawExmlString)
        For Each element As XElement In xdoc.Descendants
            Debug.Print("First Attr :" & element.FirstAttribute.ToString)
            Debug.Print("Elem Name :" & element.Name.ToString)
            If (element.Attribute("template") IsNot Nothing) Then
                If (element.Attribute("name") Is Nothing) Then
                    element.Name = element.Name.ToString & "_root"
                Else
                    element.Name = element.Name.ToString & "_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                End If
            Else
                If element.Attribute("name") IsNot Nothing Then
                    element.Name = element.Name.ToString & "_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                    If (element.Attribute("value") IsNot Nothing) Then
                        element.Value = element.Attribute("value").Value
                        element.Attribute("value").Remove()
                    End If
                End If
            End If
        Next
        Return xdoc
    End Function

    Public Function ParseExmlString(RawExmlString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(RawExmlString)
        For Each element As XElement In xdoc.Descendants
            If element.Name IsNot Nothing Then
                element.SetAttributeValue("MainType", element.Name)                             ' Set MainType attribute As Data Or Property

                If element.Attribute("template") IsNot Nothing Then                             ' Check if template
                    element.SetAttributeValue("IsTemplate", True)
                    element.Name = element.Attribute("template").Value
                Else
                    element.SetAttributeValue("IsTemplate", False)
                End If

                If element.Attribute("name") IsNot Nothing Then                                 ' Check for name
                    element.Name = element.Attribute("name").Value                              ' Set element name
                    If element.Attribute("name") = "Id" Then                                    ' If element is an Id element
                        If element.Parent.Attribute("name") Is Nothing Then                     ' has a name attribute
                            element.Parent.Name = element.Attribute("value").Value & "_parent"   ' and if not rename parent with Id_parent
                        End If
                    End If
                    If element.Attribute("value") IsNot Nothing Then
                        element.Value = element.Attribute("value")                              ' Set value
                    End If
                End If

            End If
        Next
        Return xdoc
    End Function

    Public Function RevertXmltoExml(XMLString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(XMLString)
        For Each element As XElement In xdoc.Descendants
            If element.Attribute("MainType") IsNot Nothing Then                                 ' Rename element back to Data or Property
                element.Name = element.Attribute("MainType").Value
                Debug.Print("Element Name : " & element.Name.ToString)
                element.Attribute("MainType").Remove()
                If element.Attribute("IsTemplate") IsNot Nothing Then                           ' Remove IsTemplate attr if necessary
                    element.Attribute("IsTemplate").Remove()
                End If
                If element.Value IsNot Nothing And element.Attribute("value") IsNot Nothing And element.Attribute("name") IsNot Nothing Then                                             ' Update value attr with element value and remove value
                    Debug.Print("Element Value : " & element.ToString)
                    element.SetAttributeValue("value", element.Value.ToString)
                    element.SetValue("")
                End If
            End If
        Next
        Return xdoc
    End Function

    Public Function RevertXmltoExmlold(XMLString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(XMLString)
        For Each element As XElement In xdoc.Descendants
            If (element.Value IsNot Nothing) Then
                If (element.Name Is "Data_root") Then
                    element.Name = element.Name.ToString.TrimEnd("_root")
                    Debug.Print(element.Name.ToString)
                ElseIf (element.Name.ToString Like "*_*") Then
                    Dim elementArr As Array
                    elementArr = element.Name.ToString.Split("_")
                    element.Name = elementArr.GetValue(0).ToString
                    element.SetAttributeValue("name", elementArr.GetValue(1).ToString)
                    Debug.Print(element.Attributes.ToString)
                End If
            Else
                element.Name = element.Name.ToString.TrimEnd("_*")
                Debug.Print("Valueless :" & element.Name.ToString)
            End If
        Next
        Return xdoc
    End Function

End Class