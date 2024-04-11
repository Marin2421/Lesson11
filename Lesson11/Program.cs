//Домашнее задание. Тема 11. Урок 1. Условный оператор.
int count = 0;
int count2 = 0;
int max = int.MinValue;
int min = int.MaxValue;

Console.Write("Введите первое число:");
int n1 = int.Parse(Console.ReadLine());
if (n1 > 10) count++;
else if (n1 < -10) count2++;
if (n1 < min) min = Math.Min(min, n1);
if (n1 > max) max = Math.Max(max, n1);

Console.Write("Введите второе число:");
int n2 = int.Parse(Console.ReadLine());
if (n2 > 10) count++;
else if (n2 < -10) count2++;
if (n2 < min) min = Math.Min(min, n2);
if (n2 > max) max = Math.Max(max, n2);

Console.Write("Введите третие число:");
int n3 = int.Parse(Console.ReadLine());
if (n3 > 10) count++;
else if (n3 < -10) count2++;
if (n3 < min) min = Math.Min(min, n3);
if (n3 > max) max = Math.Max(max, n3);

Console.Write("Введите четвёртое число:");
int n4 = int.Parse(Console.ReadLine());
if (n4 > 10) count++;
else if (n4 < -10) count2++;
if (n4 < min) min = Math.Min(min, n4);
if (n4 > max) max = Math.Max(max, n4);

Console.Write("Введите пятое число:");
int n5 = int.Parse(Console.ReadLine());
if (n5 > 10) count++;
else if (n5 < -10) count2++;
if (n5 < min) min = Math.Min(min, n5);
if (n5 > max) max = Math.Max(max, n5);

Console.Write("Введите шестое число:");
int n6 = int.Parse(Console.ReadLine());
if (n6 > 10) count++;
else if (n6 < -10) count2++;
if (n6 < min) min = Math.Min(min, n6);
if (n6 > max) max = Math.Max(max, n6);

Console.Write("Введите седьмое число:");
int n7 = int.Parse(Console.ReadLine());
if (n7 > 10) count++;
else if (n7 < -10) count2++;
if (n7 < min) min = Math.Min(min, n7);
if (n7 > max) max = Math.Max(max, n7);

Console.Write("Введите восьмое число:");
int n8 = int.Parse(Console.ReadLine());
if (n8 > 10) count++;
else if (n8 < -10) count2++;
if (n8 < min) min = Math.Min(min, n8);
if (n8 > max) max = Math.Max(max, n8);

Console.Write("Введите девятое число:");
int n9 = int.Parse(Console.ReadLine());
if (n9 > 10) count++;
else if (n9 < -10) count2++;
if (n9 < min) min = Math.Min(min, n9);
if (n9 > max) max = Math.Max(max, n9);

Console.Write("Введите десятое число:");
int n10 = int.Parse(Console.ReadLine());
if (n10 > 10) count++;
else if (n10 < -10) count2++;
if (n10 < min) min = Math.Min(min, n10);
if (n10 > max) max = Math.Max(max, n10);

int sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
int sArifm = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;

Console.WriteLine($"Сумма всех чисел: {sum}");
Console.WriteLine($"Всего чисел, которые больше 10: {count}");
Console.WriteLine($"Всего чисел, которые меньше -10: {count2}");
Console.WriteLine($"Среднее арифметическое всех чисел: {sArifm}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");

//Домашнее задание. Тема 11. Урок 2. Условный оператор.
string a = "Слон";
string b = "Жираф";
string c = "Лев";
string d = "Медведь";
string e = "Волк";
string f = "Пингвин";
string g = "Кенгуру";
Console.Write("Введите температуру в цельсиях:");
int t =  int.Parse(Console.ReadLine());
if (t > 20 && t < 50) Console.WriteLine($"Животные, которых можно выпустить: {a}, {b}, {c}");
else if (t < 20 && t > -50) Console.WriteLine($"Животные, которых можно выпустить: {d}, {e}, {f}");
else if (t == 20) Console.WriteLine($"Можно выпустить только {g}");
else Console.WriteLine("Никого нельзя выпускать!");