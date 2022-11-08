using System;

class Program
{
    public static void Main(string[] args)
    {
        //int[] ages = new int[] { 25, 27, 23, 34, 36 };
        //Console.WriteLine(25, 27, 23, 34, 36);
        int[] ages = new int[5];
        ages[0] = 25;
        ages[1] = 27;
        ages[2] = 23;
        ages[3] = 34;
        ages[4] = 36;
        int totalAge = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(ages[i]);
            totalAge += ages[i];
        }
        //int totalAge = myAge + yourAge + suziesAge + bobbysAge + jimsAge;
        //Console.WriteLine(totalAge);
    }
}