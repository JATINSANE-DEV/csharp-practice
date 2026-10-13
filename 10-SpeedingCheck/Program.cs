bool IsSpeeding(int currentSpeed, int speedLimit)
{
    if(currentSpeed>speedLimit)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int mySpeed = 75;
int limit = 60;

bool caughtByPolice = IsSpeeding(mySpeed, limit);

Console.WriteLine($"Current Speed : {mySpeed} km/h");
Console.WriteLine($"Speed Limit : {limit} km/h");
Console.WriteLine($"Is Speeding? {caughtByPolice}");