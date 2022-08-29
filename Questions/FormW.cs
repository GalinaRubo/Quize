using System;
using System.Windows.Forms;
namespace Questions
{
	public partial class FormW : Form
	{
		public bool reg = false;
		public FormW()
		{
			InitializeComponent();
		}

		internal FormR FormR
		{
			get => default;
			set
			{
			}
		}

		internal FormA FormA
		{
			get => default;
			set
			{
			}
		}

		public Quize Quize
		{
			get => default;
			set
			{
			}
		}

		private void Welcome_Click(object sender, EventArgs e)
		{

		}

		private void buttoòReg_Click(object sender, EventArgs e)
		{
			reg = true;
			Close();
		}

		private void buttonAut_Click(object sender, EventArgs e)
		{
			reg = false;
			Close();
		}

		private void closeX_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}