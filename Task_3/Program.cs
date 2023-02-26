// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int size = 10; // размер массива 10 ячеек
int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]"); // вывод результата
int razn = 0;
int max = 0;
int min = 100;
int[] GetArray(int size) //задаем заполняемость массива от 1 до 10
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(1, 100);
  }
  return array;
}
/* не получается так
int GetMin(int[] array) 
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min)
        {
            min = array[i];
            }
    }
    return min; 
}
int GetMax(int[] array)
{ 
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            }
    }
    return max; 
}

razn = max - min;
*/
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) 
    {
        max = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) 
    {
        min = array[i];
    }
}
razn = max - min;
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(razn);



