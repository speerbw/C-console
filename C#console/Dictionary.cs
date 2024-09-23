

class Dictionary1
{
    public static void Dict1(String[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>(); 

        phoneBook.Add("Alice","123-345-6789"); 
        phoneBook.Add("Bob","987-654-4321");

        Console.WriteLine(phoneBook["Bob"]);  
    }

    public static void Dict2(String[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        inventory.Add("Apples", 50);
        inventory.Add("Oranges", 30);
        inventory.Add("Bananas", 20);
        inventory.Add("Mangos", 30);
        inventory.Add("Pairs",45);

        foreach (KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
