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

        private static PPE3_TAJEKEntities maConnexion;

        public static RAPPORT RapportChoisi { get => rapportChoisi; set => rapportChoisi = value; }

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
        public static bool AjoutRapport(int idRapport, DateTime dateRapport, int idMotif, string bilan, int idMedecin)
        {
            rapportChoisi = new RAPPORT; 

        }

        public static void ModifRapport(int idRapport, DateTime dRapport, int idMotif, string b, int idMedecin)
        {
            rapportChoisi.dateRapport = dRapport;
            rapportChoisi.bilan = b; // b = bilan
            rapportChoisi. 
        }
    }
}
