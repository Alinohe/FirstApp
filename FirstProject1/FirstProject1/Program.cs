//Zadanie 6

using FirstProject1;




User user1 = new User("Adam", "Maron", 35);
user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(3);
user1.AddScore(4);

User user2 = new User("Robert", "Domanski", 50);
user2.AddScore(7);
user2.AddScore(8);
user2.AddScore(9);
user2.AddScore(6);
user2.AddScore(3);

User user3 = new User("Zuzia", "Malinowska", 41);
user3.AddScore(7);
user3.AddScore(4);
user3.AddScore(3);
user3.AddScore(6);
user3.AddScore(3);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User userWithMaxResult = null;

foreach(var user in users)
{
    if(user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}
Console.WriteLine(" Employee with max score is " + " " + " " + userWithMaxResult.Name +  " "  + "" +  userWithMaxResult.Surname + " " + userWithMaxResult.age + " " + " lat " + " z wynikikiem " + " " + " " + " " + maxResult);