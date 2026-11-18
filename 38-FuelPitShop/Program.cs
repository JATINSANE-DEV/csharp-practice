int currentLap = 1;
int totalLaps = 6;
int fuelLiters = 50;
int tyreGrip = 100;

Console.WriteLine("<---F1 Race Telementry & Pit-Shop Simulator--->");

while(currentLap<=totalLaps)
{
    fuelLiters -= 14;
    tyreGrip -= 18;

    if(fuelLiters<20 || tyreGrip <30)
    {
        Console.WriteLine($"Lap {currentLap} | Fuel : {fuelLiters}L | Grip : {tyreGrip}% -> BOX NOW! (Refuel & New Tyres)");
        fuelLiters = 50;
        tyreGrip = 100;

    }
    else
    {
        Console.WriteLine($"Lap {currentLap} | Fuel : {fuelLiters}L | Grip : {tyreGrip}% -> STAY OUT (PUSH HARD)");

    }

    currentLap++;
}