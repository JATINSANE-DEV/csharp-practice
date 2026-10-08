/*CHALLENGE: The Innkeeper's Room Booking & Fine System

You are the innkeeper of "Dragon's Rest Inn". Write a console program to calculate room booking costs and late checkout fines for guests.

REQUIREMENTS:
1. Nights Input:
   - Ask the user for the number of nights they plan to stay (int).

2. Room Selection (use switch-case):
   - Display menu:
       Available Rooms:
       1 - Basic Bunk (10 gold / night)
       2 - Deluxe Suite (30 gold / night)
       3 - Royal Suite (50 gold / night)
   - Take room choice input (1, 2, or 3).
   - If invalid input (outside 1-3), print "Invalid Room Choice!" and terminate the program (return;).

3. Calculations:
   - Base Cost = Price Per Night * Nights
   - Long Stay Discount: If staying for 3 or more nights, apply a 10% discount on base cost (baseCost * 0.9).

4. Late Checkout (use if-else):
   - Ask: "Did you checkout late? (yes/no)"
   - If "yes" (case-insensitive), add a 15 gold late fee to total bill.

5. Final Output:
   - Print a single-line summary:
     "Traveler, your final bill for [Room Name] ([Nights] nights) is [Total Price] gold."*/



string? name = Console.ReadLine();
Console.WriteLine("For how many nights you want to stay?");
int nights = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(@"Available Rooms:
1 - Basic Bunk (10 gold / night)
2 - Deluxe Suite (30 gold / night)
3 - Royal Suite (50 gold / night)");

Console.WriteLine("In which room you are interested in?");
int choice = Convert.ToInt32(Console.ReadLine());
string room = "";
int gold = 0;
switch(choice)
{
    case 1:
    room = "Basic Bunk";
    gold = 10;
    break;

    case 2:
    room = "Deluxe Suite";
    gold = 30;
    break;

    case 3:
    room = "Royal Suite";
    gold = 50;
    break;

    default:
    Console.WriteLine("Invalid Room Choice");
    return;
}

double baseCost = gold*nights;

if(nights >= 3)
{
    baseCost*=0.9;
}
Console.WriteLine("Did you checkout late?");
string? late = Console.ReadLine();
if(late?.ToLower() == "yes")
{
    baseCost+=15;
}
Console.WriteLine($"Traveler, your final bill for [{room}] ({nights} nights) is {baseCost} gold.");