//Oppgave: Organ transplant!
//    Det har vært en akutt ulykke og Bernt ligger på sykehuset.

//    Han trenger en ny Nyre!

//Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!

//Hjelp Bernt med å overleve!

//Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.

//    Lag gjerne Consoll.WriteLine() - statements i koden slik at man ser hva som skjer!


using OrganTransplant;

var person1 = new Person("Bernt", false);
var person2 = new Person("Kåre", true);

bool transferSuccess = false;
Run();
 void Run()
{
    Console.WriteLine("Oh no! There's been an accident. \n Bernt has been rushed to the emergency room.");
    Console.WriteLine("His kidneys is failing, but his cousin's kidneys are a match.");
    Console.WriteLine("1. Have Bernt's cousin donate a kidney to Bernt. \n2. Let Bernt die. ");
    KidneyOrDie();
    person2.GiveKidney(person1);
    
}

 void KidneyOrDie()
{
    bool transferKidney = false;
    string userInput = Console.ReadLine();

        if (userInput == "1")
        {
        Console.WriteLine($"You chose to have {person2.Name} give one of his kidneys to {person1.Name}.\n" +
                          $"{person1.Name} is thankful.");
    }
        else if (userInput == "2")
        {
            Console.WriteLine("You let Bernt die. His ghost will haunt you for eternity.");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("You have to make a choice! Type 1 or 2.");
            KidneyOrDie();
            ;
        }
}
