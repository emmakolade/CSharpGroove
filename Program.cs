using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
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
// using System.Diagnostics.CodeAnalysis;
// using System.Net;
// using System.Runtime.CompilerServices;
// using System.Runtime.Serialization;
// using System.Security.Cryptography;

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


// int salesAmount = 1001;
// Console.WriteLine($"Your Discount is : ${(salesAmount < 1000 ? 100 : 50)}");


// Random randomCoinValue = new();
// int flipTheCoin = randomCoinValue.Next(0,2);
// Console.WriteLine($"Coin FLipped {flipTheCoin}");
// Console.WriteLine($"You Flipped a {(flipTheCoin == 0 ? "Head" : "Tail")}");


// string permission = "AdminManager";
// int level = 20;


// if (permission.Contains("Admin")){

//     if(level > 55)
//         Console.WriteLine("Welcome, SuperAdmin");
//     else
//         Console.WriteLine("Welcome, Admin");
// }

// if (permission.Contains("Manager")){

//     if(level >= 20)
//         Console.WriteLine("Contact an Admin for access.");
//     else
//         Console.WriteLine("You do not have sufficient privileges");
// }

// else{

//         Console.WriteLine("You do not have sufficient privileges.");        Console.WriteLine("You do not have sufficient privileges");
// }


// bool flag = true;
// if(flag){
//     value = 5;
//     Console.WriteLine($"There is a value inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"There is a value outside the code block: {value}");


// int[] numbers = [4, 8, 15, 16, 23, 42];
// int total = 0;
// bool foundNumber = false;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         foundNumber = true;
//     }
// }

// if (foundNumber)
// {
//     Console.WriteLine("the list contains 42");
// }
// Console.WriteLine($"Total:{total}");

// switch case

// int employeeLevel = 100;
// string employeeName = "Akolade Olanipekun";
// string employeeTitle = "";
// switch (employeeLevel){

//     case 100:
//     case 200:
//         employeeTitle = "Senior Associate";
//         break;
//     case 300:
//         employeeTitle = "Manager";
//         break;
//     default:
//         employeeTitle = "Associate";
//         break;

// }
// Console.WriteLine($"the Employee name is: {employeeName} with title: {employeeTitle}");

// // Switch Expression 
// employeeTitle = employeeLevel switch
// {
//     100 or 200 => "Senior Associate",
//     300 => "Manager",
//     _ => "Associate",
// };


// Console.WriteLine($"the Employee name is: {employeeName} with title: {employeeTitle}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($" example Product: {size} {color} {type}");

// string stockKeepingUnit = "01-MN-L";

// string[] shirtProduct = stockKeepingUnit.Split('-');


// string shirtType = "";
// string shirtColor = "";
// string shirtSize = "";


// switch (shirtProduct[0])
// {
//     case "01":
//         shirtType = "Sweat Shirt";
//         break;
//     case "02":
//         shirtType = "T-Shirt";
//         break;
//     case "03":
//         shirtType = "Sweat Pants";
//         break;
//     default:
//         shirtType = "Others";
//         break;
// }

// shirtType = shirtProduct[0] switch
// {
//     "01" => "Sweat Shirt",
//     "02" => "T-Shirt",
//     "03" => "Sweat Pants",
//     _ => "Others"
// };

// shirtColor =  shirtProduct[1] switch 
// {
//     "BL" => "Black",
//     "MN" => "Maroon",
//     _ => "White"
// };

// shirtSize =shirtProduct[2]  switch {
//     "S" => "Small",
//     "M" => "Medium",
//     "L" => "Large",
//     _ => "One Size Fits All",

// };
// Console.WriteLine($" My  Shirt Product: {shirtSize} {shirtColor} {shirtType}");



// for (int i = 0; i < 10; i ++){
//     Console.WriteLine(i);
//     if(i == 7)
//         break;
// }


// string[] names = ["Akolade", "Emmanuel", "Olanipekun", "Temitope"];
// Console.WriteLine(names.Length);
// Console.WriteLine(names.Length - 1);
// for (int i = names.Length - 1; i >= 0; i--){
//     Console.WriteLine(names[i]);
// }

// Examine the Limitation of the foreach statement 
// string[] names = ["Akolade", "Emmanuel", "Olanipekun", "Temitope"];
// for (int i =0; i < names.Length; i++)
// {
//     if (names[i] == "Olanipekun") {
//         names[i] = "Olajide";
//     }
//     Console.WriteLine(i);

