using System;
// classic singletonPattern //
namespace SinglePattern
{
	public class Singleton
	{
		private static Singleton myInstance;

		private Singleton()
		{
		}

		public static Singleton GetInstance()
		{
			if(myInstance == null)
			{
				myInstance = new Singleton();
			}

			return myInstance;
		}
	}
}

