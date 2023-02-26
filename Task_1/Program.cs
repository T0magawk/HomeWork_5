// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int size = 10; // размер массива 100 ячеек
int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}] -> {GetFind(array)}"); // вывод результата


int[] GetArray(int size) //задаем заполняемость массива от 100 до 999
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(100, 999);
  }
  return array;
}

int GetFind(int[] array) //поиск количества четных числе в массиве 
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) 
    {
        count++;
    }
  }
  return count;
}