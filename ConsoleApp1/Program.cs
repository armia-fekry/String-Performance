using System;


public class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Input: ");
        string input = Console.ReadLine();
        //for more usabilty 
        Console.Write("Decide ShiftBy: ");
        var dd = input.ToCharArray().Length;
        int ShiftBy;
        if (!int.TryParse(Console.ReadLine(), out ShiftBy))
            Console.WriteLine("Wrong Input: Enter Numbers Only..");
        Console.WriteLine(string.Format("Output: {0}" , Shift(in input,ShiftBy)));
    }
    /// <summary>
    /// Shift Function To Shift Word By ShiftBy Times
    /// String.Create is the best performance than stringbuilder and string constuctors
    /// it use defiend string lenth and span<char> to access string buffer 
    /// </summary>
    /// <param name="input">defiend as in so we could avoid 
    ///             coping string values again
    ///  </param>
    /// <param name="shiftBy"></param>
    /// <returns></returns>
    public static string Shift(in string input, int shiftBy)
        => String.Create(input.Length, input.ToCharArray(), (c, b) => {
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < 65 || b[i] > 90|| b.Length==0)
                {
                    Console.Write("Wrong Input , Enter [A-Z] ....");
                    return;
                }
                c[i] = (char)(b[i] + shiftBy);
                if(c[i]>90)
                    c[i]=(char)(65+c[i]-91);
            }
        }); 
	
}