

class Loops
{
    public static void ForLoops()
    {
        
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

   
    }

    public static void HealthLoop()
    {
        int health = 100;
        while(health >= 0)
        {
            Console.WriteLine("Player is alive with health: " + health);
            health -= 10;
        }
    }

   public static void NestedLoops()
    {
        for(int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Iteration: i " + i);
            for(int j = 0; j <= 2; j++)
            {
                Console.WriteLine("    Iteration: j " + j);
                for(int k = 0; k <= 2; k++)
            {
                Console.WriteLine("        Iteration: k " + k);
                
            } 
            } 
        } 
    }
    public static void dowhile()
    {
        int number;

        do
        {
            Console.Write("Enter a number greate than 0: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number <= 0);
        Console.WriteLine("You Entered: " + number);
    }
}