// }

// foreach( var name in names){
//     Console.WriteLine(name);
// }

// FizzBuzz

// for (int i = 0; i <= 100; i++){
//     if(i % 3 == 0){
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if( i % 5 == 0){
//         Console.WriteLine($"{i} - Buzz");
//     }

//     else if ((i % 3 == 0) && (i % 5 == 0)){
//         Console.WriteLine($"{i} - FizzBuzz");

//     }
//     else
//         Console.WriteLine($"{i}");
// }

// Do While 

// Random randomValue = new();

// int currentValue = randomValue.Next(1, 11);
// do {
//     currentValue = randomValue.Next(1, 11);

//     if (currentValue >=8) continue;
//     Console.WriteLine($"The current value is: {currentValue}");
// } while (currentValue != 7);

// while (currentValue >=3)
// {
//     Console.WriteLine($"The current value is: {currentValue}  >>");
//     currentValue = randomValue.Next(1, 10);
// }
// Console.WriteLine($"This Number is before 3: {currentValue}");

// int heroHealth = 10;
// int monsterHealth = 10;

// Random randomValue = new();
// do
// {
//     int attacks = randomValue.Next(1, 11);
//     monsterHealth -= attacks;
//     Console.WriteLine($"Monster was damaged and lost {attacks} health and now has {monsterHealth} health");
//     if(monsterHealth <= 0){
//         continue;
//     }
//      attacks = randomValue.Next(1, 11);

//     heroHealth -= attacks;
//     Console.WriteLine($"Hero was damaged and lost {attacks} health and now has {heroHealth} health");
//     if(heroHealth <= 0){
//         continue;
//     }



// } while (heroHealth > 0 && monsterHealth > 0);
// Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins" : "Monster Wins");


// manage user input

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// int numericValue = 0;
// bool validNumber = false;

// do{
//     readResult = Console.ReadLine();
//     validNumber = int.TryParse(readResult, out numericValue);

//     if(readResult != null){
//         if(readResult.Length >= 3){
//             validEntry = true;
//         }
//         else{
//             Console.WriteLine("Invalid input, please try again");
//         }
//     }


// }while(validEntry== false);


// project 1: Validates integer Input 
// string? readInput;
// string valueEntered = "";
// bool validInput = false;
// Console.WriteLine("Enter an Integer between 5 and 10 ");
// int convertedToNumber = 0;
// bool isValidNumber = false;



// do{
//     readInput= Console.ReadLine();
//     if(readInput != null){
//         valueEntered = readInput;
//     }
//     isValidNumber =int.TryParse(valueEntered, out convertedToNumber);

//     if (isValidNumber == true){
//         if(convertedToNumber <= 5 || convertedToNumber >=10 ){
//             validInput = false;
//             Console.WriteLine($"You entered {convertedToNumber}. Please enter a number between 5 and 10.");
//         }
//     }else{
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }


// }while(validInput==false);
// Console.WriteLine($"Your input value ({convertedToNumber}) has been accepted.");

// readInput = Console.ReadLine();



// project 2 validates input string

// string? readInput;
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// bool validInput = false;
// do
// {
//     readInput = Console.ReadLine();
//     if (readInput != null)
//     {
//         if (readInput.Trim().Equals("administrator", StringComparison.CurrentCultureIgnoreCase) || readInput.Trim().Equals("manager", StringComparison.CurrentCultureIgnoreCase) || readInput.Trim().Equals("user", StringComparison.CurrentCultureIgnoreCase))
//         {
//             validInput = true;
//             Console.WriteLine($" your input ({readInput}), has been accepeted");
//         }
//         else
//         {
//             Console.WriteLine($" your input ({readInput}), is not valid");

//         }

//     }

// } while (validInput == false);


// project3 

// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
// int periodLocation = 0;
// string myString = "";

// for (int i = 0; i < myString.Length; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;
//     while (periodLocation != -1)
//     {
//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString[(periodLocation + 1)..];

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }
//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }






// the ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";

// // array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 6];
// int i = 0;
// if (i == 0)
// {
//     animalSpecies = "dog";
//     animalID = "d1";
//     animalAge = "2";
//     animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//     animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//     animalNickname = "lola";
// }

