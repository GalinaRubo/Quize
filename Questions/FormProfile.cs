

namespace Questions
{
	public partial class FormProfile : Form
	{
		string Login;
        public	FormProfile(string login)
		{
		Login = login;
		InitializeComponent();
		ProfileLginText.Text = Login;
		}

		private void YourProfile_Click(object sender, EventArgs e)
		{

		}

		private void ProfileDbth_Click(object sender, EventArgs e)
		{

		}

		private void ProfileEnter_Click(object sender, EventArgs e)
		{
			if (ProfilePasswordText.Text == "") MessageBox.Show("Введите старый пароль");
			else
			{
				string readText = File.ReadAllText("Users.txt");
				string[] words = readText.Split(new char[] { ';', '\n', '\r' });
				File.WriteAllText("Users.txt", "");
				for (int i = 0; i < words.Length - 3; i += 3)
				{
					if (words[i] == Login)
					{
						if (words[i + 1] != ProfilePasswordText.Text)
						{
							MessageBox.Show("Старый пароль введен неверно!");
							break;
						}
						words[i + 1] = ProfileNewPasswordText.Text;
						if (ProfileDatebirthText.Text != "") words[i + 2] = ProfileDatebirthText.Text;
					}
					File.AppendAllText("Users.txt", words[i] + ";" + words[i + 1] + "\n");
					File.AppendAllText("Users.txt", words[i + 2] + "\n");
				}
				Close();
			}			
		}

		private void ProfilePasswordText_TextChanged(object sender, EventArgs e)
		{

		}

		private void ProfileLginText_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void ProfileClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ProfilePassword_Click(object sender, EventArgs e)
		{

		}

		private void ProfileLogin_Click(object sender, EventArgs e)
		{

		}

		private void ProfileDatebirthText_TextChanged(object sender, EventArgs e)
		{

		}

		private void FormProfile_Load(object sender, EventArgs e)
		{

		}

		private void ProfileNewPasswordText_TextChanged(object sender, EventArgs e)
		{

		}

		private void ProfileNewPassword_Click(object sender, EventArgs e)
		{

		}
	}
}
