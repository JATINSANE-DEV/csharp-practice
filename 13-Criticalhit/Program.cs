bool IsCriticalHit(int hitRoll, int critThreshold)
{
    return hitRoll>=critThreshold;
}

int playerRoll = 85;
int threshold= 80;

bool isCrit = IsCriticalHit(playerRoll, threshold);

Console.WriteLine($"Roll : {playerRoll} | Threshold : {threshold}");
Console.WriteLine($"Is Critical Hit? {isCrit}");