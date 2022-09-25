using System;

namespace Generic_class_Stack
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var intStack = new Stack<int>(3);
			
			intStack.Push(1);
			intStack.Push(2);
			intStack.Push(3);
			Console.WriteLine("Добавили 3 элемента:");
			intStack.Show();
			Console.WriteLine("Третий элемент = {0}", intStack.Get(2));
			intStack.Pop();
			intStack.Pop();
			Console.WriteLine("Удалили 2 элемента:");
			intStack.Show();

			var strStack = new Stack<string>(5);

			strStack.Push("First");
			strStack.Push("Second");
			Console.WriteLine("Добавили 2 элемента:");
			strStack.Show();

			Console.ReadKey();
		}
	}
}