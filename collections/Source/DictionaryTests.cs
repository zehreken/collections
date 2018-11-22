using System;
using System.Collections.Generic;

namespace collections.Source
{
	public sealed class DictionaryTests : ATest, ITest
	{
		private Dictionary<object, object> _collection = new Dictionary<object, object>();
		private readonly int _size;
		
		public DictionaryTests(int size)
		{
			_size = size;
		}

		public void Add()
		{
			Sw.Start();
			for (int i = 0; i < _size; i++)
			{
				_collection.Add(i, i);
			}
			
			Sw.Stop();
			Console.WriteLine("Dictionary add: " + Sw.ElapsedTicks);
			Sw.Reset();
		}

		public void Reach()
		{
			var rnd = new Random();
			Sw.Start();
			for (int i = 0; i < 100; i++)
			{
				_collection.ContainsKey(rnd.Next(0, _size));
			}
			
			Sw.Stop();
			Console.WriteLine("Dictionary add: " + Sw.ElapsedTicks);
			Sw.Reset();
		}
	}
}