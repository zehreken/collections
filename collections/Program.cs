using collections.Source;

namespace collections
{
	internal class Program
	{
		private static ITest _dictionaryTests;
		private static ITest _hashSetTests;
		private static ITest _listTests;

		public static void Main(string[] args)
		{
			const int size = 10000;

//			_dictionaryTests = new DictionaryTests(size);
			_hashSetTests = new HashSetTests(size);
			_listTests = new ListTests(size);
			
			_hashSetTests.Add();
			_hashSetTests.Reach();
			
			_listTests.Add();
			_listTests.Reach();
		}
	}
}