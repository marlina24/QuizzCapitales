using System;

namespace QuizzCapitales
{
    internal class Quizz
    {
        // Tableaux des pays et des capitales
        static string[] pays = { "Haïti", "France", "Colombie", "Republique.Dominicaine", "Bulgarie", "Allemagne" };

        static string[] capitales = { "Port-au-prince", "Paris", "Bogota", "Santo Domingo", "Sofia", "Berlin" };

        
        public static void Jouer()
        {
            
            int[] toutesLesQuestions = { 0, 1, 2, 3, 4, 5 };

            Jouer(toutesLesQuestions);
        }

        
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

        // Fonction qui pose une question et renvoie 1 si bonne réponse, 0 sinon
        static int PoserQuestion(string pays, string capitale)
        {
            Console.WriteLine("Quel est la capitale de " + pays + " ?");
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
    }
}
