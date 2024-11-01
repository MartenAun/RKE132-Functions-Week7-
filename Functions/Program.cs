Console.WriteLine("Are u coming or leaving?");
string userChoice = Console.ReadLine();
if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();  
}


PrintHello();
PrintGoodBye();
static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator");   
}
