using System;

int points = 0;
Console.WriteLine("Välkommen till mitt sifferquiz!\nSvara på frågorna genom att skriva rätt siffra för rätt svarsalternativ och tryck på ENTER.");

Console.WriteLine("Fråga 1: \nVilket alternativ tror du är rätt?");
Console.WriteLine("1. 3  \n2. 1  \n3. 2");
string answer1 = Console.ReadLine();
if (answer1 == "1")
{
  points++;
  Console.WriteLine("  Du gissade rätt!");
}
else
{
  Console.WriteLine("  Fel svar...");
}

Console.WriteLine("Fråga 2: \nVilket alternativ tror du är rätt nu?");
Console.WriteLine("1. 2 \n2. 3 \n3. 1");
string answer2 = Console.ReadLine();
if (answer2 == "2")
{
  points++;
  Console.WriteLine("  Du gissade rätt!");
}
else
{
  Console.WriteLine("  Fel svar...");
}

Console.WriteLine("Fråga 3: \nVilket alternativ tror du är rätt nu?");
Console.WriteLine("1. 3 \n2. 1 \n3. 2");
string answer3 = Console.ReadLine();
if (answer3 == "1")
{
  points++;
  Console.WriteLine("  Du gissade rätt!");
}
else
{
  Console.WriteLine("  Fel svar...");
}

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Var quizet för svårt eller är det du som inte har någon koll?");
}
else if (points < 3)
{
  Console.WriteLine("Bra försökt! Du gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadKey();