double[] itemsPrices = {350.0, 188.0, 420.0, 150.0};
double gstRate = 0.05;
double serviceChargeRate = 0.10;
double serviceChargeThreshold = 1000.0;
Console.WriteLine("<---Restaurant Order Items--->");

double subtotal = 0.0;
int itemIndex = 1;

foreach (double price in itemsPrices)
{
    Console.WriteLine($"Item {itemIndex} Price : ₹{price:F2}");
    subtotal+=price;
    itemIndex++;
}

Console.WriteLine("-------------------------------");
Console.WriteLine($"Subtotal Cost       : ₹{subtotal:F2}");

double gstAmount = subtotal*gstRate;
Console.WriteLine($"GST(5%)             : +₹{gstAmount:F2}");

double serviceChargeAmount = 0.0;
if(subtotal>serviceChargeThreshold)
{
    serviceChargeAmount = subtotal*serviceChargeRate;
    Console.WriteLine($"Service Charge(10%) : +₹{serviceChargeAmount:F2}");
}
else
{
    Console.WriteLine("Service Charge  : ₹0.00(Below ₹1000 threshold)");

}

double totalBillExact = Math.Round(subtotal + gstAmount + serviceChargeAmount , 2);
int finalBillRounded = (int)Math.Round(totalBillExact);
Console.WriteLine("-------------------------------");
Console.WriteLine($"Total Bill Exact   : ₹{totalBillExact:F2}");
Console.WriteLine($"Total Bill Rounded : ₹{finalBillRounded}");