if (6 >= 3)
{
    Console.WriteLine("Hello World!");
}

Console.WriteLine("Enter your username:");
string username = Console.ReadLine();

Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

if (username == "kalleanka" && password == "12345")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Wrong username or password");
}
for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World!");
}
string correctPassword = "12345";
string inputPassword;

do
{
    Console.WriteLine("Enter your password:");
    inputPassword = Console.ReadLine();

    if (inputPassword != correctPassword)
    {
        Console.WriteLine("Wrong password, try again.");
    }
} while (inputPassword != correctPassword);

Console.WriteLine("Access granted!");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    if (number > 5)
    {
        Console.WriteLine("Högre än 5!");
    }
}

