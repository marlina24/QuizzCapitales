namespace QuizzCapitales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variante 1 : l’utilisateur choisit les questions
            (int n1, int n2, int n3) = Quizz.Saisir3Numeros();

            // Variante 2 : au hasard
            // (int n1, int n2, int n3) = Quizz.Generer3Numeros();

            // On lance le jeu avec ces 3 numéros
            Quizz.Jouer(n1, n2, n3);
        }
    }
}
