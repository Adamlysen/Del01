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

bool hej = false;
string hello;
int a;

while (hej == false)

{
    Console.WriteLine("Write Something:");
    hello = Console.ReadLine();
    hej = int.TryParse(hello, out a);

    if (hej == false)
    {
        Console.WriteLine("Not Working!");
        Console.ReadLine();
    }
}

Random random = new Random();

int rdmnumber = random.Next(1, 101);

int guess = 0;

while (guess != rdmnumber)
{
    Console.WriteLine("Gissa siffran:");
    try
    {
        guess = int.Parse(Console.ReadLine());

        if (guess > rdmnumber)
        {
            Console.WriteLine("Too high!");
        }

        else if (guess < rdmnumber)
        {
            Console.WriteLine("Too Low!");
        }

        else
        {
            Console.WriteLine("Correct!");
            Console.ReadLine();
        }
    }
    catch
    {
        Console.WriteLine("Error!");
    }
}