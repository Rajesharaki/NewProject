using System;

public class Program
{
    public static void Main(string[] arg)
    {
        //Uc2 code

        int isPartTime = 2;
        int isFullTime = 1;
        int empwageperhr = 20;
        int emphr;

        Random random = new Random();
        int check = random.Next(0, 3);
        if (check ==isFullTime )
        {
            emphr = 8;
        }
        else if(check==isPartTime)
        {
            emphr = 4;
        }
        else
        {
            emphr = 0;
        }
        
        Console.WriteLine("Emp wage is ="+(emphr*empwageperhr));
    }
}