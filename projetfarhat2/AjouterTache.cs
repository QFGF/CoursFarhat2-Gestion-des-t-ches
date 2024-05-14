namespace projetfarhat2
{
    public class AjouterTache
    {
        public static string AddTache( string NomTache, string DescriptionTache, string DateFinTache, string IdTache) 
        {
            Tache AddedTache = new Tache
            {
                IdTache = "T" + IdTache,
                NomTache,
                DescriptionTache,
                DateFinTache
            };

            // Ajout de la nouvelle tâche à la liste
            ListeTaches.ListTache.Add(AddedTache);
        }

    }
}
