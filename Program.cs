using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();

        // add thousands of string values to the hashtable
        for (int i = 10000000; i > 1; i--)
        {
            string key = "key" + i.ToString();
            string v = "value" + i.ToString();
            hashtable.Add(key, v);
        }

        // iterate over all key-value pairs in the hashtable
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        
        string[] A = new string[10000000];
        for(int i = 0; i < 10000000; i++)
        {
            A[i] = i.ToString();
        }
        foreach(string s in A)
        {
            Console.WriteLine(s);
        }
        
        Console.ReadLine();
    }
}
