int currentStamina = 20;
int maxStamina = 60;
int regenPerSec = 10;
int regenTicks = 5;

Console.WriteLine($"Starting Stamina : {currentStamina}/{maxStamina}");

for(int sec =1; sec<=regenTicks; sec++)
{
    currentStamina+=regenPerSec;

    if(currentStamina>maxStamina)
    {
        currentStamina=maxStamina;
    }
    Console.WriteLine($"Second {sec} : Recovered {regenPerSec} Stamina! | Current Stamina : {currentStamina}/{maxStamina}");

    if(currentStamina == maxStamina)
    {
        Console.WriteLine("Stamina Fully Restored!");
        break;
    }
}