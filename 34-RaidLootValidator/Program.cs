double[] lootDropPrices = {450.0, 300.0, 550.0};
bool isHardcoreMode = true;
double hardCoreBonusRate = 0.15;

Console.WriteLine("<---RPG Raid Loot Validator--->");

double totalBaseLoot = 0.0;
int dropIndex = 1;

foreach(double price in lootDropPrices)
{
    Console.WriteLine($"Drop {dropIndex} Value : {price} Gold");
    totalBaseLoot+=price;
    dropIndex++;
}

Console.WriteLine("-----------------------------------");
Console.WriteLine($"Total Base Loot : {totalBaseLoot} Gold");

double bonusAmount = isHardcoreMode ? (totalBaseLoot*hardCoreBonusRate) : 0.0;
Console.WriteLine(isHardcoreMode
? $"Hardcore Bonus  : +{bonusAmount} Gold ({hardCoreBonusRate*100}%)"
: "Hardcore Bonus : 0 Gold (Normal Mode)");

Console.WriteLine("-----------------------------------");

double totalExactGold = Math.Round(totalBaseLoot + bonusAmount, 2);
int finalGoldCoins = (int)totalExactGold;

Console.WriteLine($"Total Exact Gold : {totalExactGold} Gold");
Console.WriteLine($"Final Gold Coins : {finalGoldCoins} Coins");