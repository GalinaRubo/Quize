
using Question;


namespace Questions
{

	public partial class Quize : Form
	{
		private static string login;
		List<ClassQuestion> listQu = new List<ClassQuestion>();
		private int EqQ;
		private static int SizeEqQ = 5;
		private int[] UserUnser = new int[4];
		private static int position = 0;
		private int RightUserUnser = 0;
		private int WrongUserUnser = 0;
		private int AllQ = 0;
		public string UserCateg = "";
		private static string path = @"BDresultGame";
		public Quize(string _login)
		{
			login = _login;			
			InitializeComponent();
			ProfileButton.Text = _login;
		}

		public Form_Stat Form_Stat
		{
			get => default;
			set
			{
			}
		}

		internal Deserialize Deserialize
		{
			get => default;
			set
			{
			}
		}

		internal FormProfile FormProfile
		{
			get => default;
			set
			{
			}
		}

		private void quest_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			UserUnser[0] = 1;			
			button1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UserUnser[1] = 1;
			button2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			UserUnser[2] = 1;
			button3.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
		}

		private void button4_Click(object sender, EventArgs e)
		{
			UserUnser[3] = 1;
			button4.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
		}

		private void categ_TextChanged(object sender, EventArgs e)
		{

		}

		private void qw1_TextChanged(object sender, EventArgs e)
		{

		}

		private void qw2_TextChanged(object sender, EventArgs e)
		{

		}

		private void qw3_TextChanged(object sender, EventArgs e)
		{

		}

		private void qw4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void his_Click(object sender, EventArgs e)
		{
			if (this.his.Text == "-")
			{
				his.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
				this.his.Text = "+";
				UserCateg = string.Concat(UserCateg, "History+");
			}
			else
			{
				his.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
				this.his.Text = "-";
				int pos = UserCateg.IndexOf("History+");
				UserCateg = UserCateg.Remove(pos, "History+".Length);
			}
		}

		private void lit_Click(object sender, EventArgs e)
		{
			if (this.lit.Text == "-")
			{
				lit.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
				this.lit.Text = "+";
				UserCateg = string.Concat(UserCateg, "Literature+");
			}
			else
			{
				lit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
				this.lit.Text = "-";
				int pos = UserCateg.IndexOf("Literature+");
				UserCateg = UserCateg.Remove(pos, "Literature+".Length);
			}
		}

		private void bio_Click(object sender, EventArgs e)
		{
			if (this.bio.Text == "-")
			{
				bio.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
				this.bio.Text = "+";
				UserCateg = string.Concat(UserCateg, "Biology+");
			}
			else 
			{
				bio.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
				this.bio.Text = "-";
				int pos = UserCateg.IndexOf("Biology+");
				UserCateg = UserCateg.Remove(pos, "Biology+".Length);
			}
		}

		private void geo_Click(object sender, EventArgs e)
		{
			if (this.geo.Text == "-")
			{
				geo.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
				this.geo.Text = "+";
				UserCateg = string.Concat(UserCateg, "Geography+");
			}
			else
            {
				geo.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
				this.geo.Text = "-";
				int pos = UserCateg.IndexOf("Geography+");
				UserCateg = UserCateg.Remove(pos, "Geography+".Length);
			}
		}


		private void button5_Click(object sender, EventArgs e)
		{
			EqQ = SizeEqQ;
			listQu.Clear();
			RightUserUnser = 0;
			WrongUserUnser = 0;
			if (UserCateg.IndexOf("History+") != -1) Deserialize.Deserial(@"BDquestions\QHistory", listQu);
			if (UserCateg.IndexOf("Literature+") != -1) Deserialize.Deserial(@"BDquestions\QLiterature", listQu);
			if (UserCateg.IndexOf("Biology+") != -1) Deserialize.Deserial(@"BDquestions\QBiology", listQu);
			if (UserCateg.IndexOf("Geography+") != -1) Deserialize.Deserial(@"BDquestions\QGeography", listQu);

			if ((AllQ = listQu.Count) == 0)
			{
				MessageBox.Show("Не выбраны категории вопросов :(");
				return;
			}

			Inisial();		
		}