// switch (i)
// {
//     case 0:
//         animalSpecies = "dog";
//         animalID = "d1";
//         animalAge = "2";
//         animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//         animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//         animalNickname = "lola";
//         break;
//     case 1:
//         animalSpecies = "dog";
//         animalID = "d2";
//         animalAge = "9";
//         animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//         animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//         animalNickname = "loki";
//         break;
//     case 2:
//         animalSpecies = "cat";
//         animalID = "c3";
//         animalAge = "1";
//         animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//         animalPersonalityDescription = "friendly";
//         animalNickname = "Puss";
//         break;
//     case 3:
//         animalSpecies = "cat";
//         animalID = "c4";
//         animalAge = "?";
//         animalPhysicalDescription = "";
//         animalPersonalityDescription = "";
//         animalNickname = "";
//         break;
//     default:
//         animalSpecies = "";
//         animalID = "";
//         animalAge = "";
//         animalPhysicalDescription = "";
//         animalPersonalityDescription = "";
//         animalNickname = "";
//         break;


// }

// do
// {
//     readResult = Console.ReadLine();

// } while (menuSelection != "exit");

// integral types 
// Console.WriteLine("this is a signed integral types");

// Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}\n");



// Console.WriteLine("this is an unsigned integral types");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}\n");


// Console.WriteLine("this is a floating point types");

// Console.WriteLine($"float    : {float.MinValue}  to {float.MaxValue}");
// Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal  : {decimal.MinValue}   to {decimal.MaxValue}");

// refrence types(arrays, classes and strings): they store their values on the heap(a memory area shared across many applications runnin on the OS)

// string shortendWorld = "Hello People";
// Console.WriteLine(shortendWorld);

// --- value types --- //
// int val_A = 2;
// int val_B = val_A;

// val_B = 5;
// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

// // --- reference types --- //
// int[] ref_A = [3];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;
// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");



// int first = 2; 
// string second = "4";
// string res = first + second;
// Console.WriteLine(res);



// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int) myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

// string first = "5";
// string second = "7";

// int sum = int.Parse(first) + int.Parse(second);
// int res = Convert.ToInt32(first) * Convert.ToInt32(second);
// Console.WriteLine(res);


// int value = (int)1.5m;// casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);


// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurements( W/offset): {50 + result}");


// string[] values = ["12.3", "45", "ABC", "11", "DEF"];

// decimal total = 0m;
// string message = "";
// decimal number = 0;
// foreach (var item in values)
// {
//     if (decimal.TryParse(item, out number)){
//         total += number;
//     }else{
//         message += item;
//     }

// }

// Console.WriteLine($"AlphabeticMessage: {message}");
// Console.WriteLine($"Total:{total}");


// int val1 = 11;
// decimal val2 = 6.2m;
// float val3 = 4.3f;
// int result1 =Convert.ToInt32(val1 / val2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = val2 / (decimal)val3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = val3 / val1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");



// string[] pallets = ["B14", "A11", "B12", "A13"];


// Console.WriteLine("Sorted Pallets...");

// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine("");
// Console.WriteLine("Reversed Pallets...");

// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 Pallets..... count:{pallets.Length} pallets");
// foreach(var pallet in pallets){
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach(var pallet in pallets){
//     Console.WriteLine($"{pallet}");
// }
// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string val = "abc123";
// char[] valueArray = val.ToCharArray();
// Array.Reverse(valueArray);
// // string res = new(valueArray);
// string res = String.Join("-", valueArray);
// Console.WriteLine(res);

// string[] items = res.Split("-");
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] message = pangram.Split(' ');
// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++){
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new(letters);
// }
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] parsedIDs = orderStream.Split(",");
// Array.Sort(parsedIDs);

// foreach (var parsedID in parsedIDs)
// {
//     if(parsedID.Length == 4){
//         Console.WriteLine(parsedID);
//     }
//     else
//     {
//         Console.WriteLine(parsedID + "\t- Error");
//     }
// }

//composite formatting: 

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {0} {1}", first, second);
// Console.WriteLine(result);

// // string interpolation: used to simplify composite formatting
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// // formatting currency
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"{price:C} (sav {discount:C})");

// // formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($" Measurement: {measurement:N5} units");

// formatting percentages
// decimal tax = 0.36785m;
// Console.WriteLine($" Tax rate is: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("you save {0:c2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice)/price):P2}";
// Console.WriteLine(yourDiscount);

// // display invoice number 
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"    Shrare: {productShares:P3} Product ");
// Console.WriteLine($"        SubTotal: {subtotal:C}");
// Console.WriteLine($"Total : {total:C}");


