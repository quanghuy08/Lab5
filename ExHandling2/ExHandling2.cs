

using System;

public class InvalidInput : ApplicationException
{
    public InvalidInput(): base("Enter a number greater than Zero"){}
}

class TextExcep
{
    public static void Main()
    {
        int intCnt;
        int intNum = 0;
        Console.WriteLine("Enter a number : ");
        try
        {
            intNum = Convert.ToInt32(Console.ReadLine());
            if (intNum <= 0)
            {
                throw new InvalidInput();
            }
        }
        catch (InvalidInput objInvalidInput)
        {
            Console.WriteLine(objInvalidInput.Message);
        }

        catch (System.FormatException objFormatException)
        {
            Console.WriteLine(objFormatException.Message);
        }
        finally
        {
            if (intNum > 0)
            {
                for (intCnt = 1; intNum <= 10; intNum++)
                {
                    Console.WriteLine(intCnt * intCnt);
                }
            }
        }

        Console.ReadLine();
    }
}
