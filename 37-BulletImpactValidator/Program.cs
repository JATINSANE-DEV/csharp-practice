int[] baseDamages = {45, 30, 60, 25};
int[] enemyArmors = {20, 40, 15, 30};
bool[] isHeadshots = {false, true, true, false};

Console.WriteLine("<---FPS Bullet Impact & Armor Validator--->");

for(int i = 0; i<baseDamages.Length; i++)
{
    int effectiveDamage = isHeadshots[i]?(baseDamages[i]*2) : baseDamages[i];
    int finalDamage = Math.Max(0, effectiveDamage - enemyArmors[i]);

    string hitType = isHeadshots[i]?"HEADSHOT(2x)" : "BodyShot";
    string status = (finalDamage > 0)?$"Dealt {finalDamage} HP Damage" : "BLOCKED BY ARMOR";

    Console.WriteLine($"Shot{i+1}[{hitType}] | Armor : {enemyArmors[i]} -> {status}");
}