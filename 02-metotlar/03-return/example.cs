int AddNumbers(int number1, int number2)
{
    return number1 + number2;
}

decimal CalculateTotal(decimal price, int quantity)
{
    return price * quantity;
}

int result = AddNumbers(10, 20);
decimal total = CalculateTotal(100, 3);

Console.WriteLine(result);
Console.WriteLine(total);
