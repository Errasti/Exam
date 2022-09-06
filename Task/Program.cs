void ModifyArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)

    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}