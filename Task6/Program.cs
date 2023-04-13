Console.Write("Введите число: ");
String userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber % 2 == 0)
{ Console.WriteLine($"  {userNumber} -> Число чётное  "); }
else { Console.WriteLine($"  {userNumber} -> Число нечётное  "); }