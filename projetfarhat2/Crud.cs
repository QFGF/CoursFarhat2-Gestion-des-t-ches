using projetfarhat2;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Crud
{
	    public static void AddTache(string IdTache, string NomTache, string DescriptionTache, string DateFinTache)
        {
            Tache AddedTache = new Tache("T" + IdTache, NomTache, DescriptionTache, DateFinTache);

            // Ajout de la nouvelle tâche à la liste
            ListeTaches.ListTache.Add(AddedTache);
        }

        public static string ShowTache(string IdTache)
        {
            return "y";
        }

        public static string MajTache(string IdTache)
        {
            return "y";
        }

        public static string DeleteTache(string IdTache)
        {
            return "y";
        }
}