		private void check_Click(object sender, EventArgs e)
		{
			string rightUnser = "";
			for(int i = 0; i < 4; i++ )
			{
				if (listQu[position].RightUnsers[i] == 1) rightUnser = rightUnser + listQu[position].Unsers[i] + "   ";
			}
			OkUn.Text = rightUnser;
		}

		private void wrong_Click(object sender, EventArgs e)
		{

		}

		private void right_Click(object sender, EventArgs e)
		{

		}

		private void rightBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void WrongBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void куыгде_Click(object sender, EventArgs e)
		{

		}

		private void RightUnser_TextChanged(object sender, EventArgs e)
		{
			
		}
		private void Inisial()
		{
			for (int i = 0; i < 4; i++)
				UserUnser[i] = 0;
			Random rnd = new Random();
			position = rnd.Next(0, AllQ - 1);
			quest.Text = listQu[position].Ques;
			qw1.Text = listQu[position].Unsers[0];
			qw2.Text = listQu[position].Unsers[1];
			qw3.Text = listQu[position].Unsers[2];
			qw4.Text = listQu[position].Unsers[3];
			OkUn.Clear();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{

		}

		private void NextQ_Click(object sender, EventArgs e)
		{
			int ru = 0; //количество совпадений в массивах ответов участника и правильных ответов 
			for (int i = 0; i < 4; i++)
			{
				if (listQu[position].RightUnsers[i] == UserUnser[i]) ru++; //сравнение
			}
			//если полное совпадение, то ответ считается верным, иначе неверным
			//счетчик в окнах 'верно' или 'неверно' меняет значение
			if (ru == 4) RightBox1.Text = (++RightUserUnser).ToString();
			else WrongBox2.Text = (++WrongUserUnser).ToString();
			//пройденный вопрос удаляется из списка вопросов
			listQu.Remove(listQu[position]);
			//список вопросов уменьшается на 1
			--AllQ;
			Inisial();
			//цвета кнопок ответов возвращаются в первоначальное состояние
			button1.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			button2.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			button3.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			button4.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			if (--EqQ == 0)//если заданное количество вопросов пройдено, то результат записывается в файл
			{
				string str = login + ";" + UserCateg.Trim(new char[] { '+' }) + ";" + RightUserUnser + "\n";
				File.AppendAllText(path, str);
				//поля формы очищаются
				quest.Text = "";
				qw1.Text = "";
				qw2.Text = "";
				qw3.Text = "";
				qw4.Text = "";
				OkUn.Clear();
				RightBox1.Text = "";
				WrongBox2.Text = "";
				//количество вопросов восстанавливается для статистики
				EqQ = SizeEqQ;
				//вывод результата провхождения викторины
				Stat.BestResults(login, UserCateg, EqQ);
			}
		}

		private void rightUnser_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void best20Button_CheckedChanged(object sender, EventArgs e)
		{
	
		}

		private void pastResultButton_CheckedChanged(object sender, EventArgs e)
		{
		
		}

		private void ratingButton1_CheckedChanged(object sender, EventArgs e)
		{
			
		}

        private void HelpButton_Click(object sender, EventArgs e)
        {
			string Rulls = File.ReadAllText("Rulls.txt");
			Form_Stat forms = new Form_Stat("Правила проведения викторины ", Rulls);
			forms.ShowDialog();
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Close();
		}

		private void RankButton_Click(object sender, EventArgs e)
		{
			Stat.BestResults(login, UserCateg, SizeEqQ);
		}

		private void PastButton_Click(object sender, EventArgs e)
		{
			Stat.PastResults(login);
		}

		private void Rank20Button_Click(object sender, EventArgs e)
		{
			if (UserCateg == "") MessageBox.Show("Не выбрана категория вопросов :(");
			else Stat.BestResults(login, UserCateg, SizeEqQ);
		}

		private void RankLabel_Click(object sender, EventArgs e)
		{

		}

		private void PastResultslabel_Click(object sender, EventArgs e)
		{

		}

		private void Best20label_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
			
		}

		private void ProfileButton_Click(object sender, EventArgs e)
		{
			FormProfile formpr = new FormProfile(login);
			formpr.ShowDialog();
		}
	}
}