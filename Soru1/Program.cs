
using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var codes = AddCodeList();
        Console.WriteLine(string.Join("\t", codes));
    }
    private static List<string> AddCodeList()
    {
        List<string> codes = new List<string>();
        string generated_code = "";
        bool control = false;
        for (int i = 0; i < 1000; i++)
        {
            generated_code = CreateCode();
            control = CodeUniqueControl(codes, generated_code);
            if (!control)
            {
                codes.Add(generated_code);
            }
            else
            {
                --i;
            }

        }
        return codes;

    }

    private static string CreateCode()
    {
        int length = 8;
        string validChars = "ACDEFGHKLMNPRTXYZ234579";
        Random random = new Random();
        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }
        return new string(chars);

    }

    private static bool CodeUniqueControl(List<string> codes, string code)
    {
        return codes.Contains(code);

    }
}
