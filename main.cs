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

    static void FillingArrayOfResults(string[] arrayInput, string[] arrayRes)
    {
        int desiredSizeOfElement = 3;
        int sizeOfInputArray = arrayInput.Length;
        int indexOfArrayInput = 0;
        int indexOfArrayRes = 0;

        while (indexOfArrayInput < sizeOfInputArray)
        {
            if (arrayInput[indexOfArrayInput].Length <= desiredSizeOfElement)
            {
                arrayRes[indexOfArrayRes] = arrayInput[indexOfArrayInput];
                indexOfArrayRes += 1;
            }
            indexOfArrayInput += 1;
        }
        Print(arrayRes);
    }
  
    public static void Main()
    {

    }
}