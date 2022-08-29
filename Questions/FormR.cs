
namespace Questions
{
    public partial class FormR : Form
    {
        public FormR()
        {
            InitializeComponent();
        }

		private void reg_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pas_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void login_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void enter_Click(object sender, EventArgs e)
		{

			string path = @"UsersLogin";
			if (!File.Exists(path))
			{
				File.WriteAllText(path, "");
			}
			string readText = File.ReadAllText(path);
			if (readText.Contains(login.Text))
				MessageBox.Show("Такой логин существует");
			else
			{
				File.AppendAllText("Users.txt", login.Text + ";" + password.Text + "\n");
				File.AppendAllText("Users.txt", datebirth.Text + "\n");
				File.AppendAllText(path, login.Text + ";");
				Close();
			}
		}

		private void dbth_Click(object sender, EventArgs e)
		{

		}

		private void datebirth_TextChanged(object sender, EventArgs e)
		{

		}
	}
}