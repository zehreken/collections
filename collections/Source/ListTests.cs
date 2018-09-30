using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class ListTests : ATest, ITest
	{
		private List<object> _coll = new List<object>();
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
				_coll.Add(i);
			}
			
			Sw.Stop();
			Console.WriteLine("List Add: " + Sw.ElapsedTicks);
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
			Console.WriteLine("List Reach: " + Sw.ElapsedTicks);
			Sw.Reset();
		}
	}
}