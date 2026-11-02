// Kalkulator v1.1

Console.WriteLine("================================");

Console.WriteLine("       MIN KALKULATOR");

Console.WriteLine("================================");


// Hovedløkke som lar brukeren utføre flere beregninger

while (true)
{
    Console.WriteLine("\nSkriv inn det første tallet:");
    // Kontrollerer at brukeren skriver et gyldig heltall
    if (!int.TryParse(Console.ReadLine(), out int tall1))
    {
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
        continue;
    }
    Console.WriteLine("Skriv inn det andre tallet:");
    if (!int.TryParse(Console.ReadLine(), out int tall2))
    {
        Console.WriteLine("Ugyldig tall! Prøv igjen.");
        continue;
    }
    Console.WriteLine("Velg regneart (+, -, *, /):");
    string? regneart = Console.ReadLine();
    
    try
    {
        // Velger riktig metode basert på brukerens valg
        int resultat = regneart switch
        {
            "+" => Add(tall1, tall2),
            "-" => Subtract(tall1, tall2),
            "*" => Multiply(tall1, tall2),
            "/" => Divide(tall1, tall2),
            _ => throw new ArgumentException("Ugyldig regneart!")
        };
        Console.WriteLine($"\nResultat: {tall1} {regneart} {tall2} = {resultat}");
    }

    catch (DivideByZeroException)
    {
        Console.WriteLine("Feil: Du kan ikke dele på null!");
    }

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

static int Add(int a, int b)
{
    return a + b;
}

static int Subtract(int a, int b)
{
    return a - b;
}

static int Multiply(int a, int b)
{
    return a * b;
}

static int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    return a / b;
}