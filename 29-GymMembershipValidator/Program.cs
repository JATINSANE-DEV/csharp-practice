double baseMembershipFee = 2500.0;
bool isStudent = true;
double studentDiscountRate = 0.25;
bool includesPersonalTrainer = true;
double trainerFee = 1200.0;

Console.WriteLine($"Base Membership Fee : ₹{baseMembershipFee}\n");

double discountAmount = 0.0;
double subtotal = baseMembershipFee;

if(isStudent)
{
    discountAmount = baseMembershipFee*studentDiscountRate;
    subtotal = baseMembershipFee-discountAmount;
    Console.WriteLine("STUDENT DISCOUNT APPLIED(25%)!");

}
else
{
    Console.WriteLine("Regular Membership Rate Applied.");

}

double addedTrainerFee = 0.0;
if(includesPersonalTrainer)
{
    addedTrainerFee = trainerFee;
    Console.WriteLine($"PERSONAL TRAINER ADDED! +(₹{trainerFee})");
}

double totalBillExact = Math.Round(subtotal + addedTrainerFee, 2);
int finalBillRounded = (int)totalBillExact;

Console.WriteLine($"\nStudentDiscount    : -₹{discountAmount}");
Console.WriteLine($"Trainer Add-on Fee : +₹{trainerFee}");
Console.WriteLine($"Total Bill Exact   : ₹{totalBillExact}");
Console.WriteLine($"Total Bill Rounded : ₹{finalBillRounded}");