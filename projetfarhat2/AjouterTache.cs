namespace projetfarhat2
{
    public class AjouterTache
    {
        public static string AddTache(string NomTache, string DescriptionTache, string DateFinTache) 
        {
            Tache AddedTache = new Tache
            {

                NomTache,
                DescriptionTache,
                DateFinTache
            };

            // Ajout de la nouvelle tâche à la liste
            Add(AddedTache);
        }

    }
}
