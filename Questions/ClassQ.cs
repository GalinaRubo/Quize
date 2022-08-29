using System;
namespace Question
{
	internal class ClassQuestion
	{
		public string? Ques { get; }
		public string[]? Unsers { get; }
		public int[]? RightUnsers { get; }

		public ClassQuestion(string? ques, string[]? unsers, int[]? rightunsers)
		{
			Ques = ques;
			Unsers = unsers;
			RightUnsers = rightunsers;
		}


	}
}

