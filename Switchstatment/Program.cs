




Console.WriteLine("Guess my favourite subject(start with capital letter:)):");
var favSchoolSubject = Console.ReadLine();

switch (favSchoolSubject)
{

    case "English":

        Console.WriteLine("Yay thats it");
            break;

    case "Math":

        Console.WriteLine("Nope");
        break;

    case "Spanish":

        Console.WriteLine("Close");
        break;

    case "History":
        Console.WriteLine("Cool but nope");
        break;

    default:
        Console.WriteLine("Way Off");
        break;
}