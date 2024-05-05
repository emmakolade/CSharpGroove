
// string myFirstFriend = "          Akolade        "; 
// string mySecondFriend = "Emmanuel";

// myFirstFriend = myFirstFriend.TrimStart();
// string friends =$"My Friends are {myFirstFriend.Trim()} {mySecondFriend}";


// Console.WriteLine(friends);
// Console.WriteLine(friends.StartsWith("My"));
// Console.WriteLine(friends.Replace("Akolade","Isaac"));

// decimal a = 42.1M;
// decimal b = 38.2M;
// // long c = (long)a + (long)b;
// decimal c = a + b;

// Console.WriteLine($"the answer is {c}");

// int a = 5;
// int b = 3;
// int c = 4;

// // bool myTest = c > 10;

// if ((a + b + c > 10) || (a == b)) {
//      Console.WriteLine($"the answer is greater than 10");
//      Console.WriteLine($"and the first nuber is equal to the second number");
// }
// else {
//     Console.WriteLine($"the answer is lower than 10");
//     Console.WriteLine($"the the first nuber is not equal to the second number");
// }

// int counter = 10;
// // counter = counter + 1;
// do
// {
//     counter++;
//     Console.WriteLine(counter);
// }
// while (counter < 5);

// For Loops 
// for (int _init = 0; _init < 5; _init++){
//     Console.WriteLine(_init);
// }

// for (int row = 1; row < 11; row++) {
//     for (char col = 'a'; col < 'k'; col++){
//         Console.WriteLine($"The cell is ({row}, {col})");

//     }
// }

// List<T>
// T means Type

// var names = new List<string>
// {
//     "James",
//     "Akolade",
//     "Isaac",
//     "Love",
//     "Damian"
// }; 
//creating an object with new
// for(int i = 0; i < names.Count; i++){
//     Console.WriteLine($"Hello {names[i].ToUpper()}");
// }
// foreach (var people in names)
// {
//     Console.WriteLine($"Hello {people.ToUpper()}");
// }

// to get the last item in the array, it is the length of the array  minus 1

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
// // foreach (var item in numbers)
// // {
// //     Console.WriteLine($"Hello {item}");
// // }

// LING : Language Integrated Query
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


// OOP:
var p1 = new MyPerson("Akolade", "James", new DateOnly(2024, 1, 1));
var p2 = new MyPerson("Kolade", "James", new DateOnly(2024, 1, 1));

p1.Pets.Add(new Cat("fred"));
p2.Pets.Add(new Cat("halley"));
List<MyPerson> people = [p1, p2];

foreach( var person in people){
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets){
        Console.WriteLine($"{pet}");
    
    }
}
// Console.WriteLine(people.Count);
public class MyPerson(string first, string last, DateOnly bd)
{
    public string firsname = first;

    public string lastname = last;
    public DateOnly dateofbirth = bd;
    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"{firsname} {lastname}";
    }
}

public abstract class Pet(string first)
{
    public string firsname = first;
    public abstract string MakeNoise();
    public override string ToString()
    {
        return $"{firsname} I am a {GetType().Name} and I make {MakeNoise()}";
    }

}
public class Cat(string first) : Pet(first)
{

    public override string MakeNoise() => "meow";

}