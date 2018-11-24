using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class HashSetTests : ATest, ITest
	{
		private readonly HashSet<object> _collection = new HashSet<object>();
		private readonly int _size;

		public HashSetTests(int size)
		{
			_size = size;
		}

		public long Add()
		{
			Sw.Reset();
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_collection.Add(i);
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