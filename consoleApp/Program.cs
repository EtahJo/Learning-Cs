//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Text;
using System.Globalization;
//using consoleApp.Animal;

namespace consoleApp
{
    public class Program
    {
        //struct Rectangle
        //{
        //    public double length;
        //    public double width;
        //    public Rectangle(double l = 1, double w = 1)
        //    {
        //        length = l;
        //        width = w;
        //    }
        //    public double Area()
        //    {
        //        return length * width;
        //    }
        //}

        // --- FUNCTIONS ---

        //static void  PrintArray(int[] intArray,string mess)
        //{
        //    foreach(int k in intArray)
        //    {
        //        Console.WriteLine("{0}: {1}", mess, k);
        //    }
        //}

        //static double DoDivision(double x, double y)
        //{
        //    if (y == 0)
        //    {
        //        throw new System.DivideByZeroException();
        //    }
        //    return x / y;
        //}

        //private static void SayHello()
        //{
        //    string name = "";
        //    Console.Write("What is your name :");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Hello {0} ", name);
        //}

        //static double GetSum(double x =1,double y=1)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //    return x + y;

        //}

        //static void DoubleInt(int x, out int solution)
        //{
        //    solution = x * 2;

        //}
        //static double getSomeMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach (int i in nums)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //static void PrintInfo(string name, int zipCode)
        //{
        //    Console.WriteLine("{0} lives in the zip code {1}",name,zipCode);
        //}

        //static double GetSum2(double x=1, double y = 1)
        //{
        //    return x + y;
        //}

        //static double GetSum2(string x="1", string y="1")
        //{
        //    double dbLX = Convert.ToDouble(x);
        //    double dbLy = Convert.ToDouble(y);

        //    return dbLX + dbLy;

        //}
        //static void PaintCar(CarColor cc)
        //{
        //    Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        //}

        // ---- END OF FUNCTIONS ----

