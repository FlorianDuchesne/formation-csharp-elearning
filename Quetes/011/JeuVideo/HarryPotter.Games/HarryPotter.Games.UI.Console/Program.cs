﻿// See https://aka.ms/new-console-template for more information


Player player = new Player("yoda", Console.WriteLine);
Ennemi ennemi = new("Compte Doku", Console.WriteLine);
List<Force> listeForces = new List<Force>();

//string surname = null;

//surname.ToLower();

//Player player = new Player();

string titre = "Harry Potter game";
titre = "Un jeu épique !";

string sousTitre = "Harry Potter";

string temporaire = titre;
titre = sousTitre;
sousTitre = temporaire;


// Ca nous sert à ecrire dans le ouput
// 27/02/2022: Debug.WriteLine("==> Je teste" + titre);

// Des informations d'explications plus claires !

string titreEnMajuscule = titre.ToUpper();
Console.WriteLine(titreEnMajuscule);

Console.WriteLine(sousTitre.Substring(0, sousTitre.Length - 2));

// Console.WriteLine(sousTitre.Replace(" !", ""));

#region Framework du projet

// Affiche les crédits sur la console
void AffichageCredits()
{
    Console.WriteLine("**********");
    Console.WriteLine("Evan BOISSONNOT and Co");
    Console.WriteLine("2022-next");
    Console.WriteLine("**********");
}

void PreparerListeForces()
{
    listeForces.Add(new ForceLumineuse());
    listeForces.Add(new ForceObscure());
    listeForces.Add(new ForceNeutre());
}

void AfficherChoixForces()
{
    PreparerListeForces();
    Console.WriteLine("De quel côté de la force seras-tu ? ");
    int i = 0;
    foreach (Force force in listeForces)
    {
        Console.WriteLine(i + ": " + force);
        i++;
    }
    //Console.WriteLine("1. Du côté lumineux");
    //Console.WriteLine("2. Du côté obscur");
    //Console.WriteLine("3. Neutre, pas de force pour moi");

    // Créer une classe force qui puisse être lumineuse ou obscure et l'afficher à la place menu ci-dessus
    // pouvoir sélectionner la force
    // l'affecter au player
}
    int AfficherForcesEtRetourneSelection()
{
    AfficherChoixForces();

    string saisieForce = Console.ReadLine();
    return int.Parse(saisieForce);
}

int[,] PrepareGrilleDuJeu()
{
    //int positionJoueur = 1;

    int[] positions = new int[10];

    //var position = positions[5];
    //Console.WriteLine(position);

    //bool[] etats = new bool[5];
    //Console.WriteLine(etats[2]);

    //string[] noms = new string[4];
    //Console.WriteLine(etats[2]);

    #region Approche matricielle
    int[,] grilleDeJeu = new int[20, 20];
    const int AUCUN_PERSO = -1;

    for (int i = 0; i < grilleDeJeu.GetLength(0); i++)
    {
        for (int j = 0; j < grilleDeJeu.GetLength(1); j++)
        {
            grilleDeJeu[i, j] = AUCUN_PERSO;
        }
    }
    #endregion

    return grilleDeJeu;
}

void AfficherMenu()
{
    Menu menu = new Menu();
    menu.AddItem(1, "nouvelle partie");
    menu.AddItem(2, "charger une partie");
    menu.AddItem(3, "crédits");
    menu.AddItem(4, "quitter");

    menu.Afficher(AfficherEnRouge);

    // Créer une classe qui représente le menu
    // sous-classe avec item menu qui va afficher menu
}

void AfficherEnRouge(object value)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.WriteLine(value);

    Console.ForegroundColor = ConsoleColor.White;
}

string RecupereSaisieAgeNonVide()
{
    bool ageSaisiPasValide = true;
    string ageSaisie = "";
    do
    {
        Console.WriteLine("Ton âge s'il te plaît ?");
        ageSaisie = Console.ReadLine();

        ageSaisiPasValide = string.IsNullOrWhiteSpace(ageSaisie);

    } while (ageSaisiPasValide);

    return ageSaisie;
}

int DemandeEtRecupereAgeValid()
{
    int ageLocalPlayer = -1;
    bool estAgeValid = false;

    while (!estAgeValid)
    {
        string ageSaisie = RecupereSaisieAgeNonVide();

        int.TryParse(ageSaisie, out ageLocalPlayer);

        //try
        //{
        //    agePlayer = int.Parse(ageSaisie); // int.MaxValue;
        //                                      // agePlayer = agePlayer + 10;
        //}
        //catch (FormatException ex)
        //{
        //    agePlayer = 0;
        //    throw new AgeNonValideException();
        //}
        //finally
        //{
        //    Console.WriteLine("Et oui c'est pas bien saisi");

        int ageMinimum = 12;

        int comparaison = ageLocalPlayer.CompareTo(ageMinimum);
        Console.WriteLine(comparaison);

        estAgeValid = comparaison >= 0;
    }
    //catch (FormatException ex) 
    //{
    //    Console.WriteLine(ex.Message);
    //    throw;
    //}

    

    return ageLocalPlayer;
}

void AfficherInfoAuSujetAge(int agePlayer = 0)
{
    if (agePlayer > 0)
    {
        Console.WriteLine("Yes, vous pouvez continuer la saisie !");

        if (agePlayer < 18)
        {
            Console.WriteLine("Attention tu n'es pas majeur-e ...");
        }
        else if (agePlayer < 40)
        {
            Console.WriteLine("Ca va tu n'es pas trop vieux ... !");
        }
        else
        {
            Console.WriteLine("A priori, tu as au moins 40 ou plus ;)");
        }
    }
}

