double[] baseGearPrices = {1200.0, 450.0, 850.0, 300.0};
int playerLevel =15;
double highLevelDiscountRate =0.10;
double serverTaxRate = 0.05;

Console.WriteLine("<----RPG Equipment Checkout--->");

double totalBaseCost = 0.0;
int slotIndex = 1;

foreach(double price in baseGearPrices)
{
    Console.WriteLine($"Slot {slotIndex} Item Cost : {price} Gold");
    totalBaseCost+=price;
    slotIndex++;
}
Console.WriteLine("-------------------------------");
Console.WriteLine($"Player Level     : Lvl {playerLevel}");
Console.WriteLine($"Base Gear Total  : {totalBaseCost} Gold");

double discountAmount = 0.0;
if(playerLevel>=10)
{
    discountAmount = totalBaseCost*highLevelDiscountRate;
    Console.WriteLine($"Guild Discount   : -{discountAmount} Gold (10% off)");
}
else
{
    Console.WriteLine("Guild Discount    : 0 Gold (level<10)");
}

double subtotal = totalBaseCost-discountAmount;
double serverTaxAmount = subtotal*serverTaxRate;
Console.WriteLine($"World Realm Tax  : +{serverTaxAmount:F2} Gold");
Console.WriteLine("-------------------------------");
double totalGoldExact = Math.Round(subtotal+serverTaxAmount, 2);
int finalGoldCoins = (int)totalGoldExact;

Console.WriteLine($"Total Gold Exact  : {totalGoldExact} Gold");
Console.WriteLine($"Final Gold Coins  : {finalGoldCoins} Gold");