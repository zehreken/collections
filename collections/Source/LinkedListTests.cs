using System;
using System.Collections.Generic;

namespace collections.Source
{
	public class LinkedListTests : ATest, ITest
	{
		private readonly LinkedList<object> _collection = new LinkedList<object>();
		private readonly int _size;

		public LinkedListTests(int size)
		{
			_size = size;
		}

		public long Add()
		{
			Sw.Reset();
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_collection.AddLast(i);
			}

			Sw.Stop();

			return Sw.ElapsedTicks;
		}

		public long Reach()
		{
			var rnd = new Random();
			Sw.Reset();
			Sw.Start();
			for (int i = 0; i < 100; i++)
			{
				_collection.Contains(rnd.Next(0, _size));
			}
			
			Sw.Stop();

			return Sw.ElapsedTicks;
		}
	}
}