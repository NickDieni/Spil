using Blackjack1;

UI.Velkommen();
UI.Menu();

while (!Console.KeyAvailable)
{
    ConsoleKeyInfo KeyInfo = Console.ReadKey();
    if (KeyInfo.Key == ConsoleKey.B)
    {
        UI.Main();
    }
}