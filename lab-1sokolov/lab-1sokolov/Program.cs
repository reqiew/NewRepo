//вариант 17
//задание 1
// уровень сложный
//Console.Write("введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("введите y:");
//double y = double.Parse(Console.ReadLine());
//double T = (Math.Sqrt(x+b-a)+Math.Log(y)) / (Math.Atan(b+a));
//Console.WriteLine($"T = {T:F2}");

//задание 2 
//средний уровень
const double x = 0.9;
const double t = 2;
double b = Math.Pow(Math.Log(Math.Abs(x)), 2);
double a = t * x + Math.Abs(Math.Sqrt(b));
double y = Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
Console.WriteLine($"y = {y}");
