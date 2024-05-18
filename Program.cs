
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
// Random dice = new Random();
// int roll = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"first roll:{roll}");
// Console.WriteLine($"second roll:{roll2}");
// Console.WriteLine($"third roll:{roll3}");

//challenge

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue= Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// code that generates three radom numbers and display in output

// Random dice = new();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int  totalRoll = roll1 + roll2 + roll3;


// Console.WriteLine($"Total Dice roll {roll1} + {roll2} + {roll3} = {totalRoll}");

// if (totalRoll > 14){
//     Console.WriteLine("You are a winner");
// }
// if (totalRoll < 15){
//     Console.WriteLine("You lose, Try again");
// }

// if ((roll1 == roll2)|| (roll2 == roll3) || (roll1 == roll3)){
//     Console.WriteLine("You rolled Doublessss!! you will get +2 bonus");
//     totalRoll += 2;
// }
// Boolean Experssion with contains

// string words = "Akolade is a good boy, He stays up to read and write and code.";
// bool res = words.Contains("Akolade");
// Console.WriteLine(res);

// if (words.Contains("Akolade")){
//     Console.WriteLine("Akolade is Present");
// }


// Arrays
// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "ETR1";
// fraudulentOrderIDs[1] = "ETY2";
// // fraudulentOrderIDs[2] = "ETU3";
// string[] fraudulentOrderIDs = ["ETR1", "ETY2", "ETU3"];
// string[] fraudulentOrderIDs = {"ETR1", "ETY2", "ETU3"};

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "D000";

// Console.WriteLine($"reassigned first element: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fradulent oders to review");


// ForEach
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

// string[] names = ["Rowena", "Robin", "Bao"];
// foreach(string name in names){
//     Console.WriteLine(name);
// }

// int[] inventory = { 200, 250, 700, 175, 250};
// int sum = 0;

// int bin = 0;

// foreach(int items in inventory){
//     sum += items;
//     bin ++;
//     Console.WriteLine($"Bin {bin} = {items} item (Running Total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


// var fradulentIDs = new String[] {"B123", "C234","A345","C15","B177","G3003","G235","B179"};
// foreach(string ids in fradulentIDs){
//     if (ids.StartsWith("B")){
//         Console.WriteLine($"{ids}:This ID starts with B");
//     }
// }

// Random randomNumber = new();
// string[] orderIDs = new string[5];
// for (int i=0; i < orderIDs.Length; i++){
//     int prefixValue = randomNumber.Next(65,70);
//     // convert the random prefix value to char and immediately to string 
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     Console.WriteLine($"{prefixValue}: converted to {prefix}");
//     string suffix = randomNumber.Next(1,1000).ToString("000");
//     Console.WriteLine($"{randomNumber.Next(1,1000)}: converted to {suffix}");
//     orderIDs[i] = $"{prefix} {suffix}";

// }
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// int currentAssignments = 5;
// int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
// int[] andrewScores = [92, 89, 81, 96, 90, 89];
// int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
// int[] loganScores = [90, 95, 87, 88, 96, 96];
// int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
// int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
// int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
// int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];    
// string[] studenNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

// string gradeScale = "";
// Console.Clear();

// foreach (string name in studenNames)
// {
//     int[] studentScores = new int[10];
//     if (name == "Sophia")
//         studentScores = sophiaScores;
//     else if (name == "Emma")
//         studentScores = emmaScores;

//     else if (name == "Andrew")
//         studentScores = andrewScores;

//     else if (name == "Logan")
//         studentScores = loganScores;
//     else if (name == "Becky")
//         studentScores = beckyScores;
//     else if (name == "Chris")
//         studentScores = chrisScores;
//     else if (name == "Eric")
//         studentScores = ericScores;
//     else if (name == "Gregor")
//         studentScores = gregorScores;
//     else
//         continue;


//     int gradedAssignments = 0;
//     int studentSumAssignmentScore = 0;
//     int gradedExtraCreditAssignments = 0;
//     int sumExtraCreditScores = 0;

//     decimal studentAverageScore;
//     decimal currentStudentExtraCreditScore = 0;
//     decimal currentStudentGrade=0;
//     foreach (int score in studentScores)
//     {
//         gradedAssignments += 1;
//         if (gradedAssignments <= currentAssignments)
//             studentSumAssignmentScore += score;
//         else
//             gradedExtraCreditAssignments += 1;
//             sumExtraCreditScores += score;
//     }
//     studentAverageScore = (decimal)studentSumAssignmentScore / currentAssignments;
//     currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;
//     currentStudentGrade = (decimal)(studentSumAssignmentScore + ((decimal)sumExtraCreditScores / 10)) / currentAssignments;


    
//     if (studentAverageScore >= 97)
//         gradeScale = "A+";

//     else if (studentAverageScore >= 93)
//         gradeScale = "A";

//     else if (studentAverageScore >= 90)
//         gradeScale = "A-";

//     else if (studentAverageScore >= 87)
//         gradeScale = "B+";

//     else if (studentAverageScore >= 83)
//         gradeScale = "B";

//     else if (studentAverageScore >= 80)
//         gradeScale = "B-";

//     else if (studentAverageScore >= 77)
//         gradeScale = "C+";

//     else if (studentAverageScore >= 73)
//         gradeScale = "C";

//     else if (studentAverageScore >= 70)
//         gradeScale = "C-";

//     else if (studentAverageScore >= 67)
//         gradeScale = "D+";

//     else if (studentAverageScore >= 63)
//         gradeScale = "D";

//     else if (studentAverageScore >= 60)
//         gradeScale = "D-";

//     else
//         gradeScale = "F";
//     // Console.WriteLine($"{name}:\t\t {studentAverageScore} \t");
//     Console.WriteLine($"{name}\t\t{studentAverageScore}\t\t{currentStudentGrade}\t\t{gradeScale}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / currentAssignments)} pts)");
// }
// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// equality operator 
// Console.WriteLine("a"== "a ");
// Console.WriteLine("a"== "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");


// string val1 = " a";
// string val = "A ";

// Console.WriteLine(val1.Trim().Equals(val.Trim(), StringComparison.CurrentCultureIgnoreCase));
// Console.WriteLine(val1.Trim().Equals(val.Trim(), StringComparison.CurrentCultureIgnoreCase));


// string pangram = "this string contains every letter of the alphabeth";

// Console.WriteLine(pangram.Contains("every"));
// Console.WriteLine(pangram.Contains("letters"));

// Console.WriteLine(pangram.Contains("alphabeth") == false);
// Console.WriteLine(!pangram.Contains("alphabeth"));


int salesAmount = 1001;
Console.WriteLine($"Your Discount is : ${(salesAmount < 1000 ? 100 : 50)}");


Random randomCoinValue = new();
int flipTheCoin = randomCoinValue.Next(0,2);
Console.WriteLine($"Coin FLipped {flipTheCoin}");
Console.WriteLine($"You Flipped a {(flipTheCoin == 0 ? "Head" : "Tail")}");


