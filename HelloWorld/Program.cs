// Console.WriteLine("Привет от ИСП-243");
// Console.WriteLine("Автор: Канаев Денис");
// Console.WriteLine("Год: 2026");
// string firstName = "Денис";
// string lastName = "Канаев";
// string group = "ИСП-243";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = false;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine()!;
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");


// int a = 15;
// int b = 4;

// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");

// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно!");

// Console.WriteLine("Добро пожаловать в анкету!");

// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine()!;
// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine()!;
// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine()!;
// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine()!);
// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine()!);

// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;
// string status = isExcellent ? "Отличник" : "Хорошист";

// Console.WriteLine("Ваша анкета");
// Console.WriteLine($"Имя:          {name} {surname}");
// Console.WriteLine($"Группа:       {group}");
// Console.WriteLine($"Возраст:      {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Статус:       {status}");
// Console.WriteLine($"Лет до 30:    {30 - age}");

// Console.WriteLine("Нажмите Enter для выхода...");
// Console.ReadLine();

//  1
string favoriteGame = "Berserk";
int favoriteNumber = 21;
double pi = 3.1415;
char favoriteLetter = 'П';

Console.WriteLine($"Аниме: {favoriteGame}");
Console.WriteLine($"Число: {favoriteNumber}");
Console.WriteLine($"Число пи: {pi}");
Console.WriteLine($"Любимая буква: {favoriteLetter}");


// 2
Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!");

// 3
Console.WriteLine("\"Hello There\"");

// 4

int monitor = int.Parse(Console.ReadLine());
int systemUnit = int.Parse(Console.ReadLine());
int keyboard = int.Parse(Console.ReadLine());
int mouse = int.Parse(Console.ReadLine());

int pcPrice = monitor + systemUnit + keyboard + mouse;
int total = pcPrice * 3;
Console.WriteLine(total);

// 5

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

long result = 3 * (long)Math.Pow(a + b, 3) + 275L * b * b - 127L * a - 41;
Console.WriteLine(result);

// 6

double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"Температура: {fahrenheit}°F");

