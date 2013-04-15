using System;
using System.Collections.Generic;
using System.Collections;
namespace AlgoQuestions
{
	public class Pair
	{
		public int x1 { get; set; }
		public int x2 { get; set; }
		public Pair(int x1, int x2)
		{
			this.x1 = x1;
			this.x2 = x2;
		}
		
		public Pair()
		{}
		
	};
			
	
	// Question: Some pairs are defines on a number line. Write a program to merge them into the least possible duration
	// For example: (1,6), (2,7), (9, 11) ==> (1,7) , (9, 11)
	public class MergePairs
	{
		public List<Pair> ListOfPairs { get; set; } 
		
		public MergePairs ()
		{
			this.ListOfPairs = new List<Pair> ();
		}
		
		/// <summary>
		/// Merges the existing pairs - let the existing pairs be x, y.
		/// Algorithm is:
		/// 1. Pick first y.
		/// 2. For each other element, find if xi falls between x and y
		/// 3. Update xi if xi falls between x and y
		/// 4. Do this for all the elements.
		/// 5. At then end of the first parsing, we have elements that are going to be distinct.
		/// 6. Now start comparing x for each element and merge them.
		/// 7. We will have the list at the end.
		/// </summary>
		public void MergeExistingPairs ()
		{
			if (this.ListOfPairs == null || this.ListOfPairs.Count <= 1)
				return;
			
			// Take the x2 of the first pair and perform the comparison with each and update the x1 is needed
			Pair first = this.ListOfPairs [0];
			for (int i = 1; i < this.ListOfPairs.Count; i++) {
				if (first.x2 <= this.ListOfPairs [i].x2) {
					if (first.x1 < this.ListOfPairs [i].x1)
					{
						this.ListOfPairs [i].x1 = first.x1;
					}
					else
					{
						first.x1 = this.ListOfPairs[i].x1;
					}
				}
			}

			// Now, parse the array
			// Pick the current pair.
			// Compare it with the remining
			// Perform updation of the current one on x2
			// Remove the matched x1 Pair from the list
			// At the end, add the node to another list.
			for (int current  = 0; current < this.ListOfPairs.Count; current++) {
				for (int next = current + 1; next < this.ListOfPairs.Count; next++)
				{
					if (this.ListOfPairs[current].x1 == this.ListOfPairs[next].x1)
					{
						this.ListOfPairs[current].x2 = this.ListOfPairs[next].x2 > this.ListOfPairs[current].x2 ?
							this.ListOfPairs[next].x2 : this.ListOfPairs[current].x2;
						this.ListOfPairs.Remove(this.ListOfPairs[next]);
					}
				}
			}
		}
	}
}

