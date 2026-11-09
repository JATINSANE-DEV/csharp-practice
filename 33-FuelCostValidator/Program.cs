double[] fuelLitres = {5.5, 12.0, 3.2};
double pricePerLitre = 96.50;
double discountThreshold = 15.0;
double discountRate = 0.05;

double totalLitres = 0.0;
foreach(double litres in fuelLitres)
{
    totalLitres+=litres;
}

double baseCost = totalLitres*pricePerLitre;
double discount = (totalLitres >= discountThreshold)?(baseCost*discountRate) : 0.0;
double totalBillExact = Math.Round(baseCost-discount, 2);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"Total Fuel    : {totalLitres} L");
Console.WriteLine($"Base Cost     : ₹{baseCost:F2}");
Console.WriteLine($"Bulk Discount : -₹{discount:F2}");
Console.WriteLine($"Total Exact   : ₹{totalBillExact}");
Console.WriteLine($"Total Payable : ₹{finalBillRounded}");