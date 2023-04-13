Console.Write("Введите первое число: ");
String userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
String userInput2 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);
if (userNumber1 > userNumber2)
{ Console.WriteLine($" a={userNumber1}, b={userNumber2} -> max={userNumber1}  "); }
else
{ Console.WriteLine($" a={userNumber1}, b={userNumber2} -> max={userNumber2}  "); }