Console.Write("Введите N: ");
String userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput); ;
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.Write($" {i} ");
