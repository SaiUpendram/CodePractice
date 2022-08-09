using System;
					
public class Program
{
	public static void Main()
	{
		DataStore<string> strStore = new DataStore<string>();
		strStore.Data = "String datatype";
		Console.WriteLine(strStore.Data);
		
		DataStore<int> intStore = new DataStore<int>();
		intStore.Data = 10;
		Console.WriteLine(intStore.Data);

		KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
		kvp1.Key = 101;
		kvp1.Value = "String type";
		Console.WriteLine(kvp1.Key + ", " + kvp1.Value);

		
		KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
		kvp2.Key = "Key";
		kvp2.Value = "Value";
		Console.WriteLine(kvp2.Key + ", " + kvp2.Value);
	}
}

class DataStore<T>
{
    public T Data { get; set; }
}

class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}
