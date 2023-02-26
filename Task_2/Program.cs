// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 10; // размер массива 10 ячеек
int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}] -> {GetSum(array)}"); // вывод результата


int[] GetArray(int size) //задаем заполняемость массива от 1 до 10
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
  return array;
}

int GetSum(int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length;)
    {
        sum = sum + array[i];
        i = i +2;
    }
    return sum;
}

