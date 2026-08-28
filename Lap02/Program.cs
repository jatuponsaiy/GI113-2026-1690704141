/*
 * Student ID : 1690704141
 * Name       : จตุพล ใสยอด
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank : {rank}");
            Console.WriteLine($"HP : {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp; //คำนวณเปอร์เซ็น
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            
            string characterName_1 = "Marionette";
            int Age = 28;
            level = 38;
            float attackPower_1 = 380.75f;
            float Health_1 = 400.50f;
            float currentHp_1 = 400.50f;
            double accuracy_1 = 78.25;
            char element_1 = 'D'; // D = ธาตุมืด
            bool isActive_1 = true;

            string characterName_2 = "Charlotte";
            Age = 26;
            level = 30;
            float attackPower_2 = 300.25f;
            float Health_2 = 300.25f;
            float currentHp_2 = 300.25f;
            double accuracy_2 = 71.50;
            char element_2 = 'L'; // L = ธาตุแสง
            bool isActive_2 = true;

            string characterName_3 = "Rancandel";
            Age = 27;
            level = 35;
            float attackPower_3 = 350.50f;
            float Health_3 = 370.50f;
            float currentHp_3 = 370.50f;
            double accuracy_3 = 75.00;
            char element_3 = 'F'; // F = ธาตุไฟ
            bool isActive_3 = true;

            string characterName_4 = "Clover";
            Age = 20;
            level = 24;
            float attackPower_4 = 240.10f;
            float Health_4 = 260.10f;
            float currentHp_4 = 50.25f;
            double accuracy_4 = 61.25;
            char element_4 = 'W'; // W = ธาตุน้ำ
            bool isActive_4 = false;

            Console.WriteLine("=====  1. MARIONETTE =====");
            Console.WriteLine($"Name: {characterName_1}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"AttackPower: {attackPower_1}");
            Console.WriteLine($"MaxHp: {Health_1}");
            Console.WriteLine($"CurrentHp: {currentHp_1}");
            Console.WriteLine($"Accuracy: {accuracy_1}%");
            Console.WriteLine($"Element: {element_1} (Dark)");
            Console.WriteLine($"Combat ready: {(isActive_1 ? " Ready " : " Not Ready")}");
            Console.WriteLine();

            Console.WriteLine("=====  2. CHARLOTTE =====");
            Console.WriteLine($"Name: {characterName_2}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"AttackPower: {attackPower_2}");
            Console.WriteLine($"MaxHp: {Health_2}");
            Console.WriteLine($"CurrentHp: {currentHp_2}");
            Console.WriteLine($"Accuracy: {accuracy_2}%");
            Console.WriteLine($"Element: {element_2} (Light)");
            Console.WriteLine($"Combat ready: {(isActive_2 ? " Ready " : " Not Ready")}");
            Console.WriteLine();

            Console.WriteLine("=====  3. RANCANDEL =====");
            Console.WriteLine($"Name: {characterName_3}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"AttackPower: {attackPower_3}");
            Console.WriteLine($"MaxHp: {Health_3}");
            Console.WriteLine($"CurrentHp: {currentHp_3}");
            Console.WriteLine($"Accuracy: {accuracy_3}%");
            Console.WriteLine($"Element: {element_3} (Fire)");
            Console.WriteLine($"Combat ready: {(isActive_3 ? " Ready " : " Not Ready")}");
            Console.WriteLine();

            Console.WriteLine("=====  4. CLOVER =====");
            Console.WriteLine($"Name: {characterName_4}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"AttackPower: {attackPower_4}");
            Console.WriteLine($"HMaxHp: {Health_4}");
            Console.WriteLine($"CurrentHp: {currentHp_4}");
            Console.WriteLine($"Accuracy: {accuracy_4}%");
            Console.WriteLine($"Element: {element_4} (Water)");
            Console.WriteLine($"Combat ready: {(isActive_4 ? "  Ready " : " Not Ready")}");

        }
    }
}