// padding and alignment
// string input = "Padding";
// Console.WriteLine(input.PadLeft(12));
// overloaded method: method eith with different or extea arguments
// Console.WriteLine(input.PadLeft(12, '-'));


// string paymentId = "769C";
// string payeeName = "Akolade Olanipekun";
// string paymentAmount = "$5,000.00";
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);



// Apply String Interpolation to form a letter 
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;
// string slauteCustomer  = "Dear ";

// string sendLetter= "";
// sendLetter += slauteCustomer;
// sendLetter += customerName;
// sendLetter += "\n";
// sendLetter += $"As a customer of our{currentProduct} we are excited to tell you about a new financial product that would dramatically increase your return.\n";
// sendLetter += $"Currently, you own {currentShares:N} share at a return of {currentReturn:P2}.\n";
// sendLetter += $"Our new product, {newProduct} offers a return of {newReturn:P2}. ";
// sendLetter += $"Given your current volume, your potential profit would be {newProfit:C}";

// Console.WriteLine(sendLetter);
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";
// comparisonMessage += currentProduct.PadRight(20);
// comparisonMessage += $"{currentReturn:P2}".PadRight(10);
// comparisonMessage += $"{currentProfit:C}\n".PadRight(10);
// comparisonMessage += newProduct.PadRight(20);

// comparisonMessage += $"{newReturn:P2}".PadRight(10);
// comparisonMessage += $"{newProfit:C}\n".PadRight(10);
// Console.WriteLine(comparisonMessage);




// indexOf() and Substring()

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');
// openingPosition += 1;

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition,length));

// string message = "What is the value <span>between the tags</span>?";
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// indexOfAny() and LastIndexOf()
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf("(");
//     if (openingPosition == -1)
//         break;
//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
//     message = message[(closingPosition + 1)..];
// }
// int openingPosition = message.LastIndexOf("(");
// openingPosition+=1;
// int closingPosition = message.LastIndexOf(")");
// int length = closingPosition - openingPosition;


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

// Now  find the matching closing symbol
// char matchingSymbol = ' ';

// switch (currentSymbol)
// {
//     case "[":
//         matchingSymbol = ']';
//         break;
//     case "{":
//         matchingSymbol = '}';
//         break;
//     case "(":
//         matchingSymbol = ')';
//         break;
// }

// To find the closingPosition, use an overload of the IndexOf method to specify 
// that the search for the matchingSymbol should start at the openingPosition in the string. 

// openingPosition += 1;
// closingPosition = message.IndexOf(matchingSymbol, openingPosition);

// Finally, use the techniques you've already learned to display the sub-string:

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// }
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Fount with using startPosition {startPosition}: {message[openingPosition..]}");

// remove and replace 
// string data = "12345John Smith          5000 3 ";

// string updateData = data.Remove(5, 20);
// Console.WriteLine(updateData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// replace and remove value for data
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; //
// int quantityEnd = input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// const string tradeSymbol = "&trade";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);


// const string openingDiv = "<div>";
// int divStart = output.IndexOf(openingDiv);
// output = output.Remove(divStart, openingDiv.Length);

// const string closingDiv = "</div>";
// int divCloseStart = output.IndexOf(closingDiv);
// output = $"Output: {output.Remove(divCloseStart, closingDiv.Length)}";

// Console.WriteLine(quantity);
// Console.WriteLine(output);

// Final

// // ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// decimal decimalDonation = 0.00m;

// // array used to store runtime data
// string[,] ourAnimals = new string[maxPets, 7];

// // sample data ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             suggestedDonation = "85.00";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "gus";
//             suggestedDonation = "49.99";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "snow";
//             suggestedDonation = "40.00";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "lion";
//             suggestedDonation = "";

//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";
//             break;
//     }

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//     if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//     {
//         decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
//     }
//     ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
// }

// // top-level menu options
// do
// {
//     // NOTE: the Console.Clear method is throwing an exception in debug sessions
//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();
//     }

//     // switch-case to process the selected menu option
//     switch (menuSelection)
//     {
//         case "1":
//             // list all pet info
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();

//                     for (int j = 0; j < 7; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j].ToString());
//                     }
//                 }
//             }

//             Console.WriteLine("\r\nPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "2":
//             // #1 Display all dogs with a multiple search characteristics

//             string dogCharacteristics = "";

//             while (dogCharacteristics == "")
//             {
//                 // #2 have user enter multiple comma separated characteristics to search for
//                 Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
//                 readResult = Console.ReadLine();

