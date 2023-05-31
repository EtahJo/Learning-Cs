using System;
namespace consoleApp
{
	public class HammerWarrior : Warrior
	{

		public int hammerChance = 0;
		UseHammer hammerUsed = new UseHammer();
		/// <summary>
		/// attack stronger more damage to health
		/// 
		/// </summary>
		public HammerWarrior(string name = "Warrior",
			double health = 0,
			double attMax = 0,
			double blockMax = 0,
			int hammerChance = 0
			) : base(name, health, attMax, blockMax)
		{
			this.hammerChance = hammerChance;
		}

		public override double Attack()
		{
			Random rnd = new Random();
			int rndValue = rnd.Next(1, 100);

			if (rndValue<this.hammerChance)
			{
				Console.WriteLine("{0} {1}", Name, hammerUsed.Hammer());
				return 150;
			}
			else
			{
				return base.Attack();
			}

		}
	}
}

