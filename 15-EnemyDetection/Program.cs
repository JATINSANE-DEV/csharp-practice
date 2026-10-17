bool IsEnemyDetected(int distanceToPlayer, int detectionRadius)
{
    return distanceToPlayer<= detectionRadius;
}

int distance = 12;
int radius = 15;

bool isAlert = IsEnemyDetected(distance, radius);
Console.WriteLine($"Distance to Player : {distance}m | Detection Radius: {radius}m");
Console.WriteLine($"Is Enemy Alert? {isAlert}");