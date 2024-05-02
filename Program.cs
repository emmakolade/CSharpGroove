
// string myFirstFriend = "          Akolade        "; 
// string mySecondFriend = "Emmanuel";

// myFirstFriend = myFirstFriend.TrimStart();
// string friends =$"My Friends are {myFirstFriend.Trim()} {mySecondFriend}";


// Console.WriteLine(friends);
// Console.WriteLine(friends.StartsWith("My"));
// Console.WriteLine(friends.Replace("Akolade","Isaac"));

int a = 2100000000;
int b = 2100000000;
// long c = (long)a + (long)b;
long c = checked(a + b);

Console.WriteLine(c);