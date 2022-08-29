
namespace Questions
{
	public partial class FormA : Form
	{
		public bool aut = false;
		public string login;
		public FormA()
		{
			InitializeComponent();
		}

		public void Login_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void closeX_Click(object sender, EventArgs e)
		{
             Close();
		}

		private void Entry_Click(object sender, EventArgs e)
		{
			login = Login.Text;
			if (Check("Users.txt", string.Concat(string.Concat(login, ";"), Password.Text)))
			{
				aut = true;
				Close();
			}
			else
			{
				MessageBox.Show("Пользователь не авторизован");
				aut = false;
				Close();
			}

		}
		public bool Check(string path, string user)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				string str;
				while (sr.Peek() > -1)
				{

					str = sr.ReadLine();//считываем новую строку
					if (str.Contains(user))
					{
						sr.Close();
						return true;
					}
				}
				sr.Close();
				return false;
			}
		}

			private void log_Click(object sender, EventArgs e)
		{

		}

		private void pas_Click(object sender, EventArgs e)
		{

		}
		
	}
}