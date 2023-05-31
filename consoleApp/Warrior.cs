using System;
namespace consoleApp
{
	public class Warrior
	{
		public string Name { get; set; }
		public double Health { get; set; }
		public double AttMax { get; set; }
		public double BlockMax { get; set; }

		Random rnd = new Random();

		public Warrior(string name = "Warrior",
			double health =0,
			double attMax = 0,
			double blockMax =0
			)
		{
			Name = name;
			Health = health;
			BlockMax = blockMax;
			AttMax = attMax;
		
		}
		public virtual double Attack()
		{
			return rnd.Next(1, (int)AttMax);
		}

        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}

