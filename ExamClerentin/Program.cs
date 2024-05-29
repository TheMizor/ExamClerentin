// Demande à l'utilisateur de saisir la taille des tableaux
Console.Write("Entrez la taille des tableaux: ");
int taille = int.Parse(Console.ReadLine());

// Saisie des éléments du premier tableau
Console.WriteLine("Saisissez les éléments du premier tableau:");
int[] tableau1 = SaisirTableau(taille);

// Saisie des éléments du deuxième tableau
Console.WriteLine("Saisissez les éléments du deuxième tableau:");
int[] tableau2 = SaisirTableau(taille);

// Calcul du tableau résultant de la somme des deux tableaux
int[] tableauSomme = CalculerSommeTableaux(tableau1, tableau2);

// Affichage du tableau résultant
Console.WriteLine("Tableau résultant de la somme des deux tableaux:");
AfficherTableau(tableauSomme);



// Méthode pour saisir un tableau
static int[] SaisirTableau(int taille)
{
    int[] tableau = new int[taille];
    for (int i = 0; i < taille; i++)
    {
        Console.Write($"Element {i + 1}: ");
        tableau[i] = int.Parse(Console.ReadLine());
    }
    return tableau;
}
