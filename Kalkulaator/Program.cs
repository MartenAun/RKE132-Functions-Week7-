
Console.WriteLine("Enter the operation (+/-):");

char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int FirstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(FirstNum, secondNum);
        break;
    case '-':
        Substraction(FirstNum, secondNum);
        break;
        default:
        Console.WriteLine("wrong operator");
        break;
}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a}+{b}={a+b}");
}
static void Substraction(int a, int b)
{
    Console.WriteLine($"{a}-{b}={a - b}");
}


