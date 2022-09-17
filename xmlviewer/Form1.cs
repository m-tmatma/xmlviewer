using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace xmlviewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtXmlFile.Text = Path.Combine(Application.StartupPath, @"../../pom.xml");
        }

        private void xmlReadButton_Click(object sender, EventArgs e)
        {
            treeXml.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(txtXmlFile.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            ConvertXmlNodeToTreeNode(doc, treeXml.Nodes);
            treeXml.Nodes[0].ExpandAll();
        }

        private void ConvertXmlNodeToTreeNode(XmlNode xmlNode, TreeNodeCollection treeNodes)
        {
            TreeNode newTreeNode = treeNodes.Add(xmlNode.Name);
            switch (xmlNode.NodeType)
            {
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.XmlDeclaration:
                    newTreeNode.Text = "<?" + xmlNode.Name + ">";
                    break;
                case XmlNodeType.Element:
                    newTreeNode.Text = "<" + xmlNode.Name + ">";
                    break;
                case XmlNodeType.Attribute:
                    newTreeNode.Text = "ATRIBUTE:" + xmlNode.Name;
                    break;
                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                    newTreeNode.Text = xmlNode.Value;
                    break;
                case XmlNodeType.Comment:
                    newTreeNode.Text = "<!--" + xmlNode.Value + "-->";
                    break;
            }


            if (xmlNode.Attributes != null)
            {
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    ConvertXmlNodeToTreeNode(attribute, newTreeNode.Nodes);
                }
            }

            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                ConvertXmlNodeToTreeNode(childNode, newTreeNode.Nodes);
            }
        }

    }
}