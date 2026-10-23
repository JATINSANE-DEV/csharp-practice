int currentXp = 80;
int xpGained = 50;
int xpToLevelUp = 100;
int playerLevel = 1;

Console.WriteLine($"Starting Level : {playerLevel} | XP : {currentXp}/{xpToLevelUp}");
Console.WriteLine($"Gained XP : +{xpGained}");

currentXp += xpGained;

if(currentXp>=xpToLevelUp)
{
    playerLevel++;
    currentXp-=xpToLevelUp;

    Console.WriteLine($"Level Up! You are now level {playerLevel}");

}
else
{
    Console.WriteLine("Keep Grinding for the next level");
}
Console.WriteLine($"Current State : Level {playerLevel} | XP : {currentXp}/{xpToLevelUp}");
