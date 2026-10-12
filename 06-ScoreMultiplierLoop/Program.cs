int points = 10;
for(int round=1; round<=5; round++)
{
    Console.WriteLine($"Round {round} : Points = {points*=2}");
}
Console.WriteLine($"Final Score is {points}");