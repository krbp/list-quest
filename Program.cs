using System;

public class Program
{
    public static void Main()
    {
        List<string> floatCollection = new List<string>();
        floatCollection.Add("ab");
        floatCollection.Add("cd");
        floatCollection.Add("ef");
        floatCollection.RemoveAt(0);
        floatCollection.Remove("ab");
        floatCollection[1] = "yz";
    }
}
