double[] roundWinnings = {450.0, 720.0, 310.0, 620.0};
bool isCaptainTopScorer = true;
double captainBonusFlat = 350.0;
double platformFeeRate = 0.05;

Console.WriteLine("<---Fantasy Cricket payout Validator--->");

double totalRoundWinnings = 0.0;
int roundNumber = 1;

foreach(double win in roundWinnings)
{
    Console.WriteLine($"Round{roundNumber} Win : ₹{win}");
    totalRoundWinnings += win;
    roundNumber++;
}

Console.WriteLine("---------------------------------------");
Console.WriteLine($"Base Winnings      :  ₹{totalRoundWinnings}");

double captainBonus = isCaptainTopScorer ? captainBonusFlat : 0.0;
Console.WriteLine(isCaptainTopScorer
? $"Captain Bonus      : +₹{captainBonus} (Top Scorer)"
: "Captain Bonus      : ₹0 (Standard)");

double grossWinnings = totalRoundWinnings+captainBonus;
double platformFee = grossWinnings*platformFeeRate;

Console.WriteLine($"Gross Winnings     :  ₹{grossWinnings}");
Console.WriteLine($"Platform Fee (5%)  : -₹{platformFee:F2}");
Console.WriteLine("-------------------------------------------");

double netExact = Math.Round(grossWinnings-platformFee, 2);
int finalPayout = (int)netExact;

Console.WriteLine($"Net Exact Payout : ₹{netExact}");
Console.WriteLine($"Final Payout     : ₹{finalPayout}");
