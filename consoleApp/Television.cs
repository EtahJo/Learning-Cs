using System;
namespace consoleApp
{
	class Television:IElectronicDevice
	{
		public int Volume { get; set; }
		

        public void On()
        {
            Console.WriteLine("The TV is on");
        }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
            }
            Console.WriteLine($"The TV volume is at {Volume}"); ;
        }

        public void VolumeDown()
        {
           if(Volume != 0)
            {
                Volume--;
            }
            Console.WriteLine($"The TV volume is at {Volume}");
        }
    }
}

