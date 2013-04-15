using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace AlgoQuestions
{
	public class FindUniquenessInString
	{
		public FindUniquenessInString ()
		{
		}

		public bool CheckForUniqueness(string s)
		{
			if (string.IsNullOrEmpty(s))
				throw new ArgumentNullException("s");
			Dictionary<char, bool> cd = new Dictionary<char, bool>();
			foreach(char c in s)
			{
				if (cd.ContainsKey(c))
					return false;
				cd.Add(c, true);
			}

			return true;
		}
	}
}

