
namespace Questions
{
	internal  class Program
	{
		public FormW FormW
		{
			get => default;
			set {}
		}

		static void Main()
		{

			FormW formw = new FormW();
			Application.Run(formw);
			if (formw.reg) Application.Run(new FormR());
			{
				if (BeginQuize() == true)
				{
					MessageBox.Show("�� ����� ������!");
					return;
				}
				if (Mess("����� ����������������?"))
				{
					Application.Run(new FormR());
					BeginQuize();
				}
				MessageBox.Show("�� ����� ������!");
				return;
			}
		}
		private static bool BeginQuize()
		{
				FormA forma = new FormA();
				Application.Run(forma);
				if (forma.aut)
				{
					do
					{
						Quize formq = new Quize(forma.login);
						Application.Run(formq);
					} while (Mess("��������� ��������� ���� ������?"));
				}
				else return false;
			return true;
		}
		static bool Mess(string mess)
		{
			DialogResult result = MessageBox.Show(
			mess, "���������",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Information,
			MessageBoxDefaultButton.Button1,
			MessageBoxOptions.DefaultDesktopOnly);
			if (result == DialogResult.Yes) return true;
			else return false;
		}
	}
}
