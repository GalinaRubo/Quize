using Question;
using System.Text.Json;


namespace Questions
{
	internal class Deserialize
	{
		internal ClassQuestion ClassQuestion
		{
			get => default;
			set
			{
			}
		}

		public static void Deserial(string path,  List<ClassQuestion> listQu)
		{
			//весь текст в формате json считывается из файла в строку
			string json = File.ReadAllText(path);
			//позиция символа '{' в строке
			int strBegin = 0;
			//позиция символа '}' в строке
			int strEnd = 0;
			do
			{
				strBegin = json.IndexOf('{');
				if (strBegin == -1) break;
				strEnd = json.IndexOf('}');
				//чтение подстроки от '{' до '}' и перевод в список объектов Quection
				listQu.Add(JsonSerializer.Deserialize<ClassQuestion>(json.Substring(strBegin, strEnd + 1)));
				//удаление обработанной подстроки из основной строки
				json = json.Remove(strBegin, strEnd + 1);
			} while (strBegin != -1);
			return;
		}
	}
}

