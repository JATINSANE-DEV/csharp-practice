double[] matchWinnings = {1200.0, 850.0, 1550.0};
bool isTournamentMvp = true;
double mvpFlatBonus = 500.0;
double taxRate = 0.10;

Console.WriteLine("<---Esports Tournament Payout--->");

double basePrizePool = 0.0;
int matchNumber = 1;


foreach(double win in matchWinnings)
{
    Console.WriteLine($"Match {matchNumber} Prize : ₹{win}");
    basePrizePool+=win;
    matchNumber++;
}

Console.WriteLine("-----------------------------------");
Console.WriteLine($"Base Winnings   : ₹{basePrizePool}");

double mvpBonus = isTournamentMvp?mvpFlatBonus:0.0;
Console.WriteLine(isTournamentMvp
? $"MVP Bonus       : +₹{mvpBonus}(Tournament MVP)"
: "MVP Bonus         : ₹0 (Standard Player)");

double grossWinnings = basePrizePool+mvpBonus;
double taxAmount = grossWinnings*taxRate;

Console.WriteLine($"Gross Total     : ₹{grossWinnings}");
Console.WriteLine($"Prize Tax (10%) : -₹{taxAmount:F2}");
Console.WriteLine("-----------------------------------");

double netExact = Math.Round(grossWinnings-taxAmount, 2);
int finalpayout = (int)netExact;

Console.WriteLine($"Net Exact Payout : ₹{netExact}");
Console.WriteLine($"Final Payout     : ₹{finalpayout}");