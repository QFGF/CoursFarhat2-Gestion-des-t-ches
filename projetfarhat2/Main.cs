namespace projetfarhat2
{
    public class Main
    {
        // Etape 1 : 
        // Demander ce que l'utilisateur veux faire (Add, Delete, Show, MAJ)
        public static string ChoiseToDo(string WhatIDo)
        {
            Console.WriteLine("Que voulez-vous faire (Ajouter, Supprimer, Afficher ou Mettre à jour une tâche) ?");
            WhatIDo = Console.ReadLine();
            Crud.AddTache("Tache test 1", "C'est la tache numero 1", "26052024", "140520241");
            AjouterTache.AddTache("Tache test 2", "C'est la tache numero 2", "26052024", "140520242");
            AjouterTache.AddTache("Tache test 3", "C'est la tache numero 3", "26052024", "140520243");
            switch (WhatIDo)
            {
                //Demander la tache qu'il veux ajouter et l'envoyer a la methode AjouterTache
                case "Ajouter":
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est le nom de la tache que vous voulez Ajouter ?");
                    string NomTache = Console.ReadLine();
                    //Demander la description à associer à la tache
                    Console.WriteLine("Quel est la description de la tache que vous voulez Ajouter ?");
                    string DescriptionTache = Console.ReadLine();
                    //Demander la DateDeFin souhaiter de la tache
                    Console.WriteLine("Quel est la date de fin de la tache que vous voulez Ajouter ?");
                    string  DateFinTache = Console.ReadLine();
                    string IdTache = DateTime.Now.ToString();
                    Crud.AddTache(NomTache, DescriptionTache, DateFinTache, IdTache);
                    break;

                //Demander la tache qu'il veux Supprimer et l'envoyer a la methode SupprimerTache
                case "Supprimer":
                    //Demander l'ID de la tache
                    Console.WriteLine("Quel est l'ID de la tache que vous voulez Supprimer ?");
                    IdTache = Console.ReadLine();
                    SupprimerTache.DeleteTache(IdTache);
                    break;

                //Demander la tache qu'il veux Afficher et l'envoyer a la methode AfficherTache
                case "Afficher":
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est l'ID de la tache que vous voulez Afficher ?");
                    IdTache = Console.ReadLine();
                    AfficherTache.ShowTache(IdTache);
                    break;

                //Demander la tache qu'il veux Mettre à jour et l'envoyer a la methode MettreAJourTache
                case "Mettre à jour":
                    //Demander le nom de la tache
                    Console.WriteLine("Quel est l'ID de la tache que vous voulez Mettre à jour ?");
                    IdTache = Console.ReadLine();
                    MettreAJourTache.MajTache(IdTache);
                    break;

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
