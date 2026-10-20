int stamina = 50;
int drainPerSec = 12;
int sprintDuration = 5;

Console.WriteLine($"Starting Stamina : {stamina}");

for(int sec = 1; sec<=sprintDuration; sec++)
{
    stamina-=drainPerSec;

    if(stamina<0)
    {
        stamina = 0;
    }

    Console.WriteLine($"Second {sec} : Drained {drainPerSec} Stamina! Remaining : {stamina}");

    if(stamina==0)
    {
        Console.WriteLine("The Player is exhausted! Speed Reduced");
        break;
    }
}