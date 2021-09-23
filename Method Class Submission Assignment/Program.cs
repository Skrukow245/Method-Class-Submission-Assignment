using System;




class Program
{
    public static void Main(string[] args)
    {
        var addition = new Math();
        int input1 = 5;
        int input2 = 4;
        int result;
        addition.Add(input1, input2, out result);
        Console.WriteLine(result);
        Console.ReadLine();
    }

}

