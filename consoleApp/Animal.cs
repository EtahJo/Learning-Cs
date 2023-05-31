using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleApp
{
	public class Animal
	{
		private string name;
		protected string sound;
		protected AnimalIdInfo animalIdIndo = new AnimalIdInfo();

		public void SetAnimalIFInfo(int idNum, string owner)
		{
			animalIdIndo.IDNum = idNum;
			animalIdIndo.Owner = owner;
		}

		public void GetAnimalIDInfo()
		{
			Console.WriteLine($"{Name} has the ID " +
				$"of {animalIdIndo.IDNum} and is owned by {animalIdIndo.Owner}");
		}

		public virtual void MakeSound()
		{
			Console.WriteLine($"{Name} says {Sound}");
		}
		public static int numOfAnimals = 0;

		public const string SHELTER = "Derek's Home animal";
		public readonly int idNum;

		// constructors
		public Animal() : this("No Name", "No Sound") { }


		public Animal(string name) : this(name, "No Sound") { }

		public Animal(string name, string sound)
		{
			//SetName(name);
			Sound = sound;
			Name = name;
			//NumOfAnimals = 1;
			Random rnd = new Random();
			idNum = rnd.Next(1, 214748646);
		}
		//{
		//	this.name = name;
		//	this.sound = "No Sound";
		//	numOfAnimals++;
		//}

		//public Animal(string name = "No Name",string sound ="No Sound")
		//{
		//	this.sound = sound;
		//	this.name = name;
		//	numOfAnimals++;
		//}

		// methods

		//public static int GetNumAnimals()
		//{
		//	return numOfAnimals;
		//}

		//public void SetName(string name)
		//{
		//	if (!name.Any(char.IsDigit))
		//	{
		//		this.name = name;
		//	}
		//	else
		//	{
		//		this.name = "No Name";
		//		Console.WriteLine("Name can't contain numbers");
		//	}
		//}

		//public string GetName()
		//{
		//	return name;
		//}

		public string Name
		{
			get { return name; }
			set
			{
				if (value.Any(char.IsDigit))
				{
					name = "No name";
					Console.WriteLine("Name can't contain a number");
				}
				
					name = value;
				
			}
		}

		public string Sound
		{
			get { return sound; }
			set
			{
				if (value.Length > 10)
				{
					sound = "No sound";
					Console.WriteLine("Sound is too long");
				}
				else
				{
					sound = value;
				}
			}
		}

		//public string Owner { get; set; } = "No Owner";

		//public static int NumOfAnimals
		//{
		//	get { return numOfAnimals; }
		//	set {
		//		numOfAnimals++;
		//	}
	//}

		public class AnimalHealth
		{
			public bool HealthyWeight(double height,double weight)
			{
				double calc = height / weight;
				if ((calc >= .18) && (calc <= .27))
				{
					return true;
				} else return false;
			}
		}
	}
}

