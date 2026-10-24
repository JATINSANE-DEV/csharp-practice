int rawDamage = 80;
float armorResistance = 0.20f;
int playerHealth = 100;

Console.WriteLine($"Player Starting Health : {playerHealth}");
Console.WriteLine($"Incoming Attack Raw Damage : {rawDamage}");

int damageBlocked = (int)(rawDamage*armorResistance);
int damageTaken = rawDamage-damageBlocked;

playerHealth -= damageTaken;

if(playerHealth<0)
{
    playerHealth=0;
}

Console.WriteLine($"Armor Blocked : {damageBlocked} damage ({armorResistance*100}% armor)");
Console.WriteLine($"Damage Taken : {damageTaken}");
Console.WriteLine($"Player final Health : {playerHealth}");