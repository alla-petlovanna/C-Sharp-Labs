using System;
using System.Collections.Generic;

namespace Lab13_4
{
	public class Employee
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public Employee(string name, int id) => (Name, ID) = (name, id);
	}

	public class List<T> where T : Employee
	{
		private class Node
		{
			public Node Next { get; set; }
			public T Data { get; set; }
			public Node(T t) => (Next, Data) = (null, t);
		}

		private Node head;

		public void AddHead(T t)
		{
			Node n = new Node(t) { Next = head };
			head = n;
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node current = head;
			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}

		public T FindFirstOccurrenceByName(string s)
		{
			Node current = head;
			T t = null;
			while (current != null)
			{
				if (current.Data.Name == s)
				{
					t = current.Data;
					break;
				}
				else
				{
					current = current.Next;
				}
			}
			return t;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();
			employees.AddHead(new Employee("Mary", 100));
			employees.AddHead(new Employee("Patricia", 101));
			employees.AddHead(new Employee("James", 102));
			Console.WriteLine($"Founded head (Jennifer) = Employee ({ employees.FindFirstOccurrenceByName("Jennifer").Name}, { employees.FindFirstOccurrenceByName("Jennifer").ID})");
			Console.ReadKey();
		}
	}
}