        //enum CarColor : byte
        //{
        //    Orange = 1,
        //    Blue,
        //    Green,
        //    Red,
        //    Yellow
        //}
        static void Main(string[] args)
        {
            //Rectangle rect1;
            //rect1.length = 200;
            //rect1.width = 50;
            //Console.WriteLine("Area of rect1 : {0}", rect1.Area());


            //Rectangle rect2 = new Rectangle(100, 40);

            ////rect2 = rect1;
            //rect1.length = 33;
            //Console.WriteLine("Rect2.length: {0}", rect2.length);

            //Animal fox = new Animal()
            //{
            //    name = "Red",
            //    sound = "Raaw"

            //};
            Animal cat = new Animal();
            //cat.SetName("Whiskers");
            //cat.Sound="moew";
            //Console.WriteLine("The cat is names {0} and says {1}",
            //    cat.GetName(), cat.Sound
            //    );
            //cat.Owner = "Etah";
            //Console.WriteLine("{0} owner is {1}",
            //    cat.GetName(), cat.Owner);


            //Console.WriteLine("{0} shelter id is {1}",
            //    cat.GetName(), cat.idNum);

            //Console.WriteLine("# of Animals {0}",
            //    Animal.NumOfAnimals);
            //Console.WriteLine("# of Animals {0}",
            //    Animal.GetNumAnimals());

            //Console.WriteLine("Area of rectangle : {0}",
            //    ShapeMath.GetArea("rectangle",5,6));

            //int? randNum = null;

            //if(randNum == null)
            //{
            //    Console.WriteLine("randNum is null");
            //}

            //if (!randNum.HasValue)
            //{
            //    Console.WriteLine("randNum is null");
            //}

            //CarColor car1 = CarColor.Blue;
            //PaintCar(car1);
            //int num3 = 30;
            //int num4 = 20;
            //Console.WriteLine("Before Swap num1 : {0} num2 :{1}", num3,num4);
            //DateTime awesomeDate = new DateTime(1994, 02, 03);

            //Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);

            //awesomeDate = awesomeDate.AddDays(1);
            //Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);

            //awesomeDate = awesomeDate.AddMonths(1);

            //Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);

            //awesomeDate = awesomeDate.AddYears(1);

            //Console.WriteLine("Day of the week : {0}", awesomeDate.DayOfWeek);


            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);


            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));

            //Console.WriteLine("New Time: {0}", lunchTime.ToString());




            ////Swap(ref num3, ref num4);

            //Console.WriteLine("After Swap num1 : {0} num2 :{1}", num3, num4);
            //Console.WriteLine("1+2+3+...= {0}",
            //      getSomeMore(1, 2, 3, 4, 5, 5, 6)
            //    );

            //PrintInfo(zipCode: 1517, name: "Etah");

            //Console.WriteLine("5.0 + 4.0 ={0}", GetSum2(5.0, 4.0));
            //Console.WriteLine("5.0 + 4.0 ={0}", GetSum2("5.0","4.0" ));

            //int solution;
            //DoubleInt(15, out solution);
            //Console.WriteLine("15 * 2 = {0}",solution);
            //double x = 5;
            //double y = 4;
            //Console.WriteLine("5+4 = {0}", GetSum(x, y));
            //Console.Write("What is your name");

            //string name = Console.ReadLine();

            //Console.WriteLine($"Hello {name}");

            //bool canIVote = true;
            //Console.WriteLine("Biggest Interger:{0}", int.MaxValue);
            //Console.WriteLine("Biggest Interger:{0}", int.MinValue);

            //Console.WriteLine("Biggest Long:{0}", long.MaxValue);
            //Console.WriteLine("Biggest Long:{0}", long.MaxValue);

            //canIVote = false;

            //decimal decPival = 3.42464664747488484884M;
            //decimal decBigNum = 3.0000000000000000000000M;

            //Console.WriteLine($"{decPival + decBigNum}");

            //string randString = "This is a string";
            //Console.WriteLine("String Length:{0}", randString.Length);

            //Console.WriteLine("String Contains is :{0}", randString.Contains("is"));

            //Console.WriteLine("Index os is : {0}", randString.IndexOf("is"));

            //Console.WriteLine("Remove String:{0}", randString.Remove(10, 6));

            //Console.WriteLine("Insert String: {0}", randString.Insert(10, "short"));

            //Console.WriteLine("Replace String:{0}", randString.Replace("string", "sentence"));

            //Console.WriteLine("Compare A to B:{0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));


            //comapare strings and ignore case
            //    <0: str1 preceeds str2
            //    =: zero
            //    >0: str2 preceeds str1

            //       Console.WriteLine("__________________");

            //       Console.WriteLine("A=a:{0}", String.Equals("A","a", StringComparison.OrdinalIgnoreCase));

            //       Console.WriteLine("Pad Left:{0}",

            //           randString.PadLeft(20, '.'));

            //       Console.WriteLine("Pad Right:{0}",

            // randString.PadRight(20, '.'));


            //       Console.WriteLine("Trim:{0}",

            // randString.Trim());

            //       Console.WriteLine("Uppercase:{0}",

            // randString.ToUpper());


            //       Console.WriteLine("Lowercase:{0}",

            //randString.ToLower());


            //       string newString = String.Format("{0} saw a {1} {2} in the {3}",
            //           "Paul", "rabbit", "eating", "field"
            //           );

            //       Console.Write(newString + "\n");

            //       Console.WriteLine(@"Exactly what I typed\n");


            //int[] favNums = new int[3];

            //favNums[0] = 23;

            //Console.WriteLine("favNum 0 : {0}", favNums[0]);


            //string[] customers = { "Bob", "Sally", "Sue" };

            //var employees = new[] { "Mike", "Paul", "Rick" };

            //object[] randomArray = { "Paul", 45, 1.234 };

            //Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());

            //Console.WriteLine("Array Size : {0}", randomArray.Length);

            //for(int j=0;j<randomArray.Length; j++)
            //{
            //    Console.WriteLine("Array :{0}:Value:{1}",
            //        j, randomArray[j]
            //        );
            //}


            //Console.WriteLine("__________________");

            //string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Frank" } };


            //Console.WriteLine("MD Value: {0}",

            //    custNames.GetValue(1, 0));


            //for ( int j=0; j < custNames.GetLength(0); j++)
            //{
            //    for(int k=0; k<custNames.GetLength(0); k++)
            //    {
            //        Console.WriteLine("{0}", custNames[j,k]);
            //    }

            //    Console.WriteLine();

            //}

            //int[] randNums = { 1, 2, 3, 4 };


            //PrintArray(randNums,"ForEach");

            //Console.WriteLine("__________________");

            //Array.Sort(randNums);

            //Array.Reverse(randNums);

            //Console.WriteLine("1 at index :{0}", Array.IndexOf(randNums,1));

            //randNums.SetValue(0, 1);

            //int[] srcArray = { 1, 2, 3 };

            //int[] destArray = new int[2];

            //int startIndex = 0;
            //int length = 2;


            //Array.Copy(srcArray, startIndex,destArray,0,length);

            //PrintArray(destArray, "copy");

            //Array anotherArray = Array.CreateInstance(typeof(int), 10);
            //srcArray.CopyTo(anotherArray, 5);
            // foreach(int m in anotherArray)
            //{
            //    Console.WriteLine("CopyTo : {0}", m);
            //}

            //int[] numArray = { 1, 11, 22 };
            //Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

            //int age = 17;

            //if((age>=5) && (age <= 7))
            //{
            //    Console.WriteLine("Go to elemetary school");
            //}

            //if ((age > 7) && (age < 13))
            //{
            //    Console.WriteLine("Go to middle school");
            //}

            //if ((age > 13) && (age < 19))
            //{
            //    Console.WriteLine("Go to high school");
            //}else { Console.WriteLine("Go to college"); }


            //if ((age<14) || (age > 67))
            //{
            //    Console.WriteLine("You shouldn't work");
            //}

            //    Console.WriteLine("! true = " + (!true));

            //    bool canDrive = age >= 16 ? true : false;

            //    switch (age)
            //    {
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Go to Day Care");
            //            break;
            //        case 3:
            //        case 4:
            //            Console.WriteLine("Go to Pre School");
            //            break;
            //        case 5:
            //            Console.WriteLine("Go to kindergarten");
            //            break;
            //        default:
            //            Console.WriteLine("Go to another school");
            //            goto OtherSchool;
            //    }

            //OtherSchool:
            //    Console.WriteLine("Elemetary, Middle, High school");


            //    string name2 = "Derick";
            //    string name3 = "Derick";
            //    if (name2.Equals(name3, StringComparison.Ordinal))
            //    {
            //        Console.WriteLine("Names are equal");
            //    }


            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i%2 == 0)
            //    {
            //        i++;
            //        continue;
            //    }

            //    if (i == 9) break;

            //    Console.WriteLine(i);
            //    i++;
            //}

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11);
            //int numberGuessed = 0;
            //Console.WriteLine("Random Num : ", secretNumber);

            //do
            //{
            //    Console.WriteLine("Enter a number between 1 and 10");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());

            //} while (secretNumber != numberGuessed);

            //Console.WriteLine("You guessed it right");


            //double num1 = 5;
            //double num2 = 1;
            //try
            //{
            //    Console.WriteLine("5/1 = {0}",

            //        DoDivision(num1, num2)

            //        ) ;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can't divide by zero");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Cleaning up");
            //}

            //StringBuilder sb = new StringBuilder("random text");
            //StringBuilder sb2 = new StringBuilder("More Stuff thst is very important", 256);

            //Console.WriteLine("capacity : {0}", sb2.Capacity);
            //Console.WriteLine("Length : {0}", sb2.Length);


            //sb2.AppendLine("\nMore important text");

            //CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");

            //string bestCust = "Bob Smith";
            //sb2.AppendFormat(enUs,"Best Customer: {0}", bestCust);

            //Console.WriteLine(sb2.ToString());
            //sb2.Replace("text", "characters");
            //Console.WriteLine(sb2.ToString());
            //sb2.Clear();
            //sb2.Append("Random Text");

            //Console.WriteLine(sb.Equals(sb2));
            //sb2.Insert(11, "That's great");
            //Console.WriteLine(sb2.ToString());

            //sb2.Remove(11, 7);
            //Console.WriteLine(sb2.ToString());

            //SayHello();

            //Animal whiskers = new Animal()
            //{
            //    Name="Whiskers",
            //    Sound="Meow"
            //};


            //Dog grover = new Dog()
            //{
            //    Name="Grover",
            //    Sound="Woof"

            //};

            //grover.Sound = "Wooooof";

            //whiskers.MakeSound();
            //grover.MakeSound();

            //whiskers.SetAnimalIFInfo(12345, "Sally Smith");
            //grover.SetAnimalIFInfo(12346, "Etah");
            //whiskers.GetAnimalIDInfo();
            //Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            //Console.WriteLine("Is my animal healtthy: {0}",

            //    getHealth.HealthyWeight(11,46)
            //    );
            //Animal monkey = new Animal()
            //{
            //    Name = "Happy",
            //    Sound = "Eeeee"
            //};

            //Animal spot = new Dog()
            //{
            //    Name = "Spot",
            //    Sound = "Wooooff",
            //    Sound2 = "Geeerrrrr"
            //};

            //spot.MakeSound();

            //    Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            //    foreach(Shape s in shapes)
            //    {
            //        s.GetInfo();
            //        Console.WriteLine("{0} Area:{1:f2}",
            //            s.Name, s.Area());

            //        Circle testCirc = s as Circle;
            //        if(testCirc == null)
            //        {
            //            Console.WriteLine("This isn't a circle");
            //        }

            //        if(s is Circle)
            //        {
            //            Console.WriteLine("This isn't a rectangle");

            //        }
            //    };
            //    object circ1 = new Circle(4);
            //    Circle circ2 = (Circle)circ1;
            //    Console.WriteLine("The {0} Area is {1:f2}",
            //circ2.Name, circ2.Area());


            //Vehicle buick = new Vehicle("Buick",
            //    4, 160);

            //if(buick is IDrivable)
            //{
            //    buick.Move();
            //    buick.Stop();
            //}
            //else
            //{
            //    Console.WriteLine("This {0} can't be driven",
            //        buick.Brand
            //        );
            //}

            //IElectronicDevice TV = TVRemote.GetDevice();

            //PowerButton powBut = new PowerButton(TV);

            //powBut.Execute();
            //powBut.Undo();
            //powBut.Execute();
            //powBut.Undo();

            Warrior Thor = new HammerWarrior()
            {
                Name="Thor",
                Health=100,
                AttMax=26,
                BlockMax=10,
                hammerChance=50
            };

            Warrior Loki = new MagicWarrior("Loki", 75, 20, 10,50);
            Battle.StartFight(Thor, Loki);
        }


    }
}