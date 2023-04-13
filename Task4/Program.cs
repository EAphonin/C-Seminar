Console.Write("Введите первое число: ");
String userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
String userInput2 = Console.ReadLine() ?? "";
Console.Write("Введите третье число: ");
String userInput3 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);
int userNumber3 = int.Parse(userInput3);
int max=userNumber1;
if (userNumber2 > max)
{max=userNumber2; }
if (userNumber3 > max)
{ max=userNumber3; }
Console.WriteLine ($"  a={userNumber1} , b={userNumber2}, c={userNumber3} -> max= {max}");