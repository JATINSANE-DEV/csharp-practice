double[] serviceCosts = {1500.0, 38250.0, 2500.0, 4500.0};
bool isWeekend = true;
double weekendSurchargeRate = 0.15;


double subtotal = 0.0;
int itemIndex =1;

Console.WriteLine("<--Itemized Service Charges-->");

foreach(double cost in serviceCosts)
{
    Console.WriteLine($"Service Item {itemIndex} : ₹{cost}");
    subtotal+=cost;
    itemIndex++;
}


double surchargeAmount = 0.0;
if(isWeekend)
{
    surchargeAmount = subtotal*weekendSurchargeRate;
    Console.WriteLine($"\nWEEKEND BOOKING(15%) : +₹{surchargeAmount}");

}
else
{
    Console.WriteLine("WEEKDAY RATE : No Surcharge Applied");
}

double totalBillExact = Math.Round(subtotal+surchargeAmount, 2);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"Subtotal Cost      : ₹{subtotal}");
Console.WriteLine($"Total Bill Exact   : ₹{totalBillExact}");
Console.WriteLine($"Total Bill Rounded : ₹{finalBillRounded}");