int RecupereAgeValide()
{
    int agePlayer = DemandeEtRecupereAgeValid();

    AfficherInfoAuSujetAge(agePlayer);

    return agePlayer;
}

DateOnly RecupererEtAfficherDateNaissance()
{
    Console.WriteLine("Quelle est ta date de naissance ?");
    string dateSaisie = Console.ReadLine();

    DateTime dateEtHeureNaissance = DateTime.Parse(dateSaisie);

    DateOnly dateNaissance = DateOnly.FromDateTime(dateEtHeureNaissance); // DateOnly.Parse(dateSaisie);

    Console.WriteLine("Tu as saisi " + dateNaissance);
    Console.WriteLine("Tu as saisi " + dateNaissance.ToString());

    return dateNaissance;
}

void AfficherArmes()
{
    float puissanceArme = 10;
    puissanceArme = 15.6f;

    Console.WriteLine(puissanceArme);

    int valeurParDefaultPuissanceArme = 10;
    // affectation sans cast : puissanceArme = valeurParDefaultPuissanceArme;

    Console.WriteLine("Choisissez votre arme pour démarrer le jeu :");

    // int j = 0;

    // j = j + 1; // 0 + 1
    // j = j + 1; // 1 + 1

    // j++; // 2 + 1

    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"{i + 1}. Arme {i + 1}");
        Console.WriteLine("{0}. Arme {0}", i + 1);
    }
}

void AfficherForceSelectionnee()
{
    int typeForce = AfficherForcesEtRetourneSelection();

    const int forceLumineuse = 0;
    const int forceObscur = 1;
    const int sansForce = 2;

    player.SetForce(listeForces[typeForce]); 

    switch (typeForce)
    {
        case forceLumineuse:
            {
                Console.WriteLine("Tu as choisi le côté lumineux");
            }
            break;

        case forceObscur:
            {
                Console.WriteLine("Tu as choisi le côté obscur");
            }
            break;

        case sansForce:
            {
                Console.WriteLine("Tu n'a pas de choix de force");
            }
            break;

        default:
            {
                Console.WriteLine("Tu n'a rien choisi comme force");
            }
            break;
    }
}
#endregion

#region Initialiation Moteur de jeu
#region Approche Tableau de tableau
//int[][][] grilleDeJeu = new int[20][][];

//for (int i = 0; i < 20; i++)
//{
//    grilleDeJeu[i] = new int[20][];
//    for (int j = 0; j < 20; j++)
//    {
//        grilleDeJeu[i][j] = new int[20];

//    }
//}
#endregion

// HarryPotter.Games.Core.Player player = new HarryPotter.Games.Core.Player("yoda");

    int[,] grille;

void InitDonneesJeu()
{
    grille = PrepareGrilleDuJeu();
}
#endregion

#region MENU
#region Ancienne version
// Formattage en une étape
//string itemMenu = "nouvelle partie";
//Console.WriteLine(format, 1, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());

//// Formattage en 2 étapes
////string itemMenu = "nouvelle partie";
////string resultatFormattage = string.Format(format, 1, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
////Console.WriteLine(resultatFormattage);

//itemMenu = "charger une partie";
//string resultatFormattage = $"{2}. {itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower()}"; 
//Console.WriteLine(resultatFormattage);

//itemMenu = "crédits";
//resultatFormattage = string.Format(format, 3, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//Console.WriteLine(resultatFormattage);

//itemMenu = "quitter";
//resultatFormattage = string.Format(format, 4, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//Console.WriteLine(resultatFormattage);


// Première étape avant formattage
//string itemMenu = "nouvelle partie";
//Console.WriteLine(1 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());

//itemMenu = "charger une partie";
//Console.WriteLine(2 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//itemMenu = "crédits";
//Console.WriteLine(3 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//itemMenu = "quitter";
//Console.WriteLine(4 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
#endregion

AfficherMenu();
#endregion

#region PARTIE SAISIE INFORMATIONS JOUEUR / JOUEUSE
#region Commentaires
//int j = 0;
//while (j < 2)
//{
//    Console.WriteLine("Test {0}", j);

//    j++;
//}

//int j = 0;
//do
//{
//    Console.WriteLine("Test {0}", j);

//    j++;
//} while (j < 2);
#endregion

int agePlayer = RecupereAgeValide();
Console.WriteLine(agePlayer);
#endregion

#region ---- DATE DE NAISSANCE -----
DateOnly dateNaissance = RecupererEtAfficherDateNaissance();
player.DateDeNaissance = dateNaissance;


Console.WriteLine($"Le player a la date {player.DateDeNaissance}");

//var player2 = new Player();

//player2 = player;
//player2.DateDeNaissance = new DateOnly(2000, 1, 1);
//Console.WriteLine($"Le player a la date {player2.DateDeNaissance}");
//Console.WriteLine($"Le player a la date {player.DateDeNaissance}");


#endregion

#region ---- PREPARATION ARME -----
//decimal puissanceArme = 10;
AfficherArmes();

// force cast : int valeurPuissanceX = (int) puissanceArme;
#endregion

#region ---- CHOIX COTE FORCE -----
AfficherForceSelectionnee();
#endregion

#region ---- AFFICHAGE CREDITS ----
AffichageCredits();
#endregion

InitDonneesJeu();


#region Lancement du jeu
player.SeDeplacer();
player.SeDeplacer(new Position(1, 1));
player.Attaquer(ennemi);
Console.ReadLine();
#endregion




