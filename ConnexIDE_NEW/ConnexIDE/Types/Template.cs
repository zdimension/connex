using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

public class Template
{
	//#Region "Variables privées"
	//Private _name As String
	//Private _compiler As String
	//Private _projectfile As String
	//#End Region

	#region "Propriétés"
	public string Name { get; set; }
	public string CompilerPath { get; set; }
	public string TemplateProjectFile { get; set; }
	public string Version { get; set; }
	public string FilePath { get; set; }
    public Image Icon { get; set; }
	public FileType FileType {
		get {
            return FileType.Template;
		}
	}
	#endregion

	public static Template FromFile(string filePath)
	{
		Template functionReturnValue = null;
		try {
			XmlDocument m_xmld = null;
			XmlNodeList nodelistConnex = null;
			//Dim m_node As XmlNode
			XmlNode nodeConnex = null;
			XmlNode nodeTpl = null;
			XmlNodeList nodelistTpl = null;

			//Create the XML Document
			m_xmld = new XmlDocument();
			//Load the Xml file
			m_xmld.Load(filePath);
			nodeConnex = m_xmld.SelectSingleNode("/connex");
			functionReturnValue.Version = nodeConnex.Attributes["version"].ToString();
			nodeTpl = m_xmld.SelectSingleNode("/connex/template");
			nodelistTpl = m_xmld.SelectNodes("/connex/template");
			//Get the list of name nodes 
			functionReturnValue.Name = nodeTpl.Attributes["name"].ToString();
			functionReturnValue.CompilerPath = nodeTpl.Attributes["compiler"].ToString();
			functionReturnValue.TemplateProjectFile = nodeTpl.Attributes["projfile"].ToString();
            functionReturnValue.Icon = Image.FromFile(nodeTpl.Attributes["icon"].ToString());
			functionReturnValue.FilePath = filePath;
		//m_nodelist = m_xmld.SelectNodes("/family/name")
		//Loop through the nodes
		//For Each m_node In m_n = odelist
		//Get the Gender Attribute Value
		//Dim genderAttribute = m_node.Attributes.GetNamedItem("gender").Value
		//Get the firstName Element Value
		//Dim firstNameValue = m_node.ChildNodes.Item(0).InnerText
		//Get the lastName Element Value
		//Dim lastNameValue = m_node.ChildNodes.Item(1).InnerText
		//Write Result to the Console
		//Console.Write("Gender: " & genderAttribute _
		//  & " FirstName: " & firstNameValue & " LastName: " _
		//  & lastNameValue)
		//Console.Write(vbCrLf)
		//Next


		//Loading project
		} catch (System.IO.FileNotFoundException ex1) {
			//Interaction.MsgBox("File not found!", Constants.vbExclamation);
            MessageBox.Show("File not found!", "Error!", 0, MessageBoxIcon.Exclamation);
		} catch (System.Xml.XmlException ex2) {
			//Interaction.MsgBox(ex2.ToString());
            MessageBox.Show(ex2.ToString(), "Error!");
		} catch (Exception errorVariable) {
			//Error trapping

		}
		return functionReturnValue;
	}
}
