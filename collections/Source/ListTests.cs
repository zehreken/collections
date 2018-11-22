using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class ListTests : ATest, ITest
	{
		private readonly List<object> _collection = new List<object>();
		private readonly int _size;

		public ListTests(int size)
		{
			_size = size;
		}

		public void Add()
		{
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_collection.Add(i);
			}

			Sw.Stop();
			Console.WriteLine("List add: " + Sw.ElapsedTicks);
			Sw.Reset();
		}

		public void Reach()
		{
			var rnd = new Random();
			Sw.Start();
			for (int i = 0; i < 100; i++)
			{
				_collection.Contains(rnd.Next(0, _size));
			}

			Sw.Stop();
			Console.WriteLine("List reach: " + Sw.ElapsedTicks);
			Sw.Reset();
		}
	}
}