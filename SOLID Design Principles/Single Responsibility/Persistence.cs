﻿namespace Single_Responsibility
{
	public class Persistence
	{
		public void SaveToFile(Journal j, string fileName, bool overwrite = false)
		{
			if (overwrite || !File.Exists(fileName))
			{
				File.WriteAllText(fileName, j.ToString());
			}
		}
	}
}
