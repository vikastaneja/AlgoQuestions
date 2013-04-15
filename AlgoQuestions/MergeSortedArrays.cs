using System;

namespace AlgoQuestions
{
	// Merge the sorted arrays
	// Also find the kth element of the sorted array without sorting the array
	public class MergeSortedArrays
	{
		private int []a1 = {1,3,5,7,9};
		private int []a2 = {2,4,6,8,10};
			
		public MergeSortedArrays ()
		{
			
		}
		
		public int FindKthElementInMergedList(int k)
		{
			if (k >= a1.Length + a2.Length)
				throw new InvalidOperationException("Value of k is more than combined length of arrays");
			
			if (k <= 0)
				throw new InvalidOperationException("Passed argument has zero value");
			
			int val = 0;
			if (k <= (a1.Length + a2.Length) / 2)
			{
				int i1 = 0;
				int i2 = 0;
				while (k >= 0)
				{
					if (a1[i1] <= a2[i2])
					{
						val = a1[i1++];
					}
					else
					{
						val = a2[i2++];
					}
					
					k--;
				}
			}
			else
			{
				int i1 = a1.Length - 1;
				int i2 = a2.Length - 1;
				while ((a1.Length + a2.Length) - k - 1 >= 0)
				{
					if (a1[i1] >= a2[i2])
					{
						val = a1[i1--];
					}
					else
					{
						val = a2[i2--];
					}
					
					k++;
				}
			}
			
			return val;
		}
	}
}

