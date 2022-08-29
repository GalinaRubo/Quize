using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Questions
{
	public partial class Form_Stat : Form
	{ 

		public Form_Stat(string headInfo, string statInfo)
		{
			InitializeComponent();
			HeadTextBox.Text = headInfo;
			StatTextBox.Text = statInfo;
		}

		internal Stat Stat
		{
			get => default;
			set
			{
			}
		}

		private void HeadTextBox_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void StatTextBox_TextChanged(object sender, EventArgs e)
		{
		
		}
	}
}
