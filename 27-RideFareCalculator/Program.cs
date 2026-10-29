double tripDistancekm = 14.5;
double ratePerKm = 12.0;
double baseFare = 50.0;
float surgeMultiplier = 1.4f;
int tollCharges = 40;

Console.WriteLine($"Trip Distance : {tripDistancekm}km");
Console.WriteLine($"Rate Per Km : {ratePerKm}km");
Console.WriteLine($"Base Pickup Fare : {baseFare}");

double distanceCharge = tripDistancekm*ratePerKm;
double subtotal = baseFare+distanceCharge;
double surgeSubtotal = subtotal;

if(surgeMultiplier>1.0)
{
    surgeSubtotal = subtotal*surgeMultiplier;
    Console.WriteLine($"\nPEAK HOURS DETECTED : {surgeMultiplier}x Surge Pricing Applied!");
}
else
{
    Console.WriteLine("Standard Rates Applied (No Surge).");
}

double totalFareExact = surgeSubtotal+tollCharges;
int finalFareRounded = (int)totalFareExact;

Console.WriteLine($"\nDistance Cost : ₹{distanceCharge}");
Console.WriteLine($"Toll Charges : ₹{tollCharges}");
Console.WriteLine($"Total Fare Exact : ₹{totalFareExact:F2}");
Console.WriteLine($"Total Fare Rounded : ₹{finalFareRounded}");