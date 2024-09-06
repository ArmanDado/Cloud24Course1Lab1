// See https://aka.ms/new-console-template for more information

class LabbArman
{
    static void Main(string[] args)
    {
        // Skriva in sträng
        Console.WriteLine("Input:");
        string str = Console.ReadLine(); // Läser in inmatningen
        Console.Clear(); // Ta bort för tydligare utskrift
        long sum = 0; // Variabel för summan

        // Yttre loop för varje tecken
        for (int i = 0; i < str.Length; i++)
        {
            // Inre loop som letar efter matchande siffror
            for (int j = i + 1; j < str.Length; j++)
            {
                // Kontrollera om det nuvarande tecknet är en siffra
                if (Char.IsDigit(str[i]))
                {
                    // Om det finns en siffra som inte finns
                    if (!Char.IsDigit(str[j]))
                    {
                        break;
                    }

                    // Siffra I samma som J
                    if (str[i] == str[j] && j != i)
                    {
                        // Skapa en sträng som har samma som j och i
                        string newStr = str.Substring(i, j - i + 1);

                        // fixa strängen till ett tal
                        if (long.TryParse(newStr, out long result))
                        {
                            sum += result;
                        }

                        // Dela upp strängen i tre delar:
                        // - sträng1: första delen
                        // - sträng2: den markerade strängen
                        // - sträng3: delen efter den markerade delsträngen
                        string newStr1 = str.Substring(0, str.IndexOf(newStr));
                        string newStr2 = str.Substring(newStr.Length + newStr1.Length, str.Length - (newStr.Length + newStr1.Length));

                        // Skriv ut sträng1 i vitt (standardfärg)
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(newStr1);

                        // Skriv ut den markerade delen i grönt
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(newStr);

                        // Fixa färgen och skriv ut resten av strängen
                        Console.ResetColor();
                        Console.WriteLine(newStr2);

                        // stoppa loopen och gå till nästa sträng
                        break;
                    }
                }
            }
        }

        // Skriv ut en tom rad för att förstå summan bättre
        Console.WriteLine();

        // Återställ alla konsolfärger till vanligt
        Console.ResetColor();

        // Skriv ut den totala summan av alla markerade strängar i rött
        Console.WriteLine("Summan av markerade talen är: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(sum);

        // Skriv ut en ny helt avslutad rad och fixa om färgerna
        Console.WriteLine();
        Console.ResetColor();
    }
}