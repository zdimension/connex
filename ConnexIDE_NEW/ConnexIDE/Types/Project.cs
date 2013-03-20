using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;

public class Project
{
	#region "Propriétés"
	public string Name { get; set; }
	public List<File> Files { get; set; }
	public string Path { get; set; }
	public FileType FileType {
		get {
            return FileType.Project;
		}
	}
	public ProjectType Type { get; set; }
	#endregion

	public static Project FromTemplate(Template tm)
	{
		try 
        {
			return FromFile(tm.TemplateProjectFile);
		} 
        catch (Exception errorVariable)
        {
			//Error trapping
            return null;
		}
	}

	public static Project FromFile(string filePath)
	{
		Project functionReturnValue = null;
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
			switch (nodeConnex.Attributes["type"].ToString()) {
				case "FlowScript":
					functionReturnValue.Type = ProjectType.FlowScript;
					break;
			}
			//FromFile.Version = nodeConnex.Attributes("version").ToString
			nodeTpl = m_xmld.SelectSingleNode("/connex/project");
			nodelistTpl = m_xmld.SelectNodes("/connex/project");
			//Get the list of name nodes 
			functionReturnValue.Name = nodeTpl.Attributes["name"].ToString();
			if (nodeTpl.Attributes["name"].ToString().Contains(";")) {
				foreach (string fl in nodeTpl.Attributes["name"].ToString().Split(';')) {
					File fl1 = default(File);
					fl1.Name = fl;
					fl1.Content = System.IO.File.ReadAllText(functionReturnValue.Path + fl);
					functionReturnValue.Files.Add(fl1);
				}
			} else {
				File fl1 = default(File);
				fl1.Name = nodeTpl.Attributes["name"].ToString();
				fl1.Content = System.IO.File.ReadAllText(functionReturnValue.Path + nodeTpl.Attributes["name"].ToString());
				functionReturnValue.Files.Add(fl1);
			}
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
        }
        catch (System.IO.FileNotFoundException ex1)
        {
            //Interaction.MsgBox("File not found!", Constants.vbExclamation);
            MessageBox.Show("File not found!", "Error!", 0, MessageBoxIcon.Exclamation);
        }
        catch (System.Xml.XmlException ex2)
        {
            //Interaction.MsgBox(ex2.ToString());
            MessageBox.Show(ex2.ToString(), "Error!");
		} catch (Exception errorVariable) {
			//Error trapping
		}
		return functionReturnValue;
	}
}
