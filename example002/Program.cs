void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 20);
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
int [] array = new int [8];
FillArray(array);
Console.Write("[ ");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int sum = 0;
int size = array.Length;
for (int i=0; i<size; i++)
{
    if ((i%2) != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);

