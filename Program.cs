Console.WriteLine("Task3");
Console.Write("Enter r:");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"l of circle = 2 * P * {r} = {2 * Math.PI * r:F2}");
Console.WriteLine($"S of circle = P * {r} * {r} = {Math.PI * r * r:F2}");
Console.WriteLine($"V of circle = 4/3 * P * {r} * {r} * {r} = {(4.0 / 3.0) * Math.PI * r * r * r:F2}");
