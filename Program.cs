
// string myFirstFriend = "          Akolade        "; 
// string mySecondFriend = "Emmanuel";

// myFirstFriend = myFirstFriend.TrimStart();
// string friends =$"My Friends are {myFirstFriend.Trim()} {mySecondFriend}";


// Console.WriteLine(friends);
// Console.WriteLine(friends.StartsWith("My"));
// Console.WriteLine(friends.Replace("Akolade","Isaac"));

// decimal a = 42.1M;
// decimal b = 38.2M;
// long c = (long)a + (long)b;
// decimal c = a + b;

// Console.WriteLine($"the answer is {c}");

// int a = 5;
// int b = 3;
// int c = 4;

// bool myTest = c > 10;

// if ((a + b + c > 10) || (a == b)) {
//      Console.WriteLine($"the answer is greater than 10");
//      Console.WriteLine($"and the first nuber is equal to the second number");
// }
// else {
//     Console.WriteLine($"the answer is lower than 10");
//     Console.WriteLine($"the the first nuber is not equal to the second number");
// }

// int counter = 10;
// counter = counter + 1;
// do
// {
//     counter++;
//     Console.WriteLine(counter);
// }
// while (counter < 5);

// // For Loops 
// for (int _init = 0; _init < 5; _init++){
//     Console.WriteLine(_init);
// }

// for (int row = 1; row < 11; row++) {
//     for (char col = 'a'; col < 'k'; col++){
//         Console.WriteLine($"The cell is ({row}, {col})");

//     }
// }

// // List<T>
// // T means Type

// var names = new List<string>
// {
//     "James",
//     "Akolade",
//     "Isaac",
//     "Love",
//     "Damian"
// }; 
// // creating an object with new
// for(int i = 0; i < names.Count; i++){
//     Console.WriteLine($"Hello {names[i].ToUpper()}");
// }
// foreach (var people in names)
// {
//     Console.WriteLine($"Hello {people.ToUpper()}");
// }

// // to get the last item in the array, it is the length of the array  minus 1

// Console.WriteLine(names[2]);
// Console.WriteLine(names[1]);
// Console.WriteLine(names[^2]);


// var numbers = new List<int>{
//   45,
//   30,
//   56,
//   87,
//   76,
//   45,
// };
// Console.WriteLine($"{numbers.IndexOf(56)}");
// numbers.Sort();
// Console.WriteLine($"{numbers.IndexOf(56)}");
// foreach (var item in numbers)
// {
//     Console.WriteLine($"Hello {item}");
// }

// // LING : Language Integrated Query
// List<int> scores = [97, 92, 81, 60];

// for (int i = 0; i < scores.Count; i++)
// {
//     if (scores[i] > 80)
//     {
//         Console.WriteLine($"Found a score over 80 {scores[i]}");
//     }
// }


// return;

// IEnumerable<string> scoreQuery= 
//     from score in scores
//     where score > 80
//     orderby score ascending
//     select $"the score is {score}";

// foreach (string s in scoreQuery){
//     Console.WriteLine(s + " ");
// }


// // OOP:
// var p1 = new MyPerson("Akolade", "James", new DateOnly(2024, 1, 1));
// var p2 = new MyPerson("Kolade", "James", new DateOnly(2024, 1, 1));

// p1.Pets.Add(new Cat("fred"));
// p2.Pets.Add(new Cat("halley"));
// List<MyPerson> people = [p1, p2];

// foreach( var person in people){
//     Console.WriteLine($"{person}");
//     foreach (var pet in person.Pets){
//         Console.WriteLine($"{pet}");
    
//     }
// }
// // Console.WriteLine(people.Count);
// public class MyPerson(string first, string last, DateOnly bd)
// {
//     public string firsname = first;

//     public string lastname = last;
//     public DateOnly dateofbirth = bd;
//     public List<Pet> Pets { get; } = new();
//     public override string ToString()
//     {
//         return $"{firsname} {lastname}";
//     }
// }

// public abstract class Pet(string first)
// {
//     public string firsname = first;
//     public abstract string MakeNoise();
//     public override string ToString()
//     {
//         return $"{firsname} I am a {GetType().Name} and I make {MakeNoise()}";
//     }

// }
// public class Cat(string first) : Pet(first)
// {

//     public override string MakeNoise() => "meow";

// }

// Console.WriteLine("Hello\nWorlds");

// store sum

// int sophiaSum = 0;
// int nicolasSum = 0;
// int zahirahSum = 0;
// int jeongSum = 0;

// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);


// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int gradeA = 4;
// int gradeB = 3;
// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// Console.WriteLine($"{course1Name} {course1Grade}");
// Console.WriteLine($"{course2Name} {course2Grade}");
// Console.WriteLine($"{course3Name} {course3Grade}");
// Console.WriteLine($"{course4Name} {course4Grade}");
// Console.WriteLine($"{course5Name} {course5Grade}");



// .NET Class Library
/*
.NET library is an organized collection  
of profgramming languge resources 

*/

// Overload
Random dice = new Random();
int roll = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"first roll:{roll}");
Console.WriteLine($"second roll:{roll2}");
Console.WriteLine($"third roll:{roll3}");

