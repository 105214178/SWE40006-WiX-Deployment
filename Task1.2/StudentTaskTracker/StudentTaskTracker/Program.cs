List<string> tasks = new List<string>();

Console.WriteLine("Student Task Tracker");
Console.WriteLine("--------------------");

Console.Write("Enter your first task: ");
string task1 = Console.ReadLine() ?? "";

Console.Write("Enter your second task: ");
string task2 = Console.ReadLine() ?? "";

tasks.Add(task1);
tasks.Add(task2);

Console.WriteLine("\nYour tasks are:");

Console.WriteLine("1. " + tasks[0]);
Console.WriteLine("2. " + tasks[1]);

Console.WriteLine("\nTask list created successfully.");
Console.WriteLine("Press any key to exit.");

Console.ReadKey();