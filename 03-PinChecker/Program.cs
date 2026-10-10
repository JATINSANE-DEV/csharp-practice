int correctPin = 1234;
int enteredPin = 0;
while(correctPin!=enteredPin)
{
    Console.Write("Pin Required : ");
    enteredPin = Convert.ToInt32(Console.ReadLine());

    if(correctPin!=enteredPin)
    {
        Console.WriteLine("Pin Invalid! Access Prohibited");
    }
}
Console.WriteLine("Access Granted!");
