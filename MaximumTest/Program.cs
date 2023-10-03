﻿Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}\n");
Console.WriteLine($"Maximum of 6.6, 8.8 and 7.7 is {Maximum(6.6, 8.8, 7.7)}\n");
Console.WriteLine($"Maximum of pear , apple and orange is {Maximum("pear", "apple", "orange")}\n");

T Maximum <T>(T v1, T v2, T v3) where T : IComparable<T>
 {
   var max = v1;

    if ( v2.CompareTo(max) > 0)
    {
        max = v2;

    }

    if ( v3.CompareTo(max) > 0)
    {
        max = v3;
    }

    return max; 
 }