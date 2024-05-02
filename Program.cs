// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Kay!");

string myFirstFriend = "          Akolade        "; 
string mySecondFriend = "Emmanuel";

// myFirstFriend = myFirstFriend.TrimStart();
string friends =$"My Friends are {myFirstFriend.Trim()} {mySecondFriend}";


// Console.WriteLine(friends);
Console.WriteLine(friends.StartsWith("My"));
// Console.WriteLine(friends.Replace("Akolade","Isaac"));