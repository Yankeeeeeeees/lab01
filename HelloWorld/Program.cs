// Console.WriteLine("Привет от ИСП-243");
// Console.WriteLine("Автор: Канаев Денис");
// Console.WriteLine("Год: 2026");
// Информация о студенте
string firstName = "Денис";
string lastName = "Канаев";
string group = "ИСП-243";
int birthYear = 2008;
double gpa = 4.5;
bool hasScholarship = false;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine()!;
Console.WriteLine($"Отлично! {firstName} любит {subject}.");