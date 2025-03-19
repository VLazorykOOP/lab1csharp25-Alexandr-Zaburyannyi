using System;
using System.Globalization;


 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);
    double p = 4 * Math.Sqrt(s);
    Console.WriteLine("p=" + p);

}
Console.WriteLine("Lab 1 !");
task1();
// See https://aka.ms/new-console-template for more information

static void task1_11()
{
    Console.WriteLine("Enter the coordinates of the vertices of the triangle:");
    
    Console.Write("x1= ");
    float x1 = float.Parse(Console.ReadLine());
    Console.Write("y1= ");
    float y1 = float.Parse(Console.ReadLine());
    
    Console.Write("x2= ");
    float x2 = float.Parse(Console.ReadLine());
    Console.Write("y2= ");
    float y2 = float.Parse(Console.ReadLine());
    
    Console.Write("x3= ");
    float x3 = float.Parse(Console.ReadLine());
    Console.Write("y3= ");
    float y3 = float.Parse(Console.ReadLine());

    double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
    double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

    double perimeter = side1 + side2 + side3;

    Console.WriteLine("The perimeter of the triangle is: " + perimeter);
}

static void task2_11()
{
    Console.Write("Enter a two-digit number: ");
    int number = int.Parse(Console.ReadLine());

    if (number < 10 || number > 99)
    {
        Console.WriteLine("The number is not a two-digit number.");
        return;
    }

    int sumOfDigits = (number / 10) + (number % 10);

    if (sumOfDigits % 3 == 0)
    {
        Console.WriteLine("The sum of the digits is divisible by three.");
    }
    else
    {
        Console.WriteLine("The sum of the digits is not divisible by three.");
    }
}
 
static void task3_12()
{
    Console.Write("Enter x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    if (x > 0 && x < 50 && y > -25 && y < 25)
    {
        Console.WriteLine("Yes");
    }
    else if (x < 0 || x > 50 || y < -25 || y > 25)
    {
        Console.WriteLine("No");
    }
    else
    {
        Console.WriteLine("On the border");
    }
}
 
static void task4_11()
{
    Console.Write("Enter the number of months (m > 0): ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Enter the number of days (n > 0): ");
    int n = int.Parse(Console.ReadLine());

    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Both m and n must be greater than 0.");
        return;
    }

    DateTime startDate = new DateTime(1990, 1, 1);
    DateTime currentDate = startDate.AddMonths(m).AddDays(n);

    string currentMonthName = currentDate.ToString("MMMM", CultureInfo.InvariantCulture);
    Console.WriteLine("The current month is: " + currentMonthName);
}
 
static void task5_11()
{
    Console.Write("Enter the first integer: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter the second integer: ");
    int b = int.Parse(Console.ReadLine());

    int product = a * b;
    int squareOfProduct = product * product;

    Console.WriteLine("The square of the product of the two integers is: " + squareOfProduct);
}
static void task6_11()
{
    Console.Write("Enter x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    double denominator = x * y + 1;
    if (denominator == 0)
    {
        Console.WriteLine("Error denominator cannot be equal to 0.");
        return;
    }

    double result = ((x * y * y + x * x * y) / denominator) * (x - y);
    Console.WriteLine($"Result: {result}");
}
 
Console.WriteLine("Lab 1 !");
task1();
task1_11();
task2_11();
task3_12();
task4_11();
task5_11();
task6_11();


// continue ... 