//                 if (readResult != null)
//                 {
//                     dogCharacteristics = readResult.ToLower();
//                     Console.WriteLine();
//                 }
//             }

//             string[] dogSearches = dogCharacteristics.Split(",");
//             // trim leading and trailing spaces from each search term
//             for (int i = 0; i < dogSearches.Length; i++)
//             {
//                 dogSearches[i] = dogSearches[i].Trim();
//             }

//             Array.Sort(dogSearches);
//             // #4 update to "rotating" animation with countdown
//             string[] searchingIcons = {" |", " /", "--", " \\", " *"};

//             bool matchesAnyDog = false;
//             string dogDescription = "";

//             // loops through the ourAnimals array to search for matching animals
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 1].Contains("dog"))
//                 {

//                     // Search combined descriptions and report results
//                     dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
//                     bool matchesCurrentDog = false;

//                     foreach (string term in dogSearches)
//                     {
//                         // only search if there is a term to search for
//                         if (term != null && term.Trim() != "")
//                         {
//                             for (int j = 2; j > -1 ; j--)
//                             {
//                                 // #5 update "searching" message to show countdown
//                                 foreach (string icon in searchingIcons)
//                                 {
//                                     Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
//                                     Thread.Sleep(100);
//                                 }

//                                 Console.Write($"\r{new String(' ', Console.BufferWidth)}");
//                             }

//                             // #3a iterate submitted characteristic terms and search description for each term
//                             if (dogDescription.Contains(" " + term.Trim() + " "))
//                             {
//                                 // #3b update message to reflect current search term match 

//                                 Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

//                                 matchesCurrentDog = true;
//                                 matchesAnyDog = true;
//                             }
//                         }
//                     }

//                     // #3d if the current dog is match, display the dog's info
//                     if (matchesCurrentDog)
//                     {
//                         Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
//                     }
//                 }
//             }

//             if (!matchesAnyDog)
//             {
//                 Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
//             }

//             Console.WriteLine("\n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         default:
//             break;
//     }
// } 
// while (menuSelection != "exit");

// SayHello();

// void SayHello() 
// {
//     Console.WriteLine("Hello World!");
// }
// int[] a = [1,2,3,4,5];
// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (var item in a)
//     {
//         Console.Write($"{item} ");
//     }
//     // Console.WriteLine();
// }

// void DisplayRandomNumbers(){
//     Random random = new();
//     for (int i = 0; i < 5; i++){
//         Console.Write($"{random.Next(1, 100)} ");
//     }
// }
// DisplayRandomNumbers();


// int[] times = [800, 1200, 1600, 2000];
// int diff = 0;



// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();
// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     AdjustTImes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     AdjustTImes();
// }

// Console.WriteLine("New Medicine Schedule:");

// DisplayTimes();

// Console.WriteLine();

// void DisplayTimes()
// {
//     /* Format and display medicine times */

//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");

//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }
//         Console.WriteLine($"{time}");
//     }
//     Console.WriteLine();
// }

// void AdjustTImes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */

//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
// string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }


// Random random = new();
// int luck = random.Next(100);

// string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
// string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
// string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
// string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];

// TellFortune();
// luck = random.Next(100);
// TellFortune();
// void TellFortune()
// {

//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }

// }

// Add Parameters to Methods 
// CountTo(5);

// static void CountTo(int maxNumber){
//     for (int i = 0; i < maxNumber; i++)
//     {
//         Console.WriteLine($"{i}, ");
//     }
// }

// int[] schedule = [800, 1200, 1600, 2000];

// DisplayAdjustedTimes(schedule, 6, -6);

// static void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int timeDifference = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         timeDifference = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         timeDifference = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + timeDifference)) % 2400;
//         Console.WriteLine($"{times[i]} >> {newTime}");
//     }
// }

// Understand Methods Scope

// string[] students = ["Jenna", "Ayesha", "Carlos", "Viktor"];
// DisplayStudents(students);
// DisplayStudents(["Robert","Vanya"]);

// static void DisplayStudents(string[] students){
//     foreach (var student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// double pi = 3.14159;

// PrintCircleArea(radius: 10);
// PrintCirleCircumference(radius: 10);
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area of Circle= {area}");
// }

// void PrintCirleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference of Circle = {circumference}");
// }
// PrintCircleInfo(12);
// PrintCircleInfo(24);
// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"This is a Circle with Radius: {radius}");
//     PrintCircleArea(radius: 10);
//     PrintCirleCircumference(radius: 10);
// }


int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

static void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

