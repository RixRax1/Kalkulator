// Kalkulator v1.1

Console.WriteLine("================================");

Console.WriteLine("       MIN KALKULATOR");

Console.WriteLine("================================");

Kalkulator kalkulator = new Kalkulator();

// Hovedløkke som lar brukeren utføre flere beregninger
while (true)
{
    Console.WriteLine("\nSkriv inn det første tallet:");
    // Kontrollerer at brukeren skriver et gyldig heltall
    if (!int.TryParse(Console.ReadLine(), out int tall1))
    {
        // Hvis input ikke er et gyldig tall, vis en feilmelding og fortsett til neste iterasjon
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
        continue;
    }
    // Kontrollerer at brukeren skriver et gyldig heltall
    Console.WriteLine("Skriv inn det andre tallet:");
    // Kontrollerer at brukeren skriver et gyldig heltall
    if (!int.TryParse(Console.ReadLine(), out int tall2))
    {
        // Hvis input ikke er et gyldig tall, vis en feilmelding og fortsett til neste iterasjon
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
        continue;
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

    string? svar = Console.ReadLine();

    if (svar?.ToLower() != "j")
    {
        Console.WriteLine("\nTakk for at du brukte kalkulatoren!");
        break;
    }
}