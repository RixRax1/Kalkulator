Kalkulator i C#

Konsolbasert kalkulator i C# og .NET i forbindelse med kodehode.

Om prosjektet.
Å lære grunnleggende programmering i C#, med fokus på variabler, datatyper, metoder, brukerinput, betingelser og feilhåndtering.
Kalkulatoren lar brukeren skrive inn to helltall (ikke desimaler), og velge mellom fire regnearter.
Prosjektet er utviklet for å øve på nye programmersingskonsepter.

Hvordan fungerer programmet?
Variabler og datatyper - Kalkulatoren bruker datatypen int for å lage heltall. Datatypen string brukes til å lage brukerens valg av regneart.
Brukerinput - Console.ReadLine() brukes for å hente informasjon fra brukeren. Metoden returnerer tekst, og derfor må tallene konverteres til heltall. Dette gjøres med int.TryParse(). TryParse() returnerer true dersom konvertingen lykkse, og false dersom den mislykkes.
Metoder - Hver regneart har sin egen metode. Metoden mottar to heltall som parametere og returnerer summen, dette gjør at samme metode kan brukes flere ganger med forskjellig tall.
Switch - En switch-expression brukes for å velge hvilke metode som skal kjøres. Dette gjør koden mer oversiktlig enn flere etterfølgende if/else if-setninger.
Feilhåndtering - Programmet bruker try/catch for å håndtere feil. Dersom brukeren forsøker å dele på null, vises en feilmelding.
Løkker - Programmet bruker en while-løkke slik at brukeren kan utføre flere bergeninger. Løkken avsluttes med break når brukeren ikke ønsker å fortsette.
Funksjonalitet.
Addisjon, subtraksjon, multiplikasjon, divisjon, kontroll av brukerinput, feilhåndtering ved divisjon med null og muligheter for flere bergninger uten å starte programmet på nytt.

Begrensninger.
Kalkulatoren støtter kun heltall.

Teknologier
C#, .NET, VS code og Git

How to:
Åpne terminal og skriv: dotnet run
