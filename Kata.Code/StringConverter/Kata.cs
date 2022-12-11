namespace Kata.Code;
public class StringConverter
{
    public static Int64 StringToNumber(string a)
    {
        if (Int64.TryParse(a, out Int64 result))
        {
            return result;
        }
        
        return -1;
    }
}