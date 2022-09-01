 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 void FillArray(float[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 20);
index++;
}
}
void PrintArray(float[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count )
    {
        if (position < (count-1))
        {
        Console.Write(col[position]+ ", ");
        position++;
        }
       else 
       {
        Console.Write(col[position] + " ");
        position++;
       }
    }
}
float [] array = new float [8];
FillArray(array);
Console.Write("[ ");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
float maxNumber = array[0];
float minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  float razn = maxNumber - minNumber;
  Console.WriteLine("Максимальное число: " + maxNumber);
  Console.WriteLine("Минимальнре число: " + minNumber);
  Console.WriteLine("разница между максимальным и минимальным элементами: " + razn);
