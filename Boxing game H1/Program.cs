using Boxing_game_H1;
using Boxinggame;
using System;
using System.Threading;
using static Boxinggame.Boxer;
Random rnd = new Random();

Boxer b1 = new();
Boxer b2 = new();

b1.Name = "Mike";
b1.HealChance = 10;

b2.Name = "Jake";
b2.HealChance = 5;

MatchSettings match1 = new();
match1.isMatchOngoing = new();

ConsoleGUI GUI = new();
ConsoleGUI MatchAndHPTimer = new();

Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
match1.matchTime = 5;


int rounds = match1.noOfRounds;
int currentMatch = match1.currentMatch;
MatchAndHPTimer.HealhTracker(b1.CurrentHealth, b1.Name, b2.CurrentHealth, b2.Name, currentMatch);



GUI.ScrollingMessage("Welcome to the worlds greatest boxing match!\n");
GUI.ScrollingMessage($"Tonight the Two fighters {b1.Name} and {b2.Name} will go head to head in an epic battle!\n");
Console.WriteLine("Press Enter to start");
Thread.Sleep(1000);
//Console.ReadLine();
Console.Clear();

match1.isMatchOngoing = true;
while (match1.isMatchOngoing)
{

    for (match1.currentMatch = 0; match1.currentMatch < match1.noOfRounds; match1.currentMatch++) // Rounds
    {
        if (!match1.isMatchOngoing) { break; }
        Console.WriteLine((match1.currentMatch));
        for (int j = 0; j < match1.matchTime; j++)//Seconds in the round
        {
            if (!match1.isMatchOngoing) { break; }
            b1.Attack(b2);
            b2.Attack(b1);


        }
        if (!match1.isMatchOngoing) { break; }
        b1.TryHeal();
        b2.TryHeal();


    }
}

/*
while (b1.CurrentHealth > 0 && b2.CurrentHealth > 0)
{
    Console.WriteLine("Fighting");
    b2.CurrentHealth = b2.CurrentHealth - b1.DoDamage();
    b1.CurrentHealth = b1.CurrentHealth - b2.DoDamage();
    Console.WriteLine($"b1 health: {b1.CurrentHealth}");
    Console.WriteLine($"b2 health: {b2.CurrentHealth}");

}*/

//int Attack(Boxer AttackingBoxer, Boxer defendingBoxer)
//{
//    int damagedone = AttackingBoxer.DoDamage();
//    defendingBoxer.CurrentHealth = defendingBoxer.CurrentHealth - damagedone;

//    Console.Write($"{AttackingBoxer.Name} hits {defendingBoxer.Name} [-{damagedone}]DMG");
//    //Console.WriteLine($"{defendingBoxer.Name} now has {defendingBoxer.CurrentHealth}");
//    //Console.WriteLine();
//    checkKO(AttackingBoxer, defendingBoxer);

//    RoundGUI();
//    return damagedone;
//}
//void RoundGUI()
//{
//    int originalCursorTop = Console.CursorTop;
//    int originalCursorLeft = Console.CursorLeft;


//    Console.SetCursorPosition(0, 2);
//    Console.WriteLine($"Round: {match1.currentMatch+1} {b1.Name} HP:[{b1.CurrentHealth:000}] {b2.Name} HP:[{b2.CurrentHealth:000}]".PadLeft(50, '-').PadRight(50, '-'));
//    Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
//    Console.WriteLine();



//}

void checkKO(Boxer b1, Boxer b2)
{
    if (b1.CurrentHealth <= 0 || b2.CurrentHealth <= 0)
    {
        match1.isMatchOngoing = false;
        Console.WriteLine("The match is ending");
        //return;
    }
}

void ScrollingMessage(string message)
{

    foreach (char line in message.ToCharArray())
    {
        Console.Write(line);
        Thread.Sleep(50);
    }
}

if (b1.CurrentHealth < b2.CurrentHealth)
{
    Console.WriteLine($"{b2.Name} is the winner");
}
else if (b1.CurrentHealth > b2.CurrentHealth)
{
    Console.WriteLine($"{b1.Name} is the winner");
}
else
{
    Console.WriteLine($"Its a tie!");
}

