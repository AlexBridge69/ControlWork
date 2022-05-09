using System;

class Program
{
    static int NumberOfElementsForNewArray(string[] arrayInput)
    {
        int NumberOfElements = 0;
        for (int i = 0; i < arrayInput.Length; i++)
        {
            if (arrayInput[i].Length <= 3)
            {
                NumberOfElements += 1;
            }
        }
        return NumberOfElements;
    }

    public static void Main()
    {

    }
}