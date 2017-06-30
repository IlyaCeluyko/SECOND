using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XDocument doc = new XDocument(
                new XElement("department", new XAttribute("name", "FIT"),
                new XElement("student", new XAttribute("name", "Olga"), new XAttribute("group", "1"), new XAttribute("age", "18")),
                new XElement("student", new XAttribute("name", "Nikita"), new XAttribute("group", "2"), new XAttribute("age", "19")),
                new XElement("student", new XAttribute("name", "Pavel"), new XAttribute("group", "7"), new XAttribute("age", "20"))
                ));
            doc.Save("department.xml");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("department.xml");
            var res = doc.Descendants("student").First();

            string name = res.Attribute("name").Value;
            string group = res.Attribute("group").Value;
            string age  = res.Attribute("age").Value;

            MessageBox.Show(string.Format("Student {0}, age {1}, group {2}",name, age, group));

        }
    }
}
