Imports System.Xml

Public Class Template
    '#Region "Variables privées"
    'Private _name As String
    'Private _compiler As String
    'Private _projectfile As String
    '#End Region

#Region "Propriétés"
    Public Property Name As String
    Public Property CompilerPath As String
    Public Property TemplateProjectFile As String
    Public Property Version As String
    Public Property FilePath As String
    Public ReadOnly Property FileType As FileType
        Get
            Return FileType.Template
        End Get
    End Property
#End Region

    Shared Function FromFile(filePath As String) As Template
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
            FromFile.Version = nodeConnex.Attributes("version").ToString
            nodeTpl = m_xmld.SelectSingleNode("/connex/template")
            nodelistTpl = m_xmld.SelectNodes("/connex/template")
            'Get the list of name nodes 
            FromFile.Name = nodeTpl.Attributes("name").ToString()
            FromFile.CompilerPath = nodeTpl.Attributes("compiler").ToString()
            FromFile.TemplateProjectFile = nodeTpl.Attributes("projfile").ToString()
            FromFile.FilePath = filePath
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
