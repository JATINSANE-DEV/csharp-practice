for(int wave=1; wave<=10; wave++)
{
    if(wave==5)
    {
        Console.WriteLine("Wave 5 is a Safe Wave! Skipped.");
        continue;

    }
    else if(wave == 8)
    {
        Console.WriteLine("Boss Zombie appeared! Defense failed.");
        break;
    }
    else
    {
        Console.WriteLine($"Defended Wave {wave}!");
    }
}