// create arrays of doubles and ints 
double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, }; 

StackTest.Stack<double> doublestack = new (10); // stack of doubles 
StackTest.Stack<int> intstack = new(10); // stack of ints 

TestPushDouble();

// test push method with doubleStack 

void TestPushDouble()
{
    try
    {   Console.WriteLine("\nPushing elements onto doubleStack");

        foreach (var elements in doubleElements)
        {
            Console.WriteLine($"{elements:F1} ");
            doublestack.Push(elements);
        }
    }
    catch (FullStackException exeption )
    {

    }
}