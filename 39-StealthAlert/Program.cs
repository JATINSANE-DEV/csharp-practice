string[] zoneSensors = {"Guard", "Shadow", "Camera", "Shadow", "Laser"};
int visibility = 20;

Console.WriteLine("<---Tactical Stealth & Sensor Simulator--->");

for(int i = 0; i<zoneSensors.Length; i++)
{
    switch(zoneSensors[i])
    {
        case "Shadow":
        visibility -=15;
        break;
        case "Guard":
        visibility +=35;
        break;
        case "Camera":
        visibility +=50;
        break;
        case "Laser":
        visibility +=75;
        break;
    }

    visibility = Math.Clamp(visibility, 0, 100);
    string status = (visibility>=80)? "ALARM TRIGGERED!(Compromised)" : "GHOST MODE(UNDETECTED)";
    Console.WriteLine($"Zone {i+1} [{zoneSensors[i]}] | Visibility : {visibility}% -> {status}");

}