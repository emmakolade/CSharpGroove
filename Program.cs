
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
using System.Runtime.Serialization;
using System.Security.Cryptography;

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
Console.WriteLine("this is a signed integral types");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}\n");



Console.WriteLine("this is an unsigned integral types");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}\n");


Console.WriteLine("this is a floating point types");

Console.WriteLine($"float    : {float.MinValue}  to {float.MaxValue}");
Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal  : {decimal.MinValue}   to {decimal.MaxValue}");

// refrence types(arrays, classes and strings): they store their values on the heap(a memory area shared across many applications runnin on the OS)

string shortendWorld = "Hello People";
Console.WriteLine(shortendWorld);

// --- value types --- //
int val_A = 2;
int val_B = val_A;

val_B = 5;
Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

// --- reference types --- //
int[] ref_A = [3];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;
Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");


