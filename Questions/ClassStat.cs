using System.Text.RegularExpressions;

namespace Questions
{
	internal class Stat
	{
		static string path = @"BDresultGame";
		public static void PastResults(string user)
		{			
			{
				//итоговая строка с данными по пройденным викторинам участника
				string pastStat = "";
				//массив строк после разделения строки с данными участника по одной викторине
				string[] words = new string[3];
				//регулярная строка для вычленения нужноых данных из строки с общими данными
				string userResult = user + @";\w*(\+\w*)?(\+\w*)?(\+\w*)?\;\d";
				//чтение строки с общими данными из файла
				string readText = File.ReadAllText(path);
				//процесс вычленения и записи данных в итоговую строку
				Regex regex = new Regex(userResult);
				MatchCollection matches = regex.Matches(readText);
				if (matches.Count > 0)
				{
					foreach (Match match in matches)
					{
						string ExtractPastStat = match.Value;
						words = ExtractPastStat.Split(new char[] { ';' });
						pastStat = pastStat + "Категория: " + words[1] + "/ Правильных ответов: " + words[2] + "\n";			
					}
					//вывод строки в форму статистики
					Form_Stat forms = new Form_Stat("Результаты прошедших викторин " + user, pastStat);
					forms.ShowDialog();
				}
				else
				{
					MessageBox.Show("Прошлых результатов не найдено");
				}
			}
			return;
		}
		public static void BestResults(string user, string userCat, int eqQ)
			{
				// окончательная строка с рейтингом "Лучшие 20 в заданной категории"
				string BestStat = "";
				//строка с выбранными категориями
				string _userCateg = userCat.Trim(new char[] { '+' });
				//чтение из файла всей информации по результатам всех участников викторины
				string readText = File.ReadAllText(path);
				//делим строку на подстроки, разделитель ';'
				string[] words = readText.Split(new char[] { ';','\n',' ' });
				//Сортируем список по количеству правильных ответов и убираем
				//данные с одинаковыми логинами и  меньшими результатами	
				if (words.Length > 0)
				{
					string login;
					string cat;
					int rank;
					for (int i = eqQ; i > 0; i--)
					{
						for (int j = 0; j < words.Length - 3; j += 3)
						{
							login = words[j];
							cat = words[j+1];
							rank = int.Parse(words[j + 2]);

							if (rank != i || String.Concat(_userCateg.OrderBy(ch => ch)) != String.Concat(cat.OrderBy(ch => ch))) continue;
							{
								if (BestStat.IndexOf(login) == -1) BestStat = BestStat + "Участник " + login + "/ Правильных ответов: " + rank + "\n";
							}
						}
					}
					if (BestStat == "")
					{
						Form_Stat formsN = new Form_Stat("Лучшие результаты в категории: " + _userCateg, "Результатов пока нет");
						formsN.ShowDialog();
					}
					else
					{
					    SelfResults(BestStat, user, userCat, eqQ);
						Form_Stat formsY = new Form_Stat("Лучшие результаты в категории: " + _userCateg, BestStat);
						formsY.ShowDialog();
					}
				}
				else
				{
					MessageBox.Show("Результатов в этой категории вопросов нет!");
				}
				return;
			}	
		public static void SelfResults(string bestStat, string user, string userCat, int eqQ)
		{
			string[] words = bestStat.Split(new char[] { ';', '\n', ' ' });
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == user + "/")
				{
					MessageBox.Show("Ваше место в данной категории: " + (i/5 + 1).ToString());
					break;
				}
				else if (i == words.Length - 1) MessageBox.Show("Вы не участвовали в викторине с данной категорией!");
			}
		}
	}
}
