using System;
namespace consoleApp
{
	 class TVRemote
	{
		public static IElectronicDevice GetDevice()
		{
			return new Television();
		}

		
	}
}

