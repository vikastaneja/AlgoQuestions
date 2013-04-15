using System;

namespace AlgoQuestions
{
	public class LinkedListNode
	{
		public LinkedListNode ()
		{
			this.Next = null;
		}

		public LinkedListNode Next { get; set; }
		public int Info { get; set; }
	}

	public class LinkedList
	{
		public LinkedList ()
		{
		}

		public LinkedListNode Head { get; set; }

		public void AddNode(int info)
		{
			if (this.Head == null)
			{
				this.Head = new LinkedListNode();
				this.Head.Info = info;
				return;
			}

			LinkedListNode temp = this.Head;
			while (temp.Next != null)
			{
				temp = temp.Next;
			}

			temp.Next = new LinkedListNode();
			temp.Next.Info = info;
		}

		public void PrintList()
		{
			if (this.Head == null)
			{
				Console.WriteLine("Linked list is empty");
				return;
			}

			Console.WriteLine("Linked list is");
			LinkedListNode temp = this.Head;
			while (temp != null)
			{
				Console.Write(temp.Info + " ");
				temp = temp.Next;
			}
		}
	}
}

