/* Дополнительно
Дан список некоторых целых чисел,
найдите значение 20 в нем и, если оно присутствует,
замените его на 200. Обновите список только при первом вхождении числа 20.
[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20] */

void IntListSubst()
{
List<int> Ints = new List<int>(); // Список целых чисел
int n = new Random().Next(10, 100);
string end = string.Empty;
for (int i = 0; i < n; i++)
    {
        Ints.Add(new Random().Next(20, 30));
    }

Console.WriteLine();
Console.WriteLine("Создан список случайных целых чисел: " + String.Join(", ", Ints) + ".");
Console.WriteLine();
if (n % 10 == 1) end = "";
else if (n % 10 == 2 || n % 10 == 3 || n % 10 == 4) end = "а";
else end = "ов";
Console.WriteLine($"Созданный список соодержит {n} элемент" + end + ".");
Console.WriteLine();

int indexOf1st20 = Ints.FindIndex(x => x == 20);
Ints[indexOf1st20] = 200;

Console.WriteLine("После замены в списке первого найденного числа (20) на число (200)");
Console.WriteLine("список становится таким: "+ String.Join(", ", Ints) + ".");
Console.WriteLine();
}
IntListSubst();