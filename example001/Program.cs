//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(100, 999);
index++;
}
}
void PrintArray(int[] col)
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
int [] array = new int [10];
FillArray(array);
Console.Write("[ ");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int kol = 0;
int size = array.Length;
for (int i=0; i<size; i++)
{
    if ((array[i]%2) ==0)
    {
        kol= kol+1;
    }
}
Console.WriteLine("Колличество четных чисел в массиве: " + kol);
