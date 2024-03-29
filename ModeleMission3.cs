﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Github_Tajek
{
    public static class ModeleMission3
    {
        private static PPE3_TAJEKEntities maConnexion;
        //booléen de connection pour acceder au fiche de frais,ect..
        private static bool connexionValid;
        //l'id pour faire les liens dans la base de données plus tard
        private static string iduser;

        public static void Init()
        {

            maConnexion = new PPE3_TAJEKEntities();
            //reprend le booléen de connection dans le modèle 1
            //connexionValid = ModeleMission1.getConnexionValide();
            //iduser = ModeleMission1.getid();
        }
        public static string getiduser()
        {
            return iduser;
        }
        public static List<FraisForfait> ListeFraisForfaits()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static List<LigneFraisForfait> ListeLigneFraisForfait()
        {
            return maConnexion.LigneFraisForfait.ToList();
        }

        public static List<fichefrais> Listefichefrais()
        {
            return maConnexion.fichefrais.ToList();
        }
        public static List<Etat> ListeEtat()
        {
            return maConnexion.Etat.ToList();
        }
        public static List<LigneFraisHorsForfait> ListeLigneFraisHorsForfait()
        {
            return maConnexion.LigneFraisHorsForfait.ToList();
        }
        public static List<Visiteur> ListeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

    }
}
