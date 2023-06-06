namespace NAI_8.Services;

public static class Extensions
{
    public static string Reverse(this string s )
    {
        var chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}