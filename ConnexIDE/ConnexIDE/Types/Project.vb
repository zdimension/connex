Imports System.Xml

Public Class Project
#Region "Propriétés"
    Public Property Name As String
    Public Property Files As List(Of File)
    Public Property Path As String
    Public ReadOnly Property FileType As FileType
        Get
            Return FileType.Project
        End Get
    End Property
    Public Property Type As ProjectType
#End Region

    Public Shared Function FromTemplate(tm As Template) As Project
        Try
            Return FromFile(tm.TemplateProjectFile)
        Catch errorVariable As Exception
            'Error trapping

        End Try
    End Function

    Public Shared Function FromFile(filePath As String) As Project
        Try
            Dim m_xmld As XmlDocument
            Dim nodelistConnex As XmlNodeList
            'Dim m_node As XmlNode
            Dim nodeConnex As XmlNode
            Dim nodeTpl As XmlNode
            Dim nodelistTpl As XmlNodeList

            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml file
            m_xmld.Load(filePath)
            nodeConnex = m_xmld.SelectSingleNode("/connex")
            Select Case nodeConnex.Attributes("type").ToString
                Case "FlowScript"
                    FromFile.Type = ProjectType.FlowScript
            End Select
            'FromFile.Version = nodeConnex.Attributes("version").ToString
            nodeTpl = m_xmld.SelectSingleNode("/connex/project")
            nodelistTpl = m_xmld.SelectNodes("/connex/project")
            'Get the list of name nodes 
            FromFile.Name = nodeTpl.Attributes("name").ToString()
            If nodeTpl.Attributes("name").ToString().Contains(";") Then
                For Each fl In nodeTpl.Attributes("name").ToString().Split(";")
                    Dim fl1 As File
                    fl1.Name = fl
                    fl1.Content = IO.File.ReadAllText(FromFile.Path & fl)
                    FromFile.Files.Add(fl1)
                Next
            Else
                Dim fl1 As File
                fl1.Name = nodeTpl.Attributes("name").ToString()
                fl1.Content = IO.File.ReadAllText(FromFile.Path & nodeTpl.Attributes("name").ToString())
                FromFile.Files.Add(fl1)
            End If
            'm_nodelist = m_xmld.SelectNodes("/family/name")
            'Loop through the nodes
            'For Each m_node In m_n = odelist
            'Get the Gender Attribute Value
            'Dim genderAttribute = m_node.Attributes.GetNamedItem("gender").Value
            'Get the firstName Element Value
            'Dim firstNameValue = m_node.ChildNodes.Item(0).InnerText
            'Get the lastName Element Value
            'Dim lastNameValue = m_node.ChildNodes.Item(1).InnerText
            'Write Result to the Console
            'Console.Write("Gender: " & genderAttribute _
            '  & " FirstName: " & firstNameValue & " LastName: " _
            '  & lastNameValue)
            'Console.Write(vbCrLf)
            'Next


            'Loading project
        Catch ex1 As IO.FileNotFoundException
            MsgBox("File not found!", vbExclamation)
        Catch ex2 As Xml.XmlException
            MsgBox(ex2.ToString())
        Catch errorVariable As Exception
            'Error trapping
        End Try
    End Function
End Class
