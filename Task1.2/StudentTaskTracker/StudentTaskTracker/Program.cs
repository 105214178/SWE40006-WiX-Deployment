using Humanizer;
using Newtonsoft.Json;

List<string> tasks = new List<string>();

string title = "student task tracker".Titleize();

Console.WriteLine(title);
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

string jsonTasks = JsonConvert.SerializeObject(tasks);

Console.WriteLine("\nTask data in JSON:");
Console.WriteLine(jsonTasks);

Console.WriteLine("\nTask list created successfully.");
Console.WriteLine("Press any key to exit.");

Console.ReadKey();