using System;
 
    public static class Program 
{ public static void Main() 
    { int number; for (number = 100; number < 1000; number++) 
            if (number % 100 * 10 + number / 100 == 564) 
                Console.WriteLine(number); 
    } 
} 
 
