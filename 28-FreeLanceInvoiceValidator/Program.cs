double baseInvoiceAmount = 15000.0;
int delayDays = 5;
double dailyPenaltyRate = 150.0;
double milestoneDiscount = 0.05;

Console.WriteLine($"Base Invoice Amount : ₹{baseInvoiceAmount}");
Console.WriteLine($"Payment Delay       : {delayDays} days\n");

double discountAmount = baseInvoiceAmount*milestoneDiscount;
double discountedSubtotal = baseInvoiceAmount-discountAmount;
double totalPenalty = 0.0;

if(delayDays>0)
{
    totalPenalty =delayDays*dailyPenaltyRate;
    Console.WriteLine($"Late Payment Detected! : {dailyPenaltyRate}/day Penalty Applied!");
    
}
else
{
    Console.WriteLine("On-Time Payment : No Late Penalty Applied.");
}

double totalBillExact = Math.Round(discountedSubtotal+totalPenalty);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"\nMilestone Discount (5%) : -₹{discountAmount}");
Console.WriteLine($"Late Fee Penalty        : +₹{totalPenalty}");
Console.WriteLine($"Total Invoice Exact     : ₹{totalBillExact}");
Console.WriteLine($"Total Invoice Rounded   : ₹{finalBillRounded}");