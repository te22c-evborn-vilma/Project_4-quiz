using System;
string choice = " ";

int sum = 0;

Console.Title = "quiz";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine("Välkommen till mitt sifferquiz!");
Console.WriteLine("Svara på frågorna genom att skriva rätt siffra för rätt svarsalternativ och tryck på ENTER.");
Console.WriteLine("Tryck på ENTER när du är redo för första frågan.");

choice = Console.ReadLine();
choice = choice.ToLower();

Console.WriteLine("Första frågan:");
Console.WriteLine("Vilket alternativ tror du är rätt?");
Console.WriteLine("1. 3");
Console.WriteLine("2. 1");
Console.WriteLine("3. 2");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "1" | choice == "2" | choice == "3")
{
    if (choice == "1")
    {sum++;
    }
    Console.WriteLine("Andra frågan:");
    Console.WriteLine("Vilket alternativ tror du är rätt nu?");
    Console.WriteLine("1. 2");
    Console.WriteLine("2. 3");
    Console.WriteLine("3. 1");

    choice = Console.ReadLine();
    choice = choice.ToLower();
    
    if (choice == "1" | choice == "2" | choice == "3")
    {
        if (choice == "2")
        {sum++;
        }
        Console.WriteLine("Tredje och sista frågan:");
        Console.WriteLine("Vilket alternativ tror du är rätt nu?");
        Console.WriteLine("1. 3");
        Console.WriteLine("2. 1");
        Console.WriteLine("3. 2");

        choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "1" | choice == "2" | choice == "3")
        {
            if (choice == "1")
            {sum++;
            }
            
            if (sum == 3)
            {
                Console.WriteLine("Du fick alla rätt. Grymt jobbat!");
            }
            else if (sum == 2)
            {
                Console.WriteLine("Nästan alla rätt! Du fick ett fel.");
            }
            else if (sum == 1)
            {
                Console.WriteLine("Ett är bättre än inget. Du fick en poäng.");
            }
            else if (sum == 0)
            {
                Console.WriteLine("Wow ... var quizet för svårt eller är det du som inte kan något? Du fick noll poäng.");
            }
            else
            {
                Console.WriteLine("Du skrev något som jag inte förstod. Hejdå.");
                choice = Console.ReadLine();
                choice = choice.ToLower();
            }
            choice = Console.ReadLine();
            choice = choice.ToLower();
        }
    }
    else
    {
        Console.WriteLine("Du skrev något som jag inte förstod. Hejdå.");
        choice = Console.ReadLine();
        choice = choice.ToLower();
    }
}
else
{
    Console.WriteLine("Du skrev något som jag inte förstod. Hejdå.");
    choice = Console.ReadLine();
    choice = choice.ToLower();
}
