// Saisie des éléments du premier tableau
Console.WriteLine("-> Tableau 1:");
Console.Write("Saisir la taille du tableau: "); // Demande à l'utilisateur de saisir la taille des tableaux
int taille01 = int.Parse(Console.ReadLine());
int[] tableau1 = SaisirTableau(taille01);

// Saisie des éléments du deuxième tableau
Console.WriteLine("-> Tableau 2:");
Console.Write("Saisir la taille du tableau: "); // Demande à l'utilisateur de saisir la taille des tableaux
int taille02 = int.Parse(Console.ReadLine());
int[] tableau2 = SaisirTableau(taille02);

if(taille01 != taille02)
{
    Console.WriteLine("La taille des deux tableaux est différente donc cela ne marchera pas. FIN DU PROGRAMME");
    System.Environment.Exit(1);
}

// Calcul du tableau résultant de la somme des deux tableaux
int[] tableauSomme = CalculerSommeTableaux(tableau1, tableau2);

// Affichage du tableau résultant
Console.WriteLine("-> Somme des deux tableaux:");
AfficherTableau(tableauSomme);



// Méthode pour saisir un tableau
static int[] SaisirTableau(int taille)
{
    int[] tableau = new int[taille];
    for (int i = 0; i < taille; i++)
    {
        Console.Write($"Saisir l'élément {i + 1}: ");
        tableau[i] = int.Parse(Console.ReadLine());
    }
    return tableau;
}

// Méthode pour calculer la somme de deux tableaux
static int[] CalculerSommeTableaux(int[] tableau1, int[] tableau2)
{
    int taille = tableau1.Length;
    int[] tableauSomme = new int[taille];
    for (int i = 0; i < taille; i++)
    {
        tableauSomme[i] = tableau1[i] + tableau2[i];
    }
    return tableauSomme;
}

// Méthode pour afficher un tableau
static void AfficherTableau(int[] tableau)
{
    foreach (int element in tableau)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}