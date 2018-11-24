using System;
using collections.Source;

namespace collections
{
	internal class Program
	{
		private static ITest _dictionaryTests;
		private static ITest _hashSetTests;
		private static ITest _listTests;
		private static ITest _linkedListTests;
		private static ITest _queueTests;
		private static ITest _stackTests;

		private const int TestCount = 6;
		private static readonly double[] AddTickSum = new double[TestCount];
		private static readonly double[] ReachTickSum = new double[TestCount];
		private const int Repeat = 1000;

		public static void Main(string[] args)
		{
			const int size = 10000;

			for (int i = 0; i < TestCount; i++)
			{
				AddTickSum[i] = 0;
				ReachTickSum[i] = 0;
			}

			for (int i = 0; i < Repeat; i++)
			{
				_dictionaryTests = new DictionaryTests(size);
				AddTickSum[0] += _dictionaryTests.Add();
				ReachTickSum[0] += _dictionaryTests.Reach();

				_hashSetTests = new HashSetTests(size);
				AddTickSum[1] += _hashSetTests.Add();
				ReachTickSum[1] += _hashSetTests.Reach();

				_listTests = new ListTests(size);
				AddTickSum[2] += _listTests.Add();
				ReachTickSum[2] += _listTests.Reach();

				_linkedListTests = new LinkedListTests(size);
				AddTickSum[3] += _linkedListTests.Add();
				ReachTickSum[3] += _linkedListTests.Reach();

				_queueTests = new QueueTests(size);
				AddTickSum[4] += _queueTests.Add();
				ReachTickSum[4] += _queueTests.Reach();

				_stackTests = new StackTests(size);
				AddTickSum[5] += _stackTests.Add();
				ReachTickSum[5] += _stackTests.Reach();
			}

			for (int i = 0; i < TestCount; i++)
			{
				Console.WriteLine(AddTickSum[i] / Repeat);
				Console.WriteLine(ReachTickSum[i] / Repeat);
			}
		}
	}
}