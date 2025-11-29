using System;

namespace QuizzCapitales
{
    internal class Quizz
    {
        // Tableaux des pays et des capitales
        static string[] pays = { "Haïti", "France", "Colombie", "Republique.Dominicaine", "Bulgarie", "Allemagne" };

        static string[] capitales = { "Port-au-prince", "Paris", "Bogota", "Santo Domingo", "Sofia", "Berlin" };

       
        //  Jouer avec TOUTES les questions
        
        public static void Jouer()
        {
            int[] toutesLesQuestions = { 0, 1, 2, 3, 4, 5 };
            Jouer(toutesLesQuestions);
        }

        
        //  Jouer avec une liste de numéros précis
        
        public static void Jouer(params int[] numQuestions)
        {
            string? choix;

            do
            {
                int score = 0;

                // Pose uniquement les questions dont on donne les numéros
                foreach (int num in numQuestions)
                {
                    score += PoserQuestion(pays[num], capitales[num]);
                }

                Console.WriteLine("Vous avez obtenu " + score + " bonne(s) réponse(s).");
                Console.WriteLine();

                Console.WriteLine("Voulez-vous rejouer ? (O/N)");
                choix = Console.ReadLine();

                if (choix?.ToUpper() == "O")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Merci d'avoir joué !");
                }

            } while (choix?.ToUpper() == "O");

            Console.WriteLine("\nAppuyez sur Entrée pour quitter...");
            Console.ReadLine();
        }

        //  Pose UNE question

        static int PoserQuestion(string pays, string capitale)
        {
            Console.WriteLine("Quelle est la capitale de " + pays + " ?");
            string? reponse = Console.ReadLine();

            Console.WriteLine();

            if (reponse != null && reponse.Trim().ToLower() == capitale.ToLower())
            {
                Console.WriteLine("Bravo vous avez la bonne réponse !");
                return 1;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse. La réponse était " + capitale);
                return 0;
            }
        }

        //  Générer 3 numéros au hasard (tuple)

        public static (int, int, int) Generer3Numeros()
        {
            (int n1, int n2, int n3) numeros;

            Random rand = new Random();

            // indices possibles : 0 à 5 (car 6 pays)
            numeros.n1 = rand.Next(0, pays.Length);
            numeros.n2 = rand.Next(0, pays.Length);
            numeros.n3 = rand.Next(0, pays.Length);

            return numeros;  // renvoie les 3 nombres ensemble
        }

        //  Demander 3 numéros à l’utilisateur (tuple)

        public static (int, int, int) Saisir3Numeros()
        {
            (int n1, int n2, int n3) numeros;

            Console.WriteLine("Choisis 3 numéros de questions (entre 0 et 5) :");

            numeros.n1 = SaisirNombre(0, pays.Length - 1);
            numeros.n2 = SaisirNombre(0, pays.Length - 1);
            numeros.n3 = SaisirNombre(0, pays.Length - 1);

            return numeros;
        }

        //  Demander un nombre dans un intervalle

        static int SaisirNombre(int min, int max)
        {
            int num;
            bool ok;

            do
            {
                Console.Write($"Saisissez un nombre entre {min} et {max} : ");
                Console.WriteLine();
                string? rep = Console.ReadLine();

                ok = int.TryParse(rep, out num) && num >= min && num <= max;

                if (!ok)
                {
                    Console.WriteLine("Valeur incorrecte, recommence.");
                }

            } while (!ok);

            return num;
        }
    }
}
