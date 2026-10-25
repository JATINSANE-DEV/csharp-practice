int accountBalance = 10000;
int dailyLimit = 5000;
int withdrawAmount = 3500;

Console.WriteLine($"Current Balance : ₹{accountBalance}");
Console.WriteLine($"Daily Limit : ₹{dailyLimit}");
Console.WriteLine($"Requested Amount : ₹{withdrawAmount}\n");
if(withdrawAmount>dailyLimit)
{
    Console.WriteLine("Transaction Failed : Daily Withdrawal limit exceeded!");
}
else if(withdrawAmount>accountBalance)
{
    Console.WriteLine("Transaction Failed : Insufficient Balance!");
}
else
{
    accountBalance-=withdrawAmount;
    Console.WriteLine("Transaction Succesful! Please collect your Cash.");
    Console.WriteLine($"Remaining Account Balance : ₹{accountBalance}");
}