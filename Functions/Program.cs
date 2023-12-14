Console.WriteLine("Arew you coming or leaving?(in/out):");

string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello()
{
    Console.WriteLine("hello word");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later aligator");
}



