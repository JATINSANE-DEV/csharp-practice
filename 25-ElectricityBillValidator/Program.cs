int unitsConsumed = 280;
double ratePerUnit = 7.5;
double taxRate = 0.05;
int fixedSurcharge = 50;

Console.WriteLine($"Units Consumed : {unitsConsumed} kWh");
Console.WriteLine($"Rate Per Unit : ₹{ratePerUnit}");

double baseCost = unitsConsumed*ratePerUnit;
double taxAmount = baseCost*taxRate;
int appliedSurcharge = 0;

if(unitsConsumed>250)
{
    appliedSurcharge = fixedSurcharge;
    Console.WriteLine($"High Usage Surcharge Applied : ₹{appliedSurcharge}");

}
else
{
    Console.WriteLine("Standard Usage (No Surcharge Applied)");
}

double totalBill = baseCost+taxAmount+appliedSurcharge;
int finalBillRounded = (int)totalBill;

Console.WriteLine($"Base Electricity Cost : ₹{baseCost}");
Console.WriteLine($"Govt Tax (5%) : ₹{taxAmount}");
Console.WriteLine($"\nFinal Bill (Exact) : ₹{totalBill}");
Console.WriteLine($"Final Bill (Rounded) : ₹{finalBillRounded}");