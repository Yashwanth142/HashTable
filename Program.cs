namespace HashTable
{
    class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Welcome to Hashtable Program");
            LinkedHashMap<string, int> linkedhashmap = new LinkedHashMap<string, int>(5);

            string Sentence = "paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = Sentence.Split(" ");
            Console.Write("Enter the word you want to omit: ");
            string Banned_Word = Console.ReadLine();
            foreach (string word in Words)
            {
                if (word != Banned_Word)
                {
                    int Value = linkedhashmap.Get(word);
                    if (Value == default)
                        Value = 1;
                    else Value++;
                    linkedhashmap.Add(word, Value);
                }
            }
            int Frequency = linkedhashmap.Get(Banned_Word);
            Console.WriteLine("\n\"{0}\" comes {1} times in the given paragraph now",
                Banned_Word, Frequency);
            Console.WriteLine("\nResulting paragraph:\n" + linkedhashmap.Result);
        }
    }
}