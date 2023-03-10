namespace HashTable
{
    class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hashtable Program");
        LinkedHashMap<string, int> linked_hash_map = new LinkedHashMap<string, int>(5);

        string Sentence = "to be or not to be";
        string[] Words = Sentence.Split(" ");
        foreach (string word in Words)
        {
            int Value = linked_hash_map.Get(word);
            if (Value == default)
                Value = 1;
            else Value++;
            linked_hash_map.Add(word, Value);
        }
        int Frequency = linked_hash_map.Get("to");
        Console.WriteLine(Frequency);
    }
}
}