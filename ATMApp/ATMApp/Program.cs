String name;
int balance;

Console.WriteLine("Welocome to the ATM App \nPlease enter your name: ");
name = Console.ReadLine();

Console.WriteLine($"Hello {name}, please enter your initial balance: ");
try
{
    balance = int.Parse(Console.ReadLine());
    Console.WriteLine("Withdrawal amount: ");
    balance -= int.Parse(Console.ReadLine());

    if(balance < 0)
    {
        Console.WriteLine("Insufficient funds. Please enter a valid withdrawal amount.");
    }
    else
    {
        Console.WriteLine($"Withdrawal successful. \nUpdated balance: {balance}" +
            $"\nTransaction Time: {DateTime.Now}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
catch (OverflowException) 
{
    Console.WriteLine("Input value is too large or too small. Please enter a valid number.");
}


