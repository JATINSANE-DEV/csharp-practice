int monthlyPlanData = 50;
int rollOverData = 10;
int dataUsed = 68;
double overageRatePerGb =100.0;
double basePlanCost = 499.0;

int totalAvailableData = monthlyPlanData+rollOverData;
Console.WriteLine($"Base Plan Data : {monthlyPlanData}GB");
Console.WriteLine($"Rollover Data : {rollOverData}GB");
Console.WriteLine($"Total Available Data : {totalAvailableData}GB");
Console.WriteLine($"Data Consumed : {dataUsed}GB");

double overagePenalty = 0.0;
if(dataUsed>totalAvailableData)
{
    int extraGb = dataUsed-totalAvailableData;
    overagePenalty = extraGb*overageRatePerGb;
    Console.WriteLine($"ALERT! : Data Limit Exceeded by {extraGb}GB!");
    Console.WriteLine($"Overage Charge (₹{overageRatePerGb}/GB) : ₹{overagePenalty}");

}
else
{
    int remainingData = totalAvailableData-dataUsed;
    Console.WriteLine($"Usage within limits! Remaining Data : {remainingData}GB");

}
double totalBill = basePlanCost+overagePenalty;
int finalBillRounded = (int)totalBill;

Console.WriteLine($"\nBase Plan Cost : ₹{basePlanCost}");
Console.WriteLine($"Total Bill Exact : ₹{totalBill}");
Console.WriteLine($"TotalBillRounded : ₹{finalBillRounded}");