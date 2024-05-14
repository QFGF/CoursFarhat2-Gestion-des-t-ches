namespace projetfarhat2
{
    //Création d'une Tache par default 
    public class Tache
    {
        public string IdTache { get; set; } = default!;
        public string NomTache { get; set; } = default!;
        public string DescriptionTache { get; set; } = default!;
        public string DateFinTache { get; set; } = default!;


        public Tache(string idTache, string nomTache, string descriptionTache, string dateFinTache)
        {
            IdTache = idTache;
            NomTache = nomTache;
            DescriptionTache = descriptionTache;
            DateFinTache = dateFinTache;
        }
    }
}
