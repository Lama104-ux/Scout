using ScoutApp.Core;
using ScoutApp.UI;

internal class Program
{
    private static void Main(string[] args)
    {
        ScoutRepository repo = new ScoutRepository(); //Starta grundfunktionalitet
        ScoutUI ui = new ScoutUI(repo); //Start UI och ge den referens till grundsystemet

        ui.Run(); //Kör igång huvudloopen
    }
}
