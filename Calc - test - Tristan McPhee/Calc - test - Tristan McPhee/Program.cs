
class Calculatrice
{
    static void Main()
    {
        Console.WriteLine(" _____-----_____Calculatrice simple______------______");
        Console.Write("Entrez le premier nombre réel : ");
        if (!double.TryParse(Console.ReadLine(), out double nb1))
        {
            Console.WriteLine("❌ Entrée invalide pour le premier nombre.");
            return;
        }
        Console.Write("Entrez le deuxième chiffre réel : ");
        if (!double.TryParse(Console.ReadLine(), out double nb2))
        {
            Console.WriteLine(" Oops! Mauvaise entrée pour le deuxième chiffre!");
            return;
        }
        Console.Write("Entrez l’opération (+, -, *, /) : ");
        string operation = Console.ReadLine();
        double resultat;
        bool operationValide = true;
        switch (operation)
        {
            case "+":
                resultat = nb1 + nb2;
                Console.WriteLine($"{nb1} + {nb2} = {resultat}");
                break;
            case "-":
                resultat = nb1 - nb2;
                Console.WriteLine($"{nb1} - {nb2} = {resultat}");
                break;
            case "*":
                resultat = nb1 * nb2;
                Console.WriteLine($"{nb1} * {nb2} = {resultat}");
                break;
            case "/":
                if (nb2 == 0)
                {
                    Console.WriteLine("Oh non! : une division par un zéro est impossible! S'il vous plait ressayez");
                }
                else
                {
                    resultat = nb1 / nb2;
                    Console.WriteLine($"{nb1} / {nb2} = {resultat}");
                }
                break;
            default:
                operationValide = false;
                Console.WriteLine(" Oops.... Opération invalide. Utilisez +, -, *, ou /.");
                break;
        }
        if (operationValide)
        { Console.WriteLine("✅ Calcul terminé avec succès.");
        }
    }
}

