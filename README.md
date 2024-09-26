# SCOUT

Vi Bengtsfors Scoutförening organiserar många aktiviteter för våra medlemmar, men vi har svårt att hålla koll på vem som deltar och vilka aktiviteter som har genomförts. Vi skulle vilja ha ett system där vi kan logga varje aktivitet och notera vilka som varit närvarande. Det vore också bra om vi kunde följa upp med noteringar om vad vi gjorde under aktiviteten, så vi har historik på genomförda scoutmöten. Dessutom vore det bra om vi kunde skicka automatiska påminnelser om kommande aktiviteter.

* Skapa och öppna en mapp som heter "Scout"

* Öppna terminalen och skriv följande kommandon:
```bash
dotnet new console
dotnet new gitignore
git init
git add .
git commit -m "Initial commit"
```

* Skapa klassen Scout i filen "Scout.cs" och ge den följande egenskaper: Name, Email, Phone och Birthdate. 

* Skapa klassen "Activity" i filen "Activity.cs" och ge den följande egenskaper: Name, Date, Location, Participants och Notes. Ge den också en metod "AddParticipant(Scout s)" som lägger till en scout i listan Participants.

* Det kan vara bra att ha en klass som håller reda på alla scouter och aktiviteter, så att det inte behöver ligga i koden för användargränssnittet. Detta kan göras med en så kallad Repository-klass. Skapa klassen ScoutRepository i "ScoutRepository.cs" och ge den följande fält (listor): scouts och activities. Skapa sedan följande metoder: AddScout(Scout s), AddActivity(Activity a), GetComingActivities(), GetPastActivities() och SendReminder(Activity a).

* I filen "Program.cs" skapa och lägg till några scouter i repository-klassen med AddScout, skapa och lägg till en aktivitet, lägg till några deltagare till aktiviteten med AddParticipant(), visa genomförda aktiviteter genom att anropa GetPastActivities() och skriv ut info om aktiviteten och deltagarna med Console.WriteLine

* Valfritt: Gör ett användargränssnitt där man kan göra dessa saker mer dynamiskt och inte "hårdkodat".
