using System.Linq;
namespace Codewars;

public static class CodeWars
{
    // 1) https://www.codewars.com/kata/56170e844da7c6f647000063
    public static string PeopleWithAgeDrink(int old)
    {
        switch (old)
        {
            case < 14:
                return "drink toddy";
            case < 18:
                return "drink coke";
            case < 21:
                return "drink beer";
            default:
                return "drink whisky";
        }
    }
    
    // 2) https://www.codewars.com/kata/59342039eb450e39970000a6
    public static ulong OddCount(ulong n)
    {
        return n/2;
    }
    
    // 3) https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
    public static string AbbrevName(string name)
    {
        return char.ToUpper(name[0]) + "." + char.ToUpper(name[name.IndexOf(" ")+1]);
    }
    
    // 4) https://www.codewars.com/kata/56676e8fabd2d1ff3000000c
    public static string FindNeedle(object[] haystack)
    {
        int n = Array.IndexOf(haystack, "needle");
        return "found the needle at position " + n;
    }
    
    // 5) https://www.codewars.com/kata/5808dcb8f0ed42ae34000031
    public static string SwitchItUp(int number)
    {
        switch(number)
        {
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "";
        }      
    }
    
    // 6) https://www.codewars.com/kata/555086d53eac039a2a000083
    public static bool lovefunc(int flower1, int flower2)
    { 
        return ( flower1 % 2 + flower2 % 2 == 1);
    }
    
    // 7) https://www.codewars.com/kata/544675c6f971f7399a000e79
    public static int StringToNumber(String str)
    {
        return (int.Parse(str));
    }
    
    // 8) https://www.codewars.com/kata/515e271a311df0350d00000f
    
    
    public static int SquareSum(int[] numbers)
    { 
        return numbers.Select(n => n * n).Sum(); 
    }
    
    // 9) https://www.codewars.com/kata/5265326f5fda8eb1160004c8
    public static string NumberToString(int num)
    {
        return num.ToString();
    }
    
    // 10) https://www.codewars.com/kata/53da3dbb4a5168369a0000fe
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
    
    


}