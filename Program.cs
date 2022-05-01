//.Задача 34:

/*
var array = "[345, 897, 568, 234]";

for (var i = 0; i < array.Length; i++)
{
  if ((array[i] % 2) == 0)
  {
  	Console.Write(array[i]);
  }

}
*/

//.Задача 36
/*
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
  Console.Write("Введите элемент { 0 } :" + i.ToString());
  a[i] = int.Parse(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < n; i++)
{
  if (a[i] % 2 != 0)
  ++count;
}

Console.WriteLine("Количество нечетных элементов: " + count.ToString());
*/

/*

int result = 0;

int[] arrayA = new int[5]; // собственно массив

int lengthA = arrayA.Length; // его размер

for (int i = 1; i <= lengthA; i++)
if( arrayA[i] % 2 != 0 ) // проверка на чет/нечет
result = result + 1;

Console.WriteLine(result);
*/


//.Задача 38
/*
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
int [] mass  = new int[n];      // Создаём массив
Random rnd = new Random();      // Создание объекта для генерации чисел
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-50, 50);  // Заполнение рандомами
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
*/



