




Console.WriteLine("Guess my favourite subject:");
var favSchoolSubject = Console.ReadLine();

switch (favSchoolSubject.ToLower())
{

    case "english":

        Console.WriteLine("Yay thats it");
            break;

    case "math":

        Console.WriteLine("Nope");
        break;

    case "spanish":

        Console.WriteLine("Close");
        break;

    case "history":
        Console.WriteLine("Cool but nope");
        break;

    default:
        Console.WriteLine("Way Off");
        break;
}