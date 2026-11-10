double[] fuelLitres = {5.5, 12.0, 3.2};
string fuelType = "Premium";
double pricePerLitre = (fuelType == "Premium") ? 104.50 : 96.50;
double discountThreshold = 15.0;
double discountRate = 0.05;

Console.WriteLine($"<---Fuel Receipt [{fuelType}]--->");

double totalLitres = 0.0;
foreach(double litres in fuelLitres)
{
    totalLitres+=litres;
}

double baseCost = totalLitres*pricePerLitre;
bool qualifiesForDiscount = totalLitres>=discountThreshold;
double discount = qualifiesForDiscount ? (baseCost*discountRate) : 0.0;
double totalBillExact = Math.Round(baseCost-discount, 2);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"Total Fuel      : {totalLitres} L");
Console.WriteLine($"Rate Per Litre  : ₹{pricePerLitre:F2}");
Console.WriteLine($"Base Cost       : ₹{baseCost:F2}");
Console.WriteLine(qualifiesForDiscount
? $"Bulk Discount : -₹{discount:F2}(5% OFF)"
:"Bulk Discount   : ₹0.00(Below 15L)");
Console.WriteLine("------------------------------------");
Console.WriteLine($"Total Exact     : ₹{totalBillExact}");
Console.WriteLine($"Total Payable   : ₹{finalBillRounded}");