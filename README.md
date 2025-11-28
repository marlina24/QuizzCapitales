Projet QuizzCapitales
Petit exercice en C# consistant à créer un quiz sur les capitales avec gestion du score, rejouabilité et découpage du code en fonctions.


Objectif du projet : 
Apprendre à créer et appeler des méthodes en C#
Manipuler les tableaux (pays / capitales)
Utiliser une boucle pour poser plusieurs questions
Structurer le code dans plusieurs fichiers (Program.cs, Quizz.cs)
Découvrir l’utilisation de Git et GitHub pour versionner un projet

Fonctionnement
Le jeu :
Pose une série de questions du type :
"Quelle est la capitale de … ?"
Compare la réponse de l’utilisateur avec la bonne capitale
Incrémente le score en cas de bonne réponse
Affiche le score total
Propose de rejouer




            +----------------------+
          |      Program.cs      |
          +----------+-----------+
                     |
                     v
          +----------------------+
          |       Quizz.cs       |
          |  - Questions         |
          |  - Score             |
          |  - Rejouabilité     |
          +----------+-----------+
                     |
                     v
          +----------------------+
          |   Méthodes appelées  |
          |  Jouer() / PoserQ()  |
          +----------------------+


Marlina Victor
Étudiante en BTS SIO – option SLAM.

