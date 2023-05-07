Console.Write("Enter first number : ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number : ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operation symbol : + - * / % : ");
string opr = Console.ReadLine();

if (opr == "+")
{
    Console.Write(num1 + num2);
}
else if (opr == "-")
{
    Console.Write(num1 - num2);
}
else if (opr == "*")
{
    Console.Write(num1 * num2);
}
else if (opr == "/")
{
    Console.Write(num1 / num2);
}
else if (opr == "%")
{
    Console.Write(num1 % num2);
}
