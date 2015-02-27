using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace browserMonitor
{
	public partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			webBrowser1.Url = new Uri(@"https://www.google.co.jp/");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var qInputs = webBrowser1.Document.All.GetElementsByName("q");
			qInputs[0].InnerText = "C#";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var btns = webBrowser1.Document.All.GetElementsByName("btnG");
			btns[0].InvokeMember("click");
		}
	}
}
