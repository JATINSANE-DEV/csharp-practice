int MultiplyScore(int score)
{
    int result = score*2;
    return result;
}

int myScore = 5;
int finalScore = MultiplyScore(myScore);
Console.Write($"Original Score : {myScore}");
Console.WriteLine($"\nMultiplied Score : {finalScore}");