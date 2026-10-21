int health = 100;
int shield = 30;
int incomingDamage = 45;
Console.WriteLine($"Initial Health -> Health : {health} | Shield : {shield}");
Console.WriteLine($"Incoming Attack Damage : {incomingDamage}");

if(incomingDamage<=shield)
{
    shield-=incomingDamage;
}
else
{
    int excessDamage = incomingDamage-shield;
    shield = 0;
    health -= excessDamage;

    if(health<0)
    {
        health=0;
    }
    Console.WriteLine($"Shield Broke! Excess {excessDamage} damage hit health.");
}
Console.WriteLine($"Final State -> Health : {health} | Shield : {shield}");