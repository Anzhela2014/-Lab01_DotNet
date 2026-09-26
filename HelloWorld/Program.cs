// Console.WriteLine("Привет от ИСП-242!");
// Console.WriteLine("Автор: Резник Анжелика Ильинична");
// Console.WriteLine("Год: 2026");
// 7.3. Объявление и присвоение значения
// int age = 17;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Анжелика";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// string group = "ИСП-242";
// bool isBudget = false;

// Console.WriteLine(group);
// Console.WriteLine("Бюджет: " + isBudget);

// var city = "Волжский";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;

// string myName = "Анжелика";
// int myAge = 17;
// string myGroup = "ИСП-242";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");
// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}!");

// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);

string firstName = "Анжелика";
string lastName = "Резник";
string group = "ИСП-242";
int birthYear = 2009;
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

Console.WriteLine();
Console.Write("Введите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");