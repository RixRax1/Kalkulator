// Kalkulator v1.1

Console.WriteLine("================================");

Console.WriteLine("          KALKULATOR");

Console.WriteLine("================================");

Kalkulator kalkulator = new Kalkulator();

// Hovedløkke som lar brukeren utføre flere beregninger
while (true)
{
    int tall1;
    int tall2;
    
    // Leser inn det første tallet

    while (true)
    {
        Console.WriteLine("\nSkriv inn det første tallet:");
        // Kontrollerer om brukeren har skrevet et gyldig heltall
        if (int.TryParse(Console.ReadLine(), out tall1))
        {
            break; // Avslutter løkken når tallet er gyldig
        }
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
    }
    // Leser inn det andre tallet
    while (true)
    {
        Console.WriteLine("\nSkriv inn det andre tallet:");
        // Kontrollerer om brukeren har skrevet et gyldig heltall
        if (int.TryParse(Console.ReadLine(), out tall2))
        {
            break; // Avslutter løkken når tallet er gyldig
        }
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
    }
    Console.WriteLine("Velg regneart (+, -, *, /):");
    // Les inn regnearten fra brukeren
    string? regneart = Console.ReadLine();
    // Kontrollerer at brukeren skriver en gyldig regneart
    try
    {
        // Velger riktig metode basert på brukerens valg
        int resultat = regneart switch
        {
            "+" => kalkulator.Add(tall1, tall2),
            "-" => kalkulator.Subtract(tall1, tall2),
            "*" => kalkulator.Multiply(tall1, tall2),
            "/" => kalkulator.Divide(tall1, tall2),
            _ => throw new ArgumentException("Ugyldig regneart!")
        };
        Console.WriteLine($"\nResultat: {tall1} {regneart} {tall2} = {resultat}");
    }
    // Håndterer spesifikke unntak som kan oppstå under beregningen
    catch (DivideByZeroException)
    {
        Console.WriteLine("Feil: Du kan ikke dele på null!");
    }
    // Håndterer generelle unntak som kan oppstå under beregningen
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Feil: {ex.Message}");
    }

    // Spør om brukeren ønsker en ny beregning
    Console.WriteLine("\nVil du gjøre en ny beregning? (j/n)");

    // Les inn svaret fra brukeren og sjekk om det er "j" (ja) for å fortsette
    string? svar = Console.ReadLine();

    // Hvis svaret ikke er "j", avslutt programmet med en takk-melding
    if (svar?.ToLower() != "j")
    {
        Console.WriteLine("\nAdjø!");
        break;
    }
}