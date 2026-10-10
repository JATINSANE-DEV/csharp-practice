string? correctPass = "open sesame";
string? enteredPass = "0";
while(correctPass!=enteredPass)
{
    Console.Write("Enter the magic words : ");
    enteredPass = Console.ReadLine();

    if(correctPass!=enteredPass)
    {
        Console.WriteLine("The gate remains shut. Try again!");
    }
}
Console.WriteLine("The magic gate opens! Welcome, adventurer.");