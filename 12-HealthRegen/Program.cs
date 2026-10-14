int RegenerationHealth(int currentHealth, int healAmount, int maxHealth)
{
    int totalHealth = currentHealth+healAmount;
    if(totalHealth>maxHealth)
    {
        return maxHealth;
    }
    else
    {
        return totalHealth;
    }
}

int health = 80;
int potion = 30;
int maxCap = 100;
int finalHealth = RegenerationHealth(health, potion, maxCap);
Console.WriteLine($"Initial Health : {health}");
Console.WriteLine($"Potion Applied : {potion}");
Console.WriteLine($"Final Health : {finalHealth}/{maxCap}");