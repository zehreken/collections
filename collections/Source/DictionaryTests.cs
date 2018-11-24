using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class DictionaryTests : ATest, ITest
	{
		private readonly Dictionary<object, object> _collection = new Dictionary<object, object>();
		private readonly int _size;

		public DictionaryTests(int size)
		{
			_size = size;
		}

		public long Add()
		{
			Sw.Reset();
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_collection.Add(i, i);
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
				_collection.ContainsKey(rnd.Next(0, _size));
			}

			Sw.Stop();

			return Sw.ElapsedTicks;
		}
	}
}