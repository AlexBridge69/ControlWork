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

    static void Print(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]}, ");
            }
            else if (i > 0 && i < array.Length - 1)
            {
                Console.Write($"{array[i]}, ");
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}]");
            }
        }
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
        string[] arrayExample1 = { "hello", "2", "world", ":-)" };
        string[] arrayExample2 = { "1234", "1567", "-2", "computer science" };
        string[] arrayExample3 = { "Russia", "Denmark", "Kazan" };

        int numberOfElemntsInExample1 = NumberOfElementsForNewArray(arrayInput: arrayExample1);
        if (numberOfElemntsInExample1 > 0)
        {
            string[] ResultArray1 = new string[numberOfElemntsInExample1];
            FillingArrayOfResults(arrayInput: arrayExample1, arrayRes: ResultArray1);
        }
        else
        {
            Console.WriteLine("[]");
        }

        int numberOfElemntsInExample2 = NumberOfElementsForNewArray(arrayInput: arrayExample2);
        if (numberOfElemntsInExample1 > 0)
        {
            string[] ResultArray2 = new string[numberOfElemntsInExample2];
            FillingArrayOfResults(arrayInput: arrayExample2, arrayRes: ResultArray2);
        }
        else
        {
            Console.WriteLine("[]");
        }

        int numberOfElemntsInExample3 = NumberOfElementsForNewArray(arrayInput: arrayExample3);
        if (numberOfElemntsInExample1 != 0)
        {
            string[] ResultArray3 = new string[numberOfElemntsInExample3];
            FillingArrayOfResults(arrayInput: arrayExample3, arrayRes: ResultArray3);
        }
        else
        {
            Console.WriteLine("[]");
        }
    }
}