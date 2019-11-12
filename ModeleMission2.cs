using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Github_Tajek
{
    public static class ModeleMission2
    {
        private static RAPPORT rapportChoisi;
        private static MEDECIN medecinChoisi;


        private static PPE3_TAJEKEntities maConnexion;

        public static RAPPORT RapportChoisi { get => rapportChoisi; set => rapportChoisi = value; }
        public static MEDECIN MedecinChoisi { get => medecinChoisi; set => medecinChoisi = value; }

        public static void init()
        {
      
            maConnexion = new PPE3_TAJEKEntities();
        }

        public static List<RAPPORT> listeRapport()
        {
            return maConnexion.RAPPORT.ToList();
        }

        public static List<MEDECIN> listeMedecin()
        {
            return maConnexion.MEDECIN.ToList(); 
        }

        public static List<OFFRIR> listeOffrir()
        {
            return maConnexion.OFFRIR.ToList();
        }

        public static List<MOTIF> listeMotif()
        {
            return maConnexion.MOTIF.ToList();
        }

        public static List<Visiteur> listeVisiteurs()
        {
            return maConnexion.Visiteur.ToList();
        }

            /*public static bool AjoutRapport(int idRapport, DateTime dateRapport, int idMotif, string bilan, int idMedecin)
            {
                rapportChoisi = new RAPPORT; 

            }*/

            public static void ModifRapport(int idRapport, DateTime dRapport, int idMotif, string b, int idMedecin)
        {
            rapportChoisi.dateRapport = dRapport;
            rapportChoisi.bilan = b; // b = bilan
        
        }

        public static MEDECIN trouveMedecin(int y)
        {
            var LQuery = maConnexion.MEDECIN.ToList()
                           .Where(x => x.idMedecin == y);
            return ((MEDECIN)LQuery.ToList().First());

        }

        public static bool ModifRapport(string medecin, DateTime date, string motif, string bilan)
        {
            bool vertour = true;
            try
            {
                rapportChoisi.MEDECIN.nom = medecin;
                rapportChoisi.dateRapport = date;
                rapportChoisi.MOTIF.libMotif  = motif;
                rapportChoisi.bilan = bilan; 
            }
            catch (Exception ex)
            {
                vertour = false;
            }
            return vertour;
        }
    }
}
