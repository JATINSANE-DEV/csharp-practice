/*
Adventurer's Combat & Loot Estimator
- Input: name, level, class (1 Warrior, 2 Mage, 3 Rogue)
- Base power: 15, 20, 12; total = base * level (+10 if name is "Jatin")
- Invalid class: print "Invalid Class Chosen!" and exit
- Split 500 gold among party (solo gets all 500)
*/
Console.WriteLine("Enter your name : ");
string? name = Console.ReadLine();
Console.WriteLine("Enter your level : ");
int level = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"Choose your class
1 - Warrior
2 - Mage
3 - Rogue");
int choice = Convert.ToInt32(Console.ReadLine());
string className = "";
int bp = 0;
switch(choice)
{
    case 1:
    className = "Warrior";
    bp = 15;
    break;

    case 2:
    className = "Mage";
    bp = 20;
    break;

    case 3:
    className = "Rogue";
    bp = 12;
    break;

    default:
    Console.WriteLine("Invalid Class Chosen!");
    return;
}
int totalPower = bp*level;
if(name == "Jatin")
{
    totalPower+=10;
}
Console.WriteLine("Total Gold looted : 500 gold");
int tGold = 500;
Console.WriteLine("Enter the numbers of Party Members u have :");
int partMem = Convert.ToInt32(Console.ReadLine());
double share;
share = 0;
if(partMem == 0)
{
    share = tGold;
}
else if (partMem>=1)
{
    share = (double)tGold/(partMem+1);
}
Console.WriteLine(@$"Adventurer {name} ({className}), your Total Power is {totalPower}!
Your share of the loot is {share:F2} gold.");


