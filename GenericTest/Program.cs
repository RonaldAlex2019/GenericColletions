// crear areglos enteros 

using GenericTest;

int []  CharArray = {1, 2, 3 , 4 , 5 , 6};
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

Console.WriteLine("Array intArray contains");
OverloadedMethods.DisplayArrray(CharArray);
Console.WriteLine("Array intArray contains");
OverloadedMethods.DisplayArrray(doubleArray);
Console.WriteLine("Array intArray contains");
OverloadedMethods.DisplayArrray(CharArray);


void DisplayArray<T>(T[] inputArray)
{
    foreach (var item in inputArray)
    {
        Console.WriteLine($"{item} ");
    }

    Console.WriteLine();
   
}