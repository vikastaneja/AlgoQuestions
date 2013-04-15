using System;

namespace AlgoQuestions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FindUniquenessInString f = new FindUniquenessInString();
			Console.WriteLine(f.CheckForUniqueness("ajshfkjsdafapoewiljn"));
			Console.WriteLine(f.CheckForUniqueness("asdfgeyu"));
			MergePairs mp = new MergePairs();
			mp.ListOfPairs.Add(new Pair(2,5));
			mp.ListOfPairs.Add(new Pair(1, 10));
			mp.ListOfPairs.Add(new Pair(6, 10));
			mp.ListOfPairs.Add(new Pair(5, 11));
			mp.MergeExistingPairs();
			      
			MergeSortedArrays ms = new MergeSortedArrays ();
			Console.WriteLine(ms.FindKthElementInMergedList(8));
		}
	}
}
