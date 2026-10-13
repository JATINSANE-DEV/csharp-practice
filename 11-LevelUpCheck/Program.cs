bool CanLevelUP(int currentXP, int requiredXP)
{
    if(currentXP>=requiredXP)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int playerXP = 1200;
int neededXP = 1000;
bool ToLevelUp = CanLevelUP(playerXP, neededXP);
Console.WriteLine($"Current Player XP is : {playerXP} XP");
Console.WriteLine($"The Required XP is : {neededXP} XP");
Console.WriteLine($"Can he Level up? {ToLevelUp}");