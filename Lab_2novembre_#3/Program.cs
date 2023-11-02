namespace Lab_2novembre__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix = "";

            while (choix != "4")
            {
                AfficherMenu();
                choix = ObtenirStringUtilisateur("Entrez votre choix : ");

                if (choix == "1")
                {
                    ProgrammeVerifierPair();
                }
                else if (choix == "2")
                {
                    ProgrammeVerifierPalindrome();
                }
                else if (choix == "3")
                {
                    ProgrammeVerifierPalindromeEtPair();
                }
            }
        }

        public static void ProgrammeVerifierPalindrome()
        {
            string texte = ObtenirStringUtilisateur("Entrez une chaîne de caractères en minuscules à vérifier : ");
            bool estPalindrome = EstPalindrome(texte);

            if (estPalindrome)
            {
                Console.WriteLine($"{texte} est un palindrôme.");
            }
            else
            {
                Console.WriteLine($"{texte} n'est pas un palindrôme.");
            }
        }
        
        public static void ProgrammeVerifierPair()
        {
                int nombre = ObtenirEntierUtilisateur("Entrez un nombre entier (10 caractères maximum) : ");
                bool estPair = EstPair(nombre);

                if (estPair)
                {
                    Console.WriteLine($"Le nombre {nombre} est pair");
                }
                else
                {
                    Console.WriteLine($"Le nombre {nombre} n'est pas pair");
                }
            
        }

        public static void ProgrammeVerifierPalindromeEtPair()
        {
            int entier = ObtenirEntierUtilisateur("Entrez un entier à vérifier : ");
            string entierEnString = entier.ToString();
            bool estPair = EstPair(entier);
            bool estPalindrome = EstPalindrome(entierEnString);

            if (estPalindrome && estPair) 
            {
                Console.WriteLine($"{entier} est un entier palindrôme pair.");
            }
            else
            {
                Console.WriteLine($"{entier} n'est pas un entier palindrôme pair.");
            }
        }
        public static void AfficherMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("(1) - Vérifier si un nombre est pair");
            Console.WriteLine("(2) - Vérifier si une chaîne de caractères est un palindrôme");
            Console.WriteLine("(3) - Vérifier si un nombre est pair ET est un palindrôme");
            Console.WriteLine("(4) - Quitter");
        }

        public static string InverserTexte(string texteEntree)
        {
            string texteSortie = "";

            for (int i = texteEntree.Length - 1; i >= 0; i--)
            {
                texteSortie += texteEntree[i];
            }

            return texteSortie;
        }

        public static string ObtenirStringUtilisateur(string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool EstPalindrome(string texte)
        {
            return InverserTexte(texte) == texte;
        }

        public static int ObtenirEntierUtilisateur(string message)
        {
            bool conversionReussie = false;
            int nombre = 0;

            while (conversionReussie != true)
            {
                string entreeUtilisateur = ObtenirStringUtilisateur(message);
                conversionReussie = int.TryParse(entreeUtilisateur, out nombre);
            }
            return nombre;
        }

        public static bool EstPair(int nombre)
        {
            return nombre % 2 == 0;
        }
    }
}