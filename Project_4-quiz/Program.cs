using System;
string choice = " ";

int sum = 0;

Console.WriteLine("Välkommen till mitt ...quiz!");
Console.WriteLine("Svara på frågorna genom att skriva rätt siffra för rätt svarsalternativ och tryck på ENTER.");
Console.WriteLine("Tryck på ENTER när du är redo för första frågan.");

choice = Console.ReadLine();
choice = choice.ToLower();

Console.WriteLine("Första frågan:");
Console.WriteLine("Vad");
Console.WriteLine("1. ");
Console.WriteLine("2. ");
Console.WriteLine("3. ");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "1" | choice == "2" | choice == "3")
{
    if (choice == "1")
    {sum++;
    }
    Console.WriteLine("Andra frågan:");
    Console.WriteLine("Vad");
    Console.WriteLine("1. ");
    Console.WriteLine("2. ");
    Console.WriteLine("3. ");

    choice = Console.ReadLine();
    choice = choice.ToLower();
    
    if (choice == "1" | choice == "2" | choice == "3")
    {
        if (choice == "2")
        {sum++;
        }
        Console.WriteLine("Tredje och sista frågan:");
        Console.WriteLine("Vad");
        Console.WriteLine("1. ");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");

        choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1" | choice == "2" | choice == "3")
        {
            if (choice == "1")
            {sum++;
            }
            
            if (sum <= 3)
            {
                Console.WriteLine("Du fick alla rätt. Bra jobbat!");
            }
            else if (sum == 2)
            {
                Console.WriteLine("Nästan! Du hade ett fel.");
            }
            else if (sum == 1)
            {
                Console.WriteLine("Ett är bättre än inget. Du fick en poäng.");
            }
            else
            {
                Console.WriteLine("Wow! Va quizet för svårt för dig? Du fick noll poäng.");
            }
            choice = Console.ReadLine();
            choice = choice.ToLower();
        }
    }
}