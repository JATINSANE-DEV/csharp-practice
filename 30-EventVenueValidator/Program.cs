double[] serviceCosts = {1500.0, 38250.0, 2500.0, 4500.0};
bool isWeekend = true;
double weekendSurchargeRate = 0.15;

Console.WriteLine("<--Itemized Service Charges-->");
double subtotal = 0.0;
int itemNumber =1;

foreach(double cost in serviceCosts)
{
    Console.WriteLine($"Service Item {itemNumber} : ₹{cost}");
    subtotal=+cost;
    itemNumber++;
}

Console.WriteLine($"\nSubtotal Cost   : {subtotal}");

double surchargeAmount = 0.0;
if(isWeekend)
{
    surchargeAmount = subtotal*weekendSurchargeRate;
    Console.WriteLine($"WEEKEND BOOKING : +₹{surchargeAmount} (15% Surcharge)");

}
else
{
    Console.WriteLine("WEEKDAY BOOKING : No Extra Surcharge");
}

double totalBillExact = Math.Round(subtotal+surchargeAmount, 2);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"\nTotal Bill Exact   : ₹{totalBillExact}");
Console.WriteLine($"Total Bill Rounded : ₹{finalBillRounded}");