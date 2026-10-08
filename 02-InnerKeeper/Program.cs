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