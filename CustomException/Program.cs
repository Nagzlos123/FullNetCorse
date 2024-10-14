using CustomException;

bool isParse;
Console.WriteLine("Program divide two numbers");

Console.WriteLine("Insert first number:");
var firstInputNumber = Console.ReadLine();
isParse = double.TryParse(firstInputNumber, out var firstNumber);

if (isParse == false)
{
    Console.WriteLine("Invalid number");
    return;
}

Console.WriteLine("Insert second number:");
var secondInputNumber = Console.ReadLine();

isParse = double.TryParse(secondInputNumber, out var secondNumber);

if (isParse == false)
{
    Console.WriteLine("Invalid number");
    return;
}
try
{
    if(secondNumber == 0)
    {
        throw new Exception1("U can't divide by 0");
    }
    var result = firstNumber / secondNumber;
    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{

    Console.WriteLine(ex);
}


