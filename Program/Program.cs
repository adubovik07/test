Console.Write("Задайте размер массива:");
int m = Convert.ToInt32(Console.ReadLine());

string [] arrayA = new string [m];
string[] arrayB = new string[arrayA.Length];

array(arrayA);
GetNewArray(arrayA, arrayB);
PrintArray(arrayB);

void array(string [] arrayA)
{
  for (int i = 0; i<arrayA.Length; i++)
  {
    Console.WriteLine($"Введите {i+1} элемент массива");
    arrayA[i] = Console.ReadLine();
  }
}


void GetNewArray(string[] arrayA, string[] arrayB)
{
    int b = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if(arrayA[i].Length <= 3)
        {
            arrayB[b] = arrayA[i];
            b++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
