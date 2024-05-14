namespace projetfarhat2
{
    public class Main
    {
        //Etape :
        Console.WriteLine("Que voulez-vous faire (Ajouter, Supprimer, Afficher ou Mettre à jour une tâche) ?")
        WhatIDo = Console.ReadLine();
        ChoiseToDo(WhatIDo)
        // Etape 1 : 
        // Demander ce que l'utilisateur veux faire (Add, Delete, Show, MAJ)
        public static string ChoiseToDo(string WhatIDo)
        {
            
            switch (WhatIDo)
            {
                //Demander la tache qu'il veux ajouter et l'envoyer a la methode AjouterTache
                case "Ajouter":
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est le nom de la tache que vous voulez Ajouter ?")
                    NomTache = Console.ReadLine();
                    //Demander la description à associer à la tache
                    Console.WriteLine("Quel est la description de la tache que vous voulez Ajouter ?")
                    DescriptionTache = Console.ReadLine();
                    //Demander la DateDeFin souhaiter de la tache
                    Console.WriteLine("Quel est la date de fin de la tache que vous voulez Ajouter ?")
                    DateFinTache = Console.ReadLine();
                    AjouterTache.AddTache(NomTache, DescriptionTache, DateFinTache)

                //Demander la tache qu'il veux Supprimer et l'envoyer a la methode SupprimerTache
                case "Supprimer"
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est le nom de la tache que vous voulez Supprimer ?")
                    NomTache = Console.ReadLine();
                    SupprimerTache.DeleteTache(NomTache)

                //Demander la tache qu'il veux Afficher et l'envoyer a la methode AfficherTache
                case "Afficher"
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est le nom de la tache que vous voulez Afficher ?")
                    NomTache = Console.ReadLine();
                    SupprimerTache.DeleteTache(NomTache)

                //Demander la tache qu'il veux Mettre à jour et l'envoyer a la methode MettreAJourTache
                case "Mettre à jour"
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est le nom de la tache que vous voulez Mettre à jour ?")
                    NomTache = Console.ReadLine();
                    SupprimerTache.DeleteTache(NomTache)

                default:
                    break;
            }
        }

        // Etape 2 :
        // Appeller la méthode correspondante


        // Etape 3 :
        // Lire/Ecrire les info correspondantes

        // Etape 4 :
        // 
    }
}
