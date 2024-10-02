//KODSTANDARD - GRUNDER
//Använd engelska för all kod. Kommentarer kan vara på svenska men helst också de på engelska

namespace MyNamespace; // Namespace -> PascalCase

class Naming //Klassnamn -> PascalCase
{
    private static int s_someStaticThing; // Statiska medlemmar -> börja med s_
    private string _aPrivateField; //Privata fält -> camelCase, kan vara med eller utan _
    public string MyProperty { get; set; } //Properties -> Substantiv, PascalCase

    public Naming(string aPrivateField) //Konstruktor -> PascalCase
    {
        _aPrivateField = aPrivateField;
    }

    public void SomeMethod() //Metoder -> Verb, PascalCase (oavset public/private)
    {
        int myInt = 10; //Lokala variabler -> camelCase
    }
}