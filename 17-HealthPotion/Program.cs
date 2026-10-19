int playerHealth = 40;
int maxHealth = 100;
int healPerTick = 15;
int healTicks = 5;

Console.WriteLine($"Starting Health : {playerHealth}");

for(int tick=1; tick<=healTicks; tick++)
{
    playerHealth+=healPerTick;

    if(playerHealth>maxHealth)
    {
        playerHealth = maxHealth;
    }

    Console.WriteLine($"Tick {tick} : Healed {healPerTick} HP! Health remaining : {playerHealth}/{maxHealth}");

    if(playerHealth == maxHealth)
    {
        Console.WriteLine("Heath fully restored!");
        break;
    }
}