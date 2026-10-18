int playerhealth = 100;
int poisonDamagePerTick = 15;
int poisonTicks = 5;

Console.WriteLine($"Starting Health : {playerhealth}");
for(int tick=1; tick<=poisonTicks; tick++)
{
    playerhealth -= poisonDamagePerTick;

    if(playerhealth<0)
    {
        playerhealth = 0;
    }
    
    Console.WriteLine($"Tick {tick} : Took {poisonDamagePerTick} poison damage! Health remaining : {playerhealth}");

    if(playerhealth == 0)
    {
        Console.WriteLine("Player Died!");
        break;
    }
}
