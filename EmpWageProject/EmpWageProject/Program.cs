using System;

public class Program
{
    public static void Main(string[] arg)
    {
        //Uc1 code

        int isPresen = 1;

        Random random = new Random();
        int check = random.Next(0, 1);
        if (check == isPresen)
        {
            Console.WriteLine("Emp Present");
        }
        else
        {
            Console.WriteLine("Emp Absent");
        }
    }
}