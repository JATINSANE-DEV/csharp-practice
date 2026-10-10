int choice = 0;
do
{
    Console.WriteLine(@" Menu :
    1. Start Game
    2. Options
    3. Exit");
    Console.Write("Enter a choice : ");
    choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1)
    {
        Console.WriteLine("Starting game...");
    }
    else if(choice == 2)
    {
        Console.WriteLine("Opening options...");
    }
    else if(choice == 3)
    {
        Console.WriteLine("Exiting... Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid choice, try again!");
    }

}while(choice!=3);