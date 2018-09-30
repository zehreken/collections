using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class HashSetTests : ATest, ITest
	{
		private HashSet<object> _coll = new HashSet<object>();
		private readonly int _size;

		public HashSetTests(int size)
		{
			_size = size;
		}

		public void Add()
		{
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_coll.Add(i);
			}

			Sw.Stop();
			Console.WriteLine("HashSet Add: " + Sw.ElapsedTicks);
			Sw.Reset();
		}

		public void Reach()
		{
			var rnd = new Random();
			Sw.Start();
			for (int i = 0; i < 100; i++)
			{
				_coll.Contains(rnd.Next(0, _size));
			}

			Sw.Stop();
			Console.WriteLine("HashSet Reach: " + Sw.ElapsedTicks);
			Sw.Reset();
		}
	}
